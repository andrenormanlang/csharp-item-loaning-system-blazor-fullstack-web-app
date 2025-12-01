# Comic Books Exchange Marketplace

A comprehensive full-stack .NET 9 Blazor application for comic book enthusiasts and collectors, specializing in the 45+ demographic. Built with Entity Framework Core, SQL Server, and MudBlazor UI framework.

## Project Overview

The Comic Books Exchange Marketplace is designed to connect mature comic book collectors, enabling secure trades of collectible comics with features specifically tailored to experienced collectors who value preservation, investment, and community trust.

## Architecture

### Projects

#### 1. **ComicBooksExchangeAppAPI** (ASP.NET Core Web API)
REST API backend managing all business logic, data persistence, and service layer.

**Key Components:**
- **Models**: Domain entities (Comic, User, Exchange, Transaction, Review)
- **Data**: Entity Framework Core DbContext and migrations
- **Repositories**: Generic and specialized repositories implementing the repository pattern
- **Services**: Business logic layer with async operations
- **Controllers**: RESTful API endpoints for Comics and Users
- **Validators**: Data validation and business rule enforcement
- **DTOs**: Data transfer objects for API communication

#### 2. **A6-ComicBooksExchangeApp** (Blazor Server Application)
Server-side rendering Blazor application providing the primary UI.

**Key Components:**
- **Components/Pages**: Full-page Razor components (Home, Comics, Profile)
- **Layout**: Navigation and layout components
- **Services**: Integration with API backend

#### 3. **A6-ComicBooksExchangeApp.Client** (Blazor WebAssembly)
Client-side interactive components for enhanced UX.

**Key Components:**
- **SearchFilterComponent**: Advanced search with autocomplete
- **ComicCard**: Interactive comic display component
- **ExchangeOfferDialog**: Form for proposing trades

## Database Schema

### Tables

- **Users**: Collector profiles with ratings and verification status
- **Comics**: Comic book listings with condition grades and valuations
- **Exchanges**: Trade proposals between collectors
- **Transactions**: Completed exchange records with shipping details
- **Reviews**: Ratings and feedback after exchanges

### Key Features

- **Composite Foreign Keys**: Relationships between all entities
- **Indexes**: Optimized queries on frequently searched fields (Username, Email)
- **Data Integrity**: Cascading deletes and referential constraints

## API Endpoints

### Comics
- `GET /api/comics/available` - Get available comics
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

## Validation & Business Rules

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

## Security Considerations

- ✅ API communication via HTTPS
- ✅ Input validation on all endpoints
- ✅ CORS configured for WebAssembly client
- ✅ Database migrations managed through EF Core
- ✅ Null-safe programming with nullable annotations

## Target Demographics

**45+ Comic Book Enthusiast & Collector**

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

## Future Enhancements

- [ ] User authentication and authorization
- [ ] Message/chat system for collectors
- [ ] Advanced matching algorithm
- [ ] Payment integration for additional value trades
- [ ] Dispute resolution system
- [ ] Mobile app with Blazor Hybrid
- [ ] Advanced analytics and statistics
- [ ] Comic price guide integration
- [ ] Wishlist and alerts system
- [ ] Social features (following, collections)

## Contributing

This is an educational project. Contributions following the code guidelines above are welcome.

## License

Educational use only.
