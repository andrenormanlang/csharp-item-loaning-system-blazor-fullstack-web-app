using ComicBooksLoanAppAPI.Data;
using ComicBooksLoanAppAPI.Repositories;
using ComicBooksLoanAppAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.HttpOverrides;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Render (and similar platforms) inject a dynamic port via PORT.
// Binding explicitly avoids IPv6-only binds that can break platform health checks.
var port = Environment.GetEnvironmentVariable("PORT");
if (!string.IsNullOrWhiteSpace(port))
{
    builder.WebHost.UseUrls($"http://0.0.0.0:{port}");
}

// Database provider + connection string
// - For production-faithful deployments (Render): MySQL
// - You can still override via Database__Provider if needed.
var configuredProvider = builder.Configuration["Database:Provider"]?.Trim();
var dbProvider = string.IsNullOrWhiteSpace(configuredProvider)
    ? (builder.Environment.IsProduction() ? "MySql" : "SqlServer")
    : configuredProvider;
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

var isMySql = dbProvider.Equals("MySql", StringComparison.OrdinalIgnoreCase);
if (isMySql)
{
    // Never silently fall back to placeholder credentials.
    if (string.IsNullOrWhiteSpace(connectionString) ||
        connectionString.Contains("CHANGEME", StringComparison.OrdinalIgnoreCase))
    {
        throw new InvalidOperationException(
            "MySQL provider selected, but ConnectionStrings:DefaultConnection is missing or contains a placeholder password. " +
            "Fix: set ConnectionStrings__DefaultConnection (recommended), or switch to SQL Server for local dev by setting Database__Provider=SqlServer. " +
            "Example MySQL: Server=<host>;Port=<port>;Database=defaultdb;User=<user>;Password=<password>;SslMode=Required;");
    }
}
else
{
    // Local dev fallback (Windows only). Do not use this in production containers.
    if (string.IsNullOrWhiteSpace(connectionString))
    {
        connectionString = "Server=(localdb)\\mssqllocaldb;Database=ComicBooksLoanDb;Integrated Security=true;TrustServerCertificate=true;";
    }
}

builder.Services.AddDbContext<comicbooksloanDbContext>(options =>
{
    if (isMySql)
    {
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
    else
    {
        options.UseSqlServer(connectionString);
    }
});

// Register repositories
builder.Services.AddScoped<IComicRepository, ComicRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IMessageRepository, MessageRepository>();

// Register services
builder.Services.AddScoped<IComicService, ComicService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IMessageService, MessageService>();

// Add services to the container.
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        // Configure JSON serialization to ignore circular references
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });

// Add Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS for WebAssembly client
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowClient", policy =>
    {
        var origins = builder.Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>() ?? Array.Empty<string>();

        if (origins.Length > 0)
        {
            policy.WithOrigins(origins)
                .AllowAnyMethod()
                .AllowAnyHeader();
        }
        else
        {
            // If not configured, allow all (helps first-time deployment).
            policy.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        }
    });
});

var app = builder.Build();

// Lightweight endpoint for platform health checks.
app.MapGet("/healthz", () => Results.Ok("ok"));

// Render (and most container platforms) run behind a reverse proxy that terminates TLS.
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

// Create database (if missing) and seed data (if empty) on startup
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var logger = services.GetRequiredService<ILoggerFactory>().CreateLogger("DatabaseStartup");

    try
    {
        var context = services.GetRequiredService<comicbooksloanDbContext>();

        // SQL Server: apply migrations (existing migrations were created for SQL Server)
        // MySQL: ensure schema exists based on the current model
        if (dbProvider.Equals("MySql", StringComparison.OrdinalIgnoreCase))
        {
            await context.Database.EnsureCreatedAsync();
        }
        else
        {
            await context.Database.MigrateAsync();
        }

        // If the DB exists but has no data, populate it from the current DatabaseSeeder.
        await DatabaseSeeder.SeedDatabaseIfEmptyAsync(context, logger);
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "Database initialization failed");
        throw;
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// In container platforms, TLS is typically terminated at a reverse proxy.
// Avoid HTTPS redirection when PORT is provided (proxy handles external HTTPS).
if (string.IsNullOrWhiteSpace(port))
{
    app.UseHttpsRedirection();
}

app.UseCors("AllowClient");

app.UseAuthorization();

app.MapControllers();

app.Run();
