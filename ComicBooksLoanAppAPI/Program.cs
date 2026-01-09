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

// PostgreSQL connection configuration
// Production: set ConnectionStrings__DefaultConnection to a full Neon connection string.
// Local dev: can provide DB_HOST/DB_PORT/DB_USERNAME/DB_PASSWORD/DB_DATABASE.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if (string.IsNullOrWhiteSpace(connectionString))
{
    var host = builder.Configuration["DB_HOST"];
    var dbPort = builder.Configuration["DB_PORT"];
    var username = builder.Configuration["DB_USERNAME"];
    var password = builder.Configuration["DB_PASSWORD"];
    var database = builder.Configuration["DB_DATABASE"];

    if (!string.IsNullOrWhiteSpace(host) &&
        !string.IsNullOrWhiteSpace(dbPort) &&
        !string.IsNullOrWhiteSpace(username) &&
        !string.IsNullOrWhiteSpace(password) &&
        !string.IsNullOrWhiteSpace(database))
    {
        connectionString = $"Host={host};Port={dbPort};Database={database};Username={username};Password={password};";
    }
}

// For normal runs, require a valid connection string.
// Design-time EF tooling uses `DesignTimeDbContextFactory` and shouldn't be blocked by this.
var isEfTooling = args.Any(a => string.Equals(a, "migrations", StringComparison.OrdinalIgnoreCase))
    || args.Any(a => string.Equals(a, "database", StringComparison.OrdinalIgnoreCase));

if (!isEfTooling)
{
    if (string.IsNullOrWhiteSpace(connectionString) ||
        connectionString.Contains("CHANGEME", StringComparison.OrdinalIgnoreCase))
    {
        throw new InvalidOperationException(
            "PostgreSQL requires a valid connection string. " +
            "Fix: set ConnectionStrings__DefaultConnection (recommended for production) or set DB_HOST/DB_PORT/DB_USERNAME/DB_PASSWORD/DB_DATABASE for local dev.");
    }
}

builder.Services.AddDbContext<comicbooksloanDbContext>(options =>
{
    options.UseNpgsql(connectionString, npgsqlOptions =>
    {
        npgsqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(10),
            errorCodesToAdd: null);
    });
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

    // Deployment often has a small window where the DB is not reachable yet.
    // Retry a few times so the service doesn’t crash on transient connect timeouts.
    const int maxAttempts = 5;
    var delay = TimeSpan.FromSeconds(2);

    for (var attempt = 1; attempt <= maxAttempts; attempt++)
    {
        try
        {
            var context = services.GetRequiredService<comicbooksloanDbContext>();

            // PostgreSQL: apply migrations
            await context.Database.MigrateAsync();

            // If the DB exists but has no data, populate it from the current DatabaseSeeder.
            await DatabaseSeeder.SeedDatabaseIfEmptyAsync(context, logger);
            break;
        }
        catch (Exception ex) when (attempt < maxAttempts)
        {
            logger.LogWarning(ex, "Database initialization attempt {Attempt}/{MaxAttempts} failed; retrying in {Delay}...", attempt, maxAttempts, delay);
            await Task.Delay(delay);
            delay = TimeSpan.FromSeconds(Math.Min(delay.TotalSeconds * 2, 15));
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Database initialization failed");
            throw;
        }
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
