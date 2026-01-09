using ComicBooksLoanAppAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Npgsql;

namespace ComicBooksLoanAppAPI.Data;

public sealed class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<comicbooksloanDbContext>
{
    public comicbooksloanDbContext CreateDbContext(string[] args)
    {
        // Design-time factory for `dotnet ef` operations (migrations).
        // Uses the same env vars as runtime.
        var connectionString =
            Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection")
            ?? Environment.GetEnvironmentVariable("CONNECTIONSTRINGS__DEFAULTCONNECTION")
            ?? Environment.GetEnvironmentVariable("DefaultConnection")
            ?? Environment.GetEnvironmentVariable("DATABASE_URL");

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            var host = Environment.GetEnvironmentVariable("DB_HOST");
            var port = Environment.GetEnvironmentVariable("DB_PORT") ?? "5432";
            var username = Environment.GetEnvironmentVariable("DB_USERNAME");
            var password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            var database = Environment.GetEnvironmentVariable("DB_DATABASE") ?? "comicbooksloan";

            if (!string.IsNullOrWhiteSpace(host) &&
                !string.IsNullOrWhiteSpace(username) &&
                !string.IsNullOrWhiteSpace(password))
            {
                connectionString = $"Host={host};Port={port};Database={database};Username={username};Password={password};";
            }
        }

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            // Safe fallback for local tooling so migrations can be generated without requiring secrets.
            connectionString = "Host=127.0.0.1;Port=5432;Database=comicbooksloan;Username=postgres;Password=postgres";
        }

        if (connectionString.StartsWith("postgres://", StringComparison.OrdinalIgnoreCase) ||
            connectionString.StartsWith("postgresql://", StringComparison.OrdinalIgnoreCase))
        {
            connectionString = ConvertPostgresUrlToConnectionString(connectionString);
        }

        var optionsBuilder = new DbContextOptionsBuilder<comicbooksloanDbContext>();
        optionsBuilder.UseNpgsql(connectionString);

        return new comicbooksloanDbContext(optionsBuilder.Options);
    }

    private static string ConvertPostgresUrlToConnectionString(string databaseUrl)
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
            SslMode = SslMode.Require
        };

        return builder.ConnectionString;
    }
}
