using ComicBooksLoanAppAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

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

        var optionsBuilder = new DbContextOptionsBuilder<comicbooksloanDbContext>();
        optionsBuilder.UseNpgsql(connectionString);

        return new comicbooksloanDbContext(optionsBuilder.Options);
    }
}
