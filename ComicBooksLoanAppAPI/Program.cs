using ComicBooksLoanAppAPI.Data;
using ComicBooksLoanAppAPI.Repositories;
using ComicBooksLoanAppAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.HttpOverrides;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Database provider + connection string
// - Dev default: SQL Server LocalDB
// - Prod (Render): set Database__Provider=MySql and ConnectionStrings__DefaultConnection
var dbProvider = builder.Configuration["Database:Provider"]?.Trim() ?? "SqlServer";
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

if (string.IsNullOrWhiteSpace(connectionString))
{
    connectionString = dbProvider.Equals("MySql", StringComparison.OrdinalIgnoreCase)
        ? "Server=localhost;Port=3306;Database=defaultdb;User=avnadmin;Password=CHANGEME;SslMode=Required;"
        : "Server=(localdb)\\mssqllocaldb;Database=ComicBooksLoanDb;Integrated Security=true;TrustServerCertificate=true;";
}

builder.Services.AddDbContext<comicbooksloanDbContext>(options =>
{
    if (dbProvider.Equals("MySql", StringComparison.OrdinalIgnoreCase))
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

app.UseHttpsRedirection();

app.UseCors("AllowClient");

app.UseAuthorization();

app.MapControllers();

app.Run();
