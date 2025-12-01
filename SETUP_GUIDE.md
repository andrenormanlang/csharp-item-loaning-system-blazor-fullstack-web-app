# Setup & Configuration Guide

## Prerequisites

- .NET 9 SDK installed
- SQL Server Express or Full Edition
- Visual Studio 2022 or VS Code with C# extension
- Node.js (optional, for advanced development)

## Database Configuration

### 1. Connection String Setup

Edit the connection string in `ComicBooksExchangeAppAPI/Program.cs`:

```csharp
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
    ?? "Server=.;Database=ComicBooksExchange;Integrated Security=true;TrustServerCertificate=true;";
```

Or update `appsettings.json` (create if not exists):

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ComicBooksExchange;Integrated Security=true;TrustServerCertificate=true;"
  }
}
```

### 2. Create Database

Navigate to the API project and run:

```bash
cd ComicBooksExchangeAppAPI
dotnet ef database update
```

This will:
- Create the `ComicBooksExchange` database
- Run all migrations
- Create tables with relationships and constraints

### 3. Verify Database

Connect to SQL Server and verify these tables exist:
- `Users`
- `Comics`
- `Exchanges`
- `Transactions`
- `Reviews`

## Running the Application

### Option 1: Visual Studio 2022

1. Open the solution `A6-ComicBooksExchangeApp.sln`
2. Set multiple startup projects:
   - ComicBooksExchangeAppAPI (startup)
   - A6-ComicBooksExchangeApp (startup)
3. Press F5 or click Run

### Option 2: Command Line

Terminal 1 - API Server:
```bash
cd ComicBooksExchangeAppAPI
dotnet run
```
API will be available at: `https://localhost:7291`

Terminal 2 - Blazor Server:
```bash
cd A6-ComicBooksExchangeApp
dotnet run
```
App will be available at: `https://localhost:7001`

### Option 3: Using launchSettings.json

The project includes `launchSettings.json` for easier running:

```bash
# From solution root
dotnet run --project ComicBooksExchangeAppAPI &
dotnet run --project A6-ComicBooksExchangeApp
```

## Project Structure

```
A6-ComicBooksExchangeApp/
├── ComicBooksExchangeAppAPI/
│   ├── Models/               # Domain entities
│   ├── Data/                 # DbContext, migrations
│   ├── Repositories/         # Data access layer
│   ├── Services/             # Business logic
│   ├── Controllers/          # API endpoints
│   ├── Validators/           # Validation rules
│   ├── Program.cs            # Configuration
│   └── appsettings.json      # Settings
├── A6-ComicBooksExchangeApp/
│   ├── Components/
│   │   ├── Pages/           # Blazor pages
│   │   └── Layout/          # Layout components
│   └── Program.cs           # Blazor server config
├── A6-ComicBooksExchangeApp.Client/
│   └── Components/          # WebAssembly components
├── README.md                # Project documentation
└── PROJECT_SUMMARY.md       # Development summary
```

## API Testing

### Using Swagger/OpenAPI

API endpoints are documented at:
```
https://localhost:7291/swagger
```

Or access OpenAPI docs at:
```
https://localhost:7291/openapi/v1.json
```

### Using Postman or Thunder Client

#### Example: Create a Comic

```http
POST https://localhost:7291/api/comics
Content-Type: application/json

{
  "title": "The Amazing Spider-Man",
  "issueNumber": 1,
  "publicationDate": "1963-04-20",
  "publisher": "Marvel",
  "characters": "Spider-Man, Doctor Octopus",
  "originalCoverPrice": 0.12,
  "estimatedValue": 2500.00,
  "conditionGrade": "Very Fine",
  "conditionDescription": "Clean pages, minor creasing on spine",
  "isProfessionallyGraded": true,
  "professionalGradeInfo": "CGC 8.5",
  "era": "Silver Age",
  "isKeyIssue": true,
  "keyIssueDescription": "First appearance of Spider-Man",
  "ownerId": 1,
  "collectorNotes": "From original collection"
}
```

#### Example: Get Available Comics

```http
GET https://localhost:7291/api/comics/available
```

#### Example: Search Comics by Era

```http
GET https://localhost:7291/api/comics/filter/era?era=Bronze%20Age
```

## Development Workflow

### Adding a New Database Table

1. Create model class in `Models/`
2. Add DbSet to `ComicBooksExchangeDbContext`
3. Create migration:
   ```bash
   dotnet ef migrations add YourMigrationName
   ```
4. Update database:
   ```bash
   dotnet ef database update
   ```

### Adding a New API Endpoint

1. Create service method in `Services/`
2. Add controller action in `Controllers/`
3. Add route and HTTP method decorators
4. Include error handling
5. Test with Swagger

### Adding a New Blazor Component

1. Create `.razor` file in appropriate folder
2. Add `@page` directive for pages
3. Use `@rendermode` for interactivity
4. Implement code-behind in `@code` block

## Configuration Options

### Application Settings

Edit `appsettings.json` to configure:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "..."
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning"
    }
  }
}
```

### CORS Configuration

Update `Program.cs` to modify CORS policy:

```csharp
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowClient", policy =>
    {
        policy.WithOrigins("https://localhost:7001", "http://localhost:5001")
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});
```

## Troubleshooting

### Database Connection Issues

**Error**: "Cannot connect to SQL Server"

**Solution**:
1. Verify SQL Server is running
2. Check connection string syntax
3. Ensure `TrustServerCertificate=true` for dev environments
4. Try `(localdb)\\mssqllocaldb` for LocalDB

### Migration Issues

**Error**: "Duplicate migration found"

**Solution**:
```bash
dotnet ef migrations remove
dotnet ef migrations add YourMigration
dotnet ef database update
```

### Port Already in Use

**Error**: "Address already in use"

**Solution**:
1. Change ports in `launchSettings.json`
2. Or kill process using the port:
   ```bash
   netstat -ano | findstr :7001
   taskkill /PID <PID> /F
   ```

### CORS Issues

**Error**: "CORS policy blocked the request"

**Solution**:
1. Verify API CORS is configured
2. Check Client URL matches AllowedOrigins
3. Use `WithOrigins()` instead of `AllowAnyOrigin()`

## Build & Deployment

### Development Build

```bash
dotnet build -c Debug
```

### Release Build

```bash
dotnet build -c Release
```

### Publish for Deployment

```bash
# API
dotnet publish ComicBooksExchangeAppAPI -c Release

# Blazor Server
dotnet publish A6-ComicBooksExchangeApp -c Release
```

## Docker Support (Future)

Dockerfile configuration will be added in Phase 2 for containerized deployment.

## Performance Optimization

### Database Optimization
- Indexes created on frequently searched columns
- Async queries prevent blocking
- Entity Framework lazy loading configured

### Application Optimization
- Blazor WebAssembly for client interactivity
- MudBlazor virtual scrolling for large lists
- Caching implemented in services

## Security Checklist

Before production deployment:

- [ ] Enable HTTPS only
- [ ] Implement ASP.NET Identity
- [ ] Add JWT authentication
- [ ] Enable rate limiting
- [ ] Implement input sanitization
- [ ] Use environment-specific settings
- [ ] Enable security headers
- [ ] Set up CORS properly
- [ ] Implement logging and monitoring
- [ ] Regular security audits

## Support & Resources

### Documentation
- [.NET 9 Docs](https://learn.microsoft.com/en-us/dotnet/)
- [Blazor Documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor/)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [MudBlazor](https://www.mudblazor.com/)

### Getting Help
- Review existing code patterns
- Check error logs in browser console
- Use VS Code debugging
- Review API responses in Swagger

---

**Last Updated**: 2024
