using ComicBooksLoanAppAPI.Data;
using ComicBooksLoanAppAPI.Repositories;
using ComicBooksLoanAppAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.HttpOverrides;
using Npgsql;
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

// Some hosts (Render/Heroku/Neon examples) provide URL-style connection strings like:
// postgresql://user:password@host:5432/dbname?sslmode=require
// Npgsql expects a key/value connection string, so convert if needed.
if (string.IsNullOrWhiteSpace(connectionString))
{
    connectionString = builder.Configuration["DATABASE_URL"];
}

if (!string.IsNullOrWhiteSpace(connectionString) &&
    (connectionString.StartsWith("postgres://", StringComparison.OrdinalIgnoreCase) ||
     connectionString.StartsWith("postgresql://", StringComparison.OrdinalIgnoreCase)))
{
    connectionString = ConvertPostgresUrlToConnectionString(connectionString);
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

static string ConvertPostgresUrlToConnectionString(string databaseUrl)
{
    if (!Uri.TryCreate(databaseUrl, UriKind.Absolute, out var uri) ||
        (!string.Equals(uri.Scheme, "postgres", StringComparison.OrdinalIgnoreCase) &&
         !string.Equals(uri.Scheme, "postgresql", StringComparison.OrdinalIgnoreCase)))
    {
        return databaseUrl;
    }

    var userInfo = uri.UserInfo.Split(':', 2);
    var username = userInfo.Length > 0 ? Uri.UnescapeDataString(userInfo[0]) : string.Empty;
    var password = userInfo.Length > 1 ? Uri.UnescapeDataString(userInfo[1]) : string.Empty;

    var builder = new NpgsqlConnectionStringBuilder
    {
        Host = uri.Host,
        Port = uri.IsDefaultPort ? 5432 : uri.Port,
        Database = uri.AbsolutePath.TrimStart('/'),
        Username = username,
        Password = password,
        // Most hosted Postgres providers require TLS.
        SslMode = SslMode.Require
    };

    // Apply common query string options (e.g., sslmode=require)
    var query = uri.Query;
    if (!string.IsNullOrWhiteSpace(query))
    {
        foreach (var part in query.TrimStart('?').Split('&', StringSplitOptions.RemoveEmptyEntries))
        {
            var kv = part.Split('=', 2);
            var key = Uri.UnescapeDataString(kv[0]);
            var value = kv.Length > 1 ? Uri.UnescapeDataString(kv[1]) : string.Empty;

            if (key.Equals("sslmode", StringComparison.OrdinalIgnoreCase))
            {
                // Common values: disable, allow, prefer, require, verify-ca, verify-full
                // Npgsql enum names: Disable, Prefer, Require, VerifyCA, VerifyFull
                var normalized = value.Trim().ToLowerInvariant();
                builder.SslMode = normalized switch
                {
                    "disable" => SslMode.Disable,
                    "allow" => SslMode.Prefer,
                    "prefer" => SslMode.Prefer,
                    "require" => SslMode.Require,
                    "verify-ca" => SslMode.VerifyCA,
                    "verify-full" => SslMode.VerifyFull,
                    _ => builder.SslMode
                };

                continue;
            }

            if (key.Equals("pooling", StringComparison.OrdinalIgnoreCase) && bool.TryParse(value, out var pooling))
            {
                builder.Pooling = pooling;
                continue;
            }

            // Note: 'Trust Server Certificate' is obsolete in modern Npgsql; ignore if present.
        }
    }

    return builder.ConnectionString;
}

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
        var origins = builder.Configuration.GetSection("https://comics-loan-app.onrender.com/").Get<string[]>() ?? Array.Empty<string>();

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
