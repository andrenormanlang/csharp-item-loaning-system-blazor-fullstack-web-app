# Comic Books Lending Library

A comprehensive full-stack .NET 9 Blazor application for comic book readers, specializing in the 45+ demographic. Built with Entity Framework Core, SQL Server, and MudBlazor UI framework.

## Project Overview

The Comic Books Lending Library is designed to connect mature comic book collectors, enabling free comic book loans between collectors. Users can borrow comics from each other for a specified period, with the requirement that they offer one of their own comics in return. This creates a mutual lending system where both parties benefit.

### Key Concept: Mutual Lending

- **Borrow a comic, lend a comic**: To borrow someone's comic, you must offer one of yours in return
- **Timed loans**: Comics are loaned for a specific period (7-90 days)
- **Unavailable while on loan**: Comics that are currently loaned out cannot be borrowed by others
- **Mutual responsibility**: Both parties are responsible for returning comics in the same condition

## Architecture

### Projects

#### 1. ComicBooksExchangeAppAPI (ASP.NET Core Web API)

REST API backend managing all business logic, data persistence, and service layer.

**Key Components:**

- **Models**: Domain entities (Comic, User, LoanRequest, Loan, Exchange, Transaction, Review)
- **Data**: Entity Framework Core DbContext and migrations
- **Repositories**: Generic and specialized repositories implementing the repository pattern
- **Services**: Business logic layer with async operations
- **Controllers**: RESTful API endpoints for Comics, Users, and Loans
- **Validators**: Data validation and business rule enforcement
- **DTOs**: Data transfer objects for API communication

#### 2. A6-ComicBooksExchangeApp (Blazor Server Application)

Server-side rendering Blazor application providing the primary UI.

**Key Components:**

- **Components/Pages**: Full-page Razor components (Home, Comics, Loans, Profile)
- **Layout**: Navigation and layout components
- **Services**: Integration with API backend

#### 3. A6-ComicBooksExchangeApp.Client (Blazor WebAssembly)

Client-side interactive components for enhanced UX.

**Key Components:**

- **SearchFilterComponent**: Advanced search with autocomplete
- **ComicCard**: Interactive comic display component
- **LoanRequestDialog**: Form for requesting comic loans

## Database Schema

### Tables

- **Users**: Collector profiles with ratings and verification status
- **Comics**: Comic book listings with condition grades, valuations, and loan status
- **LoanRequests**: Loan proposals between collectors
- **Loans**: Active and completed loan records
- **Reviews**: Ratings and feedback after loans/exchanges

### Loan System Fields

Comics now include:

- `IsOnLoan`: Whether the comic is currently loaned out
- `CurrentLoanId`: Reference to the active loan
- `LoanReturnDate`: Expected return date when on loan

### Key Features

- **Composite Foreign Keys**: Relationships between all entities
- **Indexes**: Optimized queries on frequently searched fields (Username, Email)
- **Data Integrity**: Cascading deletes and referential constraints

## API Endpoints

### Comics

- `GET /api/comics/available` - Get available comics (not on loan)
- `GET /api/comics/{id}` - Get comic details
- `GET /api/comics/user/{userId}` - Get user's collection
- `POST /api/comics` - Add new comic
- `PUT /api/comics/{id}` - Update comic
- `DELETE /api/comics/{id}` - Remove comic
- `GET /api/comics/search/title?searchTerm=...` - Search by title
- `GET /api/comics/filter/era?era=...` - Filter by era
- `GET /api/comics/filter/condition?grade=...` - Filter by condition
- `GET /api/comics/filter/keyissues` - Get key issues
- `GET /api/comics/filter/graded` - Get professionally graded
- `GET /api/comics/search/character?character=...` - Search by character
- `GET /api/comics/filter/publisher?publisher=...` - Filter by publisher

### Users

- `GET /api/users` - Get all users
- `GET /api/users/{id}` - Get user profile
- `GET /api/users/username/{username}` - Get by username
- `POST /api/users/register` - Register new user
- `PUT /api/users/{id}` - Update profile
- `GET /api/users/filter/verified` - Get verified collectors
- `GET /api/users/filter/toprated?count=10` - Get top-rated collectors
- `GET /api/users/filter/mostactive` - Get most active collectors
- `GET /api/users/filter/location?location=...` - Find by location
- `GET /api/users/filter/focus?focus=...` - Filter by collecting focus
- `POST /api/users/{id}/exchanges/increment` - Update exchange count
- `POST /api/users/{id}/rating/update` - Update rating

## Key Technologies

- **.NET 9** - Latest .NET framework
- **Blazor** - Full-stack C# for UI
- **Entity Framework Core 9** - ORM for data access
- **SQL Server** - Relational database
- **MudBlazor** - Material Design component library
- **Repository Pattern** - Data access abstraction
- **Async/Await** - Asynchronous programming
- **LINQ** - Language-integrated queries

## Validation and Business Rules

### Comic Validation

- Condition grades: Mint, Near Mint, Very Fine, Fine, Very Good, Good, Fair, Poor
- Eras: Golden Age, Silver Age, Bronze Age, Modern Age, Contemporary
- Estimated value must be non-negative
- Title and publisher are required

### User Validation

- Username: 3-50 characters, alphanumeric with hyphens/underscores
- Email: Standard email validation
- Collecting focus required
- Phone number optional but validates if provided

### Exchange Validation

- Statuses: Pending, Accepted, Shipped, Completed, Cancelled, Disputed
- Transaction tracking with reference numbers
- Condition verification on receipt

### Loan Request Validation

- Statuses: Pending, Accepted, Declined, Cancelled, Expired
- Loan duration: 7-90 days
- Must offer a comic in return

### Loan Validation

- Statuses: Active, Returned, Overdue, Cancelled
- Both comics tracked during loan period
- Return tracking with confirmation

## Security Considerations

- API communication via HTTPS
- Input validation on all endpoints
- CORS configured for WebAssembly client
- Database migrations managed through EF Core
- Null-safe programming with nullable annotations

## Target Demographics

### 45+ Comic Book Readers

- **Nostalgia-Driven**: Bronze/Silver Age specialists
- **Investment-Focused**: CGC/CBCS graded collections
- **Completists**: Seeking specific comic runs
- **Content Readers**: Appreciation for sophisticated storytelling
- **Back-Issue Hunters**: Filling collection gaps
- **Lapsed Collectors**: Returning to the hobby

## Development Guidelines

### Code Organization

- Namespace hierarchy follows project structure
- Models in `/Models`
- Data layer in `/Data`
- Repositories in `/Repositories`
- Services in `/Services`
- Controllers in `/Controllers`
- Validators in `/Validators`
- DTOs in `/Models/DTOs`

### XML Documentation

- All public classes and methods documented with `///` comments
- Include parameter descriptions
- Provide return value documentation
- Note exceptions where applicable

### Async Operations

- All I/O operations use async/await
- Service methods return `Task` or `Task<T>`
- Repository methods support async queries

### Error Handling

- Try-catch blocks in service layer
- Meaningful validation messages
- HTTP status codes align with REST conventions
- Logging available for debugging

## Getting Started

1. **Setup Database**
   - Update connection string in `appsettings.json` or `Program.cs`
   - Run migrations: `dotnet ef database update`

2. **Run API**
   - Navigate to `ComicBooksExchangeAppAPI`
   - `dotnet run`
   - API available at `https://localhost:7291`

3. **Run Blazor App**
   - Start both server and client projects
   - Navigate to `https://localhost:7001`

## Docker (Production-faithful Local Dev)

This repo includes Docker files for both the API and the Blazor Server app, plus a local MySQL container so your local environment matches production.

- API Dockerfile: `ComicBooksLoanAppAPI/Dockerfile`
- Web (Blazor Server) Dockerfile: `A6-ComicBooksLoanApp/Dockerfile`
- Local stack (MySQL + API + Web): `docker-compose.yml`

### Run locally with MySQL

From the repo root:

- Build + run: `docker compose up --build`
- App: `http://localhost:5144`
- API: `http://localhost:5259`

Notes:

- Local DB credentials in `docker-compose.yml` are for local-only.
- The API is configured with `Database__Provider=MySql` and uses `EnsureCreated()` for MySQL startup.

## Deploy to Render.com (Docker)

You will typically deploy **two Render Web Services**:

1) **API service** (Dockerfile: `ComicBooksLoanAppAPI/Dockerfile`)
2) **Web service** (Dockerfile: `A6-ComicBooksLoanApp/Dockerfile`)

### Render: API service environment variables

Set these in the Render dashboard (do NOT commit secrets):

- `ASPNETCORE_ENVIRONMENT` = `Production`
- `Database__Provider` = `MySql`
- `ConnectionStrings__DefaultConnection` = `Server=<host>;Port=<port>;Database=defaultdb;User=<user>;Password=<password>;SslMode=Required;`
- `Cors__AllowedOrigins__0` = `https://<your-web-service>.onrender.com`

For your deployed services:

- `Cors__AllowedOrigins__0` = `https://comics-loan-app.onrender.com`

### Render: Web service environment variables

- `ASPNETCORE_ENVIRONMENT` = `Production`
- `ApiBaseUrl` = `https://<your-api-service>.onrender.com`

For your deployed services:

- `ApiBaseUrl` = `https://comics-loan-api.onrender.com`

### Aiven MySQL connection string

Render expects you to put this into `ConnectionStrings__DefaultConnection` (API service):

- Host: `mysql-3ed4a6c-andrenormanlang-7af0.g.aivencloud.com`
- Port: `28197`
- Database: `defaultdb`
- User: `avnadmin`
- SSL: required (`SslMode=Required`)

Security:

- If you pasted your DB password into chat or any public place, rotate it in Aiven.

## Future Enhancements



## Contributing

This is an educational project. Contributions following the code guidelines above are welcome.

## License

Educational use only.
