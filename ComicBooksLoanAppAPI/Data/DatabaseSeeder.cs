using ComicBooksLoanAppAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;
using static System.Net.WebRequestMethods;

namespace ComicBooksLoanAppAPI.Data
{
    /// <summary>
    /// Database seed data for the Comic Books Lending Library.
    /// Curated for the 45+ comic book reader demographic:
    /// - Nostalgia-driven readers (Bronze Age 1970-1985)
    /// - Completists seeking classic runs
    /// - Mature content readers (Vertigo, Epic, etc.)
    /// - Lapsed collectors returning to the hobby
    /// </summary>
    public static class DatabaseSeeder
    {
        /// <summary>
        /// Seeds the database with initial data at runtime if the database is currently empty.
        /// This is intended for first-run/dev scenarios where no migrations-based seeding is present.
        /// </summary>
        public static async Task SeedDatabaseIfEmptyAsync(comicbooksloanDbContext context, ILogger? logger = null, CancellationToken cancellationToken = default)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            // If we retry (or if a previous attempt partially tracked entities), ensure a clean state.
            context.ChangeTracker.Clear();

            // Treat "no users" as "empty database" for this app.
            if (await context.Users.AsNoTracking().AnyAsync(cancellationToken))
            {
                return;
            }

            logger?.LogInformation("Database is empty; seeding initial data...");

            // Build seed data using the same curated dataset used for model seeding.
            var users = GetSampleUsers();
            var comics = GetSampleComics();

            var pastLoans = GetPastLoans();
            var futureLoans = GetOngoingLoans(pastLoans.Count + 1);

            foreach (var loan in futureLoans)
            {
                if (loan.Status == "Active" || loan.Status == "Overdue")
                {
                    var comic = comics.FirstOrDefault(c => c.Id == loan.ComicId);
                    if (comic != null)
                    {
                        comic.IsAvailable = false;
                        comic.IsOnLoan = true;
                        comic.CurrentLoanId = loan.Id;
                        comic.LoanReturnDate = loan.LoanEndDate;
                    }
                }
            }

            var reviews = GetReviews();
            var messages = GetSeedMessages();
            var announcements = GetSeedAnnouncements();

            // Insert in FK-safe order.
            // Note: Seed data uses explicit integer Id values.
            // For providers with retrying execution strategies (e.g., Npgsql), you must run the whole transaction
            // via DbContext.Database.CreateExecutionStrategy().
            var strategy = context.Database.CreateExecutionStrategy();

            await strategy.ExecuteAsync(async () =>
            {
                // Ensure idempotency within an execution-strategy retry: if a previous attempt partially succeeded,
                // skip further seeding.
                context.ChangeTracker.Clear();
                if (await context.Users.AsNoTracking().AnyAsync(cancellationToken))
                {
                    return;
                }

                await using var transaction = await context.Database.BeginTransactionAsync(cancellationToken);
                try
                {
                    await AddRangeWithIdentityInsertAsync(context, users, logger, cancellationToken);
                    await AddRangeWithIdentityInsertAsync(context, comics, logger, cancellationToken);
                    await AddRangeWithIdentityInsertAsync(context, pastLoans, logger, cancellationToken);
                    await AddRangeWithIdentityInsertAsync(context, futureLoans, logger, cancellationToken);
                    await AddRangeWithIdentityInsertAsync(context, reviews, logger, cancellationToken);
                    await AddRangeWithIdentityInsertAsync(context, messages, logger, cancellationToken);
                    await AddRangeWithIdentityInsertAsync(context, announcements, logger, cancellationToken);

                    await transaction.CommitAsync(cancellationToken);
                    logger?.LogInformation("Database seeding completed.");
                }
                catch (Exception ex)
                {
                    logger?.LogError(ex, "Database seeding failed; rolling back.");
                    await transaction.RollbackAsync(cancellationToken);
                    throw;
                }
            });
        }

        private static async Task AddRangeWithIdentityInsertAsync<TEntity>(
            comicbooksloanDbContext context,
            IReadOnlyCollection<TEntity> entities,
            ILogger? logger,
            CancellationToken cancellationToken) where TEntity : class
        {
            if (entities == null || entities.Count == 0)
            {
                return;
            }

            // PostgreSQL (timestamptz) requires UTC DateTimes.
            // Our curated seed dataset uses many `new DateTime(y, m, d)` literals (Kind=Unspecified),
            // so normalize all DateTime properties to UTC before inserting.
            NormalizeDateTimesToUtc(entities);

            // MySQL does not support SQL Server's IDENTITY_INSERT or [dbo] schema syntax.
            // PostgreSQL also does not support IDENTITY_INSERT; inserting explicit values is allowed for GENERATED BY DEFAULT columns.
            // If the migration used GENERATED ALWAYS, explicit values would require OVERRIDING SYSTEM VALUE.
            // For now, seed using normal EF inserts for non-SQLServer providers.
            if (!IsSqlServerProvider(context))
            {
                logger?.LogDebug("Seeding {Entity} (count={Count}) using provider {Provider}", typeof(TEntity).Name, entities.Count, context.Database.ProviderName);
                context.Set<TEntity>().AddRange(entities);
                await context.SaveChangesAsync(cancellationToken);
                context.ChangeTracker.Clear();
                return;
            }

            var entityType = context.Model.FindEntityType(typeof(TEntity));
            if (entityType == null)
            {
                throw new InvalidOperationException($"Unable to resolve EF model metadata for entity type '{typeof(TEntity).Name}'.");
            }

            var tableName = entityType.GetTableName();
            if (string.IsNullOrWhiteSpace(tableName))
            {
                throw new InvalidOperationException($"Unable to resolve table name for entity type '{typeof(TEntity).Name}'.");
            }

            var schema = entityType.GetSchema() ?? "dbo";
            var fullTableName = $"[{schema}].[{tableName}]";

            // SQL Server allows IDENTITY_INSERT ON for only one table at a time per session.
            logger?.LogDebug("Seeding {Entity} into {Table} (count={Count})", typeof(TEntity).Name, fullTableName, entities.Count);

            var identityInsertOnSql = "SET IDENTITY_INSERT " + fullTableName + " ON";
            await context.Database.ExecuteSqlRawAsync(identityInsertOnSql, cancellationToken);
            try
            {
                context.Set<TEntity>().AddRange(entities);
                await context.SaveChangesAsync(cancellationToken);
            }
            finally
            {
                var identityInsertOffSql = "SET IDENTITY_INSERT " + fullTableName + " OFF";
                await context.Database.ExecuteSqlRawAsync(identityInsertOffSql, cancellationToken);
                context.ChangeTracker.Clear();
            }
        }

        private static void NormalizeDateTimesToUtc<TEntity>(IReadOnlyCollection<TEntity> entities) where TEntity : class
        {
            foreach (var entity in entities)
            {
                if (entity == null) continue;

                var properties = entity.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
                foreach (var property in properties)
                {
                    if (!property.CanRead || !property.CanWrite) continue;
                    if (property.GetIndexParameters().Length != 0) continue;

                    if (property.PropertyType == typeof(DateTime))
                    {
                        var value = (DateTime)property.GetValue(entity)!;
                        property.SetValue(entity, NormalizeUtc(value));
                    }
                    else if (property.PropertyType == typeof(DateTime?))
                    {
                        var value = (DateTime?)property.GetValue(entity);
                        if (value.HasValue)
                        {
                            property.SetValue(entity, (DateTime?)NormalizeUtc(value.Value));
                        }
                    }
                }
            }
        }

        private static DateTime NormalizeUtc(DateTime value)
        {
            // Npgsql rejects Unspecified for timestamptz. For our seed data, treat Unspecified as UTC.
            // Convert Local to UTC to keep the instant in time consistent.
            return value.Kind switch
            {
                DateTimeKind.Utc => value,
                DateTimeKind.Local => value.ToUniversalTime(),
                _ => DateTime.SpecifyKind(value, DateTimeKind.Utc)
            };
        }

        private static bool IsMySqlProvider(DbContext context)
        {
            var providerName = context.Database.ProviderName;
            return providerName != null && providerName.Contains("MySql", StringComparison.OrdinalIgnoreCase);
        }

        private static bool IsSqlServerProvider(DbContext context)
        {
            var providerName = context.Database.ProviderName;
            return providerName != null && providerName.Contains("SqlServer", StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Seeds the database with initial data.
        /// </summary>
        public static void SeedDatabase(ModelBuilder modelBuilder)
        {
            // Seed Users
            var users = GetSampleUsers();
            modelBuilder.Entity<User>().HasData(users);

            // Build comics list first (we will modify it after generating ongoing loans)
            var comics = GetSampleComics();

            // Seed Past Loans (Completed)
            var pastLoans = GetPastLoans();
            modelBuilder.Entity<Loan>().HasData(pastLoans);

            // Seed Ongoing Loans (Active) - start after past loans
            var futureLoans = GetOngoingLoans(pastLoans.Count + 1);
            modelBuilder.Entity<Loan>().HasData(futureLoans);

            // Link comics to ongoing loans before seeding comics
            foreach (var loan in futureLoans)
            {
                if (loan.Status == "Active" || loan.Status == "Overdue")
                {
                    var comic = comics.FirstOrDefault(c => c.Id == loan.ComicId);
                    if (comic != null)
                    {
                        comic.IsAvailable = false;
                        comic.IsOnLoan = true;
                        comic.CurrentLoanId = loan.Id;
                        comic.LoanReturnDate = loan.LoanEndDate;
                    }
                }
            }

            // Now seed comics (with any loan linkage applied)
            modelBuilder.Entity<Comic>().HasData(comics);

            // Seed Reviews
            var reviews = GetReviews();
            modelBuilder.Entity<Review>().HasData(reviews);

            // Seed Messages (a couple between members, some read/unread)
            var messages = GetSeedMessages();
            modelBuilder.Entity<Message>().HasData(messages);

            // Seed Announcements (platform news and updates)
            var announcements = GetSeedAnnouncements();
            modelBuilder.Entity<Announcement>().HasData(announcements);
        }

        private static List<User> GetSampleUsers()
        {
            var list = new List<User>
            {
                new User
                {
                    Id = 1,
                    Username = "bronze_age_bob",
                    FullName = "Robert Mitchell",
                    Email = "robert@example.com",
                    City = "Malmö",
                    ZipCode = "211 20",
                    ReadingFocus = "Bronze Age Marvel, Classic Superhero Comics",
                    Description = "Bronze Age enthusiast with focus on Spider-Man and X-Men runs from the 1970s-1980s",
                    FavoriteCharacters = "Spider-Man, X-Men, Teen Titans, Swamp Thing",
                    Biography = "Living in Malmö since 2018. Started reading comics in 1975. Took a break in the 90s and just getting back into it. Love sharing the classics I grew up with through this lending library. Happy to meet up anywhere in central Malmö!",
                    SuccessfulLoans = 24,
                    AverageRating = 4.9m,
                    MemberSince = new DateTime(2023, 3, 15),
                    IsVerified = true,
                    ImageUrl = "https://i.pravatar.cc/150?img=12",
                    PasswordHash = HashPassword("Comics123!")
                },
                new User
                {
                    Id = 2,
                    Username = "vertigo_veteran",
                    FullName = "Diana Chen",
                    Email = "diana@example.com",
                    City = "Lund",
                    ZipCode = "222 20",
                    ReadingFocus = "Mature Comics, Vertigo Line, Horror",
                    Description = "Collector of mature literary comics, especially the Vertigo imprint and horror titles",
                    FavoriteCharacters = "Sandman, Swamp Thing, Hellblazer, Preacher",
                    Biography = "Former bookstore owner living in Lund. Passionate about mature, literary comics. The Vertigo line changed everything for me. Living near the university. Can meet in Lund or Malmö.",
                    SuccessfulLoans = 18,
                    AverageRating = 5.0m,
                    MemberSince = new DateTime(2023, 6, 22),
                    IsVerified = true,
                    ImageUrl = "https://i.pravatar.cc/150?img=47",
                    PasswordHash = HashPassword("Comics123!")
                },
                new User
                {
                    Id = 3,
                    Username = "xmen_completist",
                    FullName = "Marcus Williams",
                    Email = "marcus@example.com",
                    City = "Helsingborg",
                    ZipCode = "252 20",
                    ReadingFocus = "X-Men Complete Runs, Marvel Bronze Age",
                    Description = "Complete X-Men collector from Giant-Size #1 through the 1990s, specializing in Claremont era",
                    FavoriteCharacters = "X-Men, Wolverine, Storm, Nightcrawler",
                    Biography = "Living in Helsingborg. Have been collecting X-Men since Claremont took over. Own nearly every issue from Giant-Size #1 through the 90s. Happy to share the classics! Usually available for meetups in Helsingborg centrum.",
                    SuccessfulLoans = 42,
                    AverageRating = 4.8m,
                    MemberSince = new DateTime(2022, 11, 10),
                    IsVerified = true,
                    ImageUrl = "https://i.pravatar.cc/150?img=33",
                    PasswordHash = HashPassword("Comics123!")
                },
                new User
                {
                    Id = 4,
                    Username = "classic_dc_dan",
                    FullName = "Daniel Torres",
                    Email = "daniel@example.com",
                    City = "Malmö",
                    ZipCode = "214 44",
                    ReadingFocus = "Classic DC, Bronze Age Batman, Social Commentary Comics",
                    Description = "Classic DC collector focusing on O'Neil/Adams Batman and socially conscious 70s-80s DC titles",
                    FavoriteCharacters = "Batman, Green Lantern, Green Arrow, Teen Titans",
                    Biography = "Been in Malmö for 10 years. Grew up on O'Neil/Adams Batman and the classic Teen Titans. Still think the 70s-80s were the golden era of DC storytelling. Live in Västra Hamnen, happy to meet anywhere in Malmö.",
                    SuccessfulLoans = 31,
                    AverageRating = 4.9m,
                    MemberSince = new DateTime(2023, 1, 5),
                    IsVerified = true,
                    ImageUrl = "https://i.pravatar.cc/150?img=15",
                    PasswordHash = HashPassword("Comics123!")
                },
                new User
                {
                    Id = 5,
                    Username = "indie_origins",
                    FullName = "Sarah McKenzie",
                    Email = "sarah@example.com",
                    City = "Lund",
                    ZipCode = "223 63",
                    ReadingFocus = "Independent Comics, Underground Comics, Alternative",
                    Description = "Independent and underground comics specialist with extensive runs of 1970s-80s indie titles",
                    FavoriteCharacters = "Cerebus, TMNT, Elfquest, American Flagg",
                    Biography = "Living in Lund. Was there when the indie revolution started. Own runs of many titles that launched careers. Love sharing these overlooked gems. Living near Lund C, easy to meet up!",
                    SuccessfulLoans = 15,
                    AverageRating = 4.7m,
                    MemberSince = new DateTime(2023, 8, 20),
                    IsVerified = true,
                    ImageUrl = "https://i.pravatar.cc/150?img=29",
                    PasswordHash = HashPassword("Comics123!")
                },
                new User
                {
                    Id = 6,
                    Username = "horror_comics_hank",
                    FullName = "Henry Patterson",
                    Email = "henry@example.com",
                    City = "Malmö",
                    ZipCode = "215 73",
                    ReadingFocus = "Horror Comics, Classic Monster Comics, Dark Fantasy",
                    Description = "Horror comics enthusiast with extensive collections of 1970s Marvel and DC horror titles",
                    FavoriteCharacters = "Swamp Thing, Man-Thing, Ghost Rider, Tomb of Dracula",
                    Biography = "Born and raised in Malmö. Been reading horror comics since the 70s revival. Have extensive runs of Tomb of Dracula, Swamp Thing, and more. Love introducing people to classic horror comics. Can meet in Möllevången or Värnhem areas.",
                    SuccessfulLoans = 22,
                    AverageRating = 4.8m,
                    MemberSince = new DateTime(2023, 4, 12),
                    IsVerified = true,
                    ImageUrl = "https://i.pravatar.cc/150?img=51",
                    PasswordHash = HashPassword("Comics123!")
                },
                new User
                {
                    Id = 7,
                    Username = "alt_manga_maven",
                    FullName = "Sofia Bergström",
                    Email = "sofia.b@example.com",
                    City = "Malmö",
                    ZipCode = "211 25",
                    ReadingFocus = "Alternative Manga, Gekiga, Experimental Japanese Comics",
                    Description = "Collector of obscure and alternative manga from the 60s-90s. Specializing in gekiga and avant-garde works.",
                    FavoriteCharacters = "Onoda (Red Snow), Tatsumi's protagonists, Tsuge's wanderers",
                    Biography = "Swedish manga enthusiast fascinated by Japan's alternative comics scene. Spent years hunting down rare gekiga and experimental works that never got mainstream attention. Prefer gritty, artistic manga over shonen. Happy to meet anywhere in Malmö city center or Limhamn.",
                    SuccessfulLoans = 18,
                    AverageRating = 4.9m,
                    MemberSince = new DateTime(2023, 8, 5),
                    IsVerified = true,
                    ImageUrl = "https://i.pravatar.cc/150?img=32",
                    PasswordHash = HashPassword("Manga456!")
                }
            };

            // Set approval defaults for seeded users
            foreach (var u in list)
            {
                u.ApprovalStatus = ApprovalStatus.Approved;
                u.Role = "User";
            }

            // Seed an admin moderator account
            list.Add(new User
            {
                Id = 1000,
                Username = "admin",
                FullName = "Admin Moderator",
                Email = "admin@example.com",
                City = "Malmö",
                ZipCode = "211 20",
                ReadingFocus = "Moderation",
                Description = "Administrator account for approving users and comics",
                FavoriteCharacters = "",
                Biography = "",
                SuccessfulLoans = 0,
                AverageRating = 0m,
                MemberSince = new DateTime(2023, 1, 1),
                IsVerified = true,
                ImageUrl = null,
                PasswordHash = HashPassword("Admin123!"),
                ApprovalStatus = ApprovalStatus.Approved,
                Role = "Admin"
            });

            return list;
        }

        private static List<Comic> GetSampleComics()
        {
            var list = new List<Comic>
            {
                // ========================================
                // BRONZE AGE MARVEL - Bob's Collection
                // ========================================
                new Comic
                {
                    Id = 1,
                    Title = "The Amazing Spider-Man",
                    IssueNumber = 129,
                    PublicationDate = new DateTime(1974, 2, 1),
                    Publisher = "Marvel",
                    Characters = "Spider-Man, Punisher, Jackal",
                    Era = "Bronze Age",
                    Genre = "Superhero",
                    ConditionGrade = "Very Fine",
                    ConditionDescription = "Slight spine stress, bright colors. Classic issue.",
                    Description = "First appearance of the Punisher. One of the most significant Bronze Age issues.",
                    OwnerId = 1,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 15, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Handle with care - this is a key issue.",
                    CoverImageUrl = "https://cdn.marvel.com/u/prod/marvel/i/mg/e/b0/57b7694649690/clean.jpg"
                },
                new Comic
                {
                    Id = 2,
                    Title = "The Amazing Spider-Man",
                    IssueNumber = 121,
                    PublicationDate = new DateTime(1973, 6, 1),
                    Publisher = "Marvel",
                    Characters = "Spider-Man, Green Goblin, Gwen Stacy",
                    Era = "Bronze Age",
                    Genre = "Superhero",
                    ConditionGrade = "Fine",
                    ConditionDescription = "Minor wear, complete story. Historic issue.",
                    Description = "The Night Gwen Stacy Died. The comic that changed everything about superhero storytelling.",
                    OwnerId = 1,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 10, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "One of the most important comics ever published. Read with tissues.",
                    CoverImageUrl = "https://cdn.marvel.com/u/prod/marvel/i/mg/a/00/57b71f662fdc8/clean.jpg"
                },
                new Comic
                {
                    Id = 3,
                    Title = "Incredible Hulk",
                    IssueNumber = 181,
                    PublicationDate = new DateTime(1974, 11, 1),
                    Publisher = "Marvel",
                    Characters = "Hulk, Wolverine, Wendigo",
                    Era = "Bronze Age",
                    Genre = "Superhero",
                    ConditionGrade = "Very Good",
                    ConditionDescription = "Some spine wear, complete with MVS stamp.",
                    Description = "First full appearance of Wolverine. The Bronze Age key issue.",
                    OwnerId = 1,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 8, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "The book that launched Wolverine! MVS intact.",
                    CoverImageUrl = "https://cdn.marvel.com/u/prod/marvel/i/mg/9/d0/5c93f5a6e62b7/clean.jpg"
                },
                new Comic
                {
                    Id = 4,
                    Title = "Giant-Size X-Men",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1975, 5, 1),
                    Publisher = "Marvel",
                    Characters = "X-Men, Storm, Wolverine, Colossus, Nightcrawler",
                    Era = "Bronze Age",
                    Genre = "Superhero",
                    ConditionGrade = "Fine",
                    ConditionDescription = "Tight binding, vibrant cover. Small corner crease.",
                    Description = "The relaunch that made X-Men the biggest franchise in comics. Introduces Storm, Colossus, Nightcrawler, and more.",
                    OwnerId = 1,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 5, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Start of the Claremont era. Essential reading.",
                    CoverImageUrl = "https://m.media-amazon.com/images/I/81WxtKOsJrL._AC_UF894,1000_QL80_.jpg"
                },

                // ========================================
                // VERTIGO/MATURE - Diana's Collection
                // ========================================
                new Comic
                {
                    Id = 5,
                    Title = "Sandman",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1989, 1, 1),
                    Publisher = "DC/Vertigo",
                    Characters = "Morpheus, Dream, Cain, Abel",
                    Era = "Modern Age",
                    Genre = "Fantasy/Horror",
                    ConditionGrade = "Near Mint",
                    ConditionDescription = "Excellent condition, stored properly since purchase.",
                    Description = "Neil Gaiman's masterpiece begins. The comic that proved comics could be literature.",
                    OwnerId = 2,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Start of the greatest comic series ever written. Mature readers.",
                    CoverImageUrl = "https://static.dc.com/dc/files/default_images/sandman_1_5bdcac3465cb99.69674278.jpg?w=640"
                },
                new Comic
                {
                    Id = 6,
                    Title = "Saga of the Swamp Thing",
                    IssueNumber = 21,
                    PublicationDate = new DateTime(1984, 2, 1),
                    Publisher = "DC",
                    Characters = "Swamp Thing, Abby Cable",
                    Era = "Copper Age",
                    Genre = "Horror",
                    ConditionGrade = "Very Fine",
                    ConditionDescription = "Alan Moore's first issue. Excellent condition.",
                    Description = "The Anatomy Lesson. Alan Moore reimagines Swamp Thing in this legendary issue that changed horror comics.",
                    OwnerId = 2,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 18, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Moore's first issue. One of the most important comics of the 80s.",
                    CoverImageUrl = "https://imgix-media.wbdndc.net/ingest/book/preview/38880d58-1b51-4aca-9e18-80337ef0a9f8/62d92087-bb30-4f40-bf53-cbedfbc52db9/0.jpg"
                },
                new Comic
                {
                    Id = 7,
                    Title = "Hellblazer",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1988, 1, 1),
                    Publisher = "DC/Vertigo",
                    Characters = "John Constantine",
                    Era = "Modern Age",
                    Genre = "Horror/Urban Fantasy",
                    ConditionGrade = "Fine",
                    ConditionDescription = "Good reading copy. Some minor wear.",
                    Description = "John Constantine gets his own series. Working-class horror meets social commentary.",
                    OwnerId = 2,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 16, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Constantine at his best. Mature content throughout the series.",
                    CoverImageUrl = "https://m.media-amazon.com/images/I/716ZMMCUw7L._AC_UF1000,1000_QL80_.jpg"
                },
                new Comic
                {
                    Id = 8,
                    Title = "Preacher",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1995, 4, 1),
                    Publisher = "DC/Vertigo",
                    Characters = "Jesse Custer, Tulip O'Hare, Cassidy",
                    Era = "Modern Age",
                    Genre = "Action/Dark Comedy",
                    ConditionGrade = "Very Fine",
                    ConditionDescription = "Well-preserved, bright white pages.",
                    Description = "Garth Ennis and Steve Dillon's controversial masterpiece begins. A Texas preacher gains the power of God.",
                    OwnerId = 2,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 14, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "WARNING: Extremely mature content. Not for the easily offended.",
                    CoverImageUrl = "https://static.wikia.nocookie.net/marvel_dc/images/8/82/Preacher_01b.jpg"
                },

                // ========================================
                // X-MEN RUNS - Marcus's Collection
                // ========================================
                new Comic
                {
                    Id = 9,
                    Title = "Uncanny X-Men",
                    IssueNumber = 94,
                    PublicationDate = new DateTime(1975, 8, 1),
                    Publisher = "Marvel",
                    Characters = "X-Men, Thunderbird, Count Nefaria",
                    Era = "Bronze Age",
                    Genre = "Superhero",
                    ConditionGrade = "Fine",
                    ConditionDescription = "Solid copy. Death of Thunderbird story.",
                    Description = "The new X-Men's first regular issue. Death of Thunderbird. Claremont's run truly begins.",
                    OwnerId = 3,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 22, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "First issue of the regular series with new team.",
                    CoverImageUrl = "https://cdn.marvel.com/u/prod/marvel/i/mg/3/50/58a60168b290d/clean.jpg"
                },
                new Comic
                {
                    Id = 10,
                    Title = "Uncanny X-Men",
                    IssueNumber = 129,
                    PublicationDate = new DateTime(1980, 1, 1),
                    Publisher = "Marvel",
                    Characters = "X-Men, Kitty Pryde, Emma Frost",
                    Era = "Bronze Age",
                    Genre = "Superhero",
                    ConditionGrade = "Very Fine",
                    ConditionDescription = "First Kitty Pryde! Excellent condition.",
                    Description = "First appearance of Kitty Pryde and Emma Frost. The Dark Phoenix Saga begins.",
                    OwnerId = 3,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 21, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Essential issue. Beginning of the greatest X-Men story ever.",
                    CoverImageUrl = "https://cdn.marvel.com/u/prod/marvel/i/mg/3/e0/519b7f491722f/clean.jpg"
                },
                new Comic
                {
                    Id = 11,
                    Title = "Uncanny X-Men",
                    IssueNumber = 137,
                    PublicationDate = new DateTime(1980, 9, 1),
                    Publisher = "Marvel",
                    Characters = "X-Men, Phoenix, Imperial Guard",
                    Era = "Bronze Age",
                    Genre = "Superhero",
                    ConditionGrade = "Fine",
                    ConditionDescription = "Complete. Dark Phoenix finale. Some spine wear.",
                    Description = "The death of Phoenix. One of the most emotional issues in comics history.",
                    OwnerId = 3,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 19, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Bring tissues. Still gets me after all these years.",
                    CoverImageUrl = "https://cdn.marvel.com/u/prod/marvel/i/mg/6/80/5372a8d26e25e/clean.jpg"
                },
                new Comic
                {
                    Id = 12,
                    Title = "Uncanny X-Men",
                    IssueNumber = 141,
                    PublicationDate = new DateTime(1981, 1, 1),
                    Publisher = "Marvel",
                    Characters = "X-Men, Future Wolverine, Sentinels",
                    Era = "Bronze Age",
                    Genre = "Superhero",
                    ConditionGrade = "Very Fine",
                    ConditionDescription = "Days of Future Past part 1! Excellent copy.",
                    Description = "Days of Future Past begins. The story that defined dystopian superhero comics.",
                    OwnerId = 3,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 17, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "The iconic cover. Essential reading for any X-Men fan.",
                    CoverImageUrl = "https://cdn.marvel.com/u/prod/marvel/i/mg/6/40/64e760f6051cb/clean.jpg"
                },
                new Comic
                {
                    Id = 13,
                    Title = "Wolverine",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1982, 9, 1),
                    Publisher = "Marvel",
                    Characters = "Wolverine, Mariko, Silver Samurai",
                    Era = "Bronze Age",
                    Genre = "Superhero/Action",
                    ConditionGrade = "Very Fine",
                    ConditionDescription = "First limited series! Miller/Claremont classic.",
                    Description = "The Claremont/Miller limited series that defined Wolverine. 'I'm the best there is at what I do.'",
                    OwnerId = 3,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 15, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Frank Miller on Wolverine. Doesn't get better than this.",
                    CoverImageUrl = "https://cdn.marvel.com/u/prod/marvel/i/mg/4/00/5854497f12e1f/clean.jpg"
                },

                // ========================================
                // CLASSIC DC - Daniel's Collection
                // ========================================
                new Comic
                {
                    Id = 14,
                    Title = "Batman",
                    IssueNumber = 232,
                    PublicationDate = new DateTime(1971, 6, 1),
                    Publisher = "DC",
                    Characters = "Batman, Ra's al Ghul, Talia",
                    Era = "Bronze Age",
                    Genre = "Superhero/Adventure",
                    ConditionGrade = "Fine",
                    ConditionDescription = "First Ra's al Ghul! Neal Adams art. Some wear.",
                    Description = "First appearance of Ra's al Ghul. O'Neil and Adams redefine Batman as the Dark Knight.",
                    OwnerId = 4,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 24, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "The issue that brought Batman back to his roots.",
                    CoverImageUrl = "https://static.wikia.nocookie.net/marvel_dc/images/9/9c/Batman_232.jpg"
                },
                new Comic
                {
                    Id = 15,
                    Title = "Green Lantern/Green Arrow",
                    IssueNumber = 76,
                    PublicationDate = new DateTime(1970, 4, 1),
                    Publisher = "DC",
                    Characters = "Green Lantern, Green Arrow",
                    Era = "Bronze Age",
                    Genre = "Superhero/Social Commentary",
                    ConditionGrade = "Very Good",
                    ConditionDescription = "Start of the legendary run. Cover wear present.",
                    Description = "The O'Neil/Adams run begins. Comics tackle social issues for the first time. A landmark in the medium.",
                    OwnerId = 4,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Comics grow up. This changed everything.",
                    CoverImageUrl = "https://static.wikia.nocookie.net/marvel_dc/images/1/1c/Green_Lantern_Vol_2_76.jpg"
                },
                new Comic
                {
                    Id = 16,
                    Title = "New Teen Titans",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1980, 11, 1),
                    Publisher = "DC",
                    Characters = "Robin, Starfire, Raven, Cyborg, Beast Boy",
                    Era = "Bronze Age",
                    Genre = "Superhero",
                    ConditionGrade = "Very Fine",
                    ConditionDescription = "Wolfman/Perez magic begins! Bright, tight copy.",
                    Description = "The start of DC's biggest 80s hit. Wolfman and Perez create a new generation of heroes.",
                    OwnerId = 4,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 22, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "DC's answer to X-Men. And it was amazing.",
                    CoverImageUrl = "https://static.wikia.nocookie.net/marvel_dc/images/8/8b/New_Teen_Titans_Vol_1_1.jpg"
                },
                new Comic
                {
                    Id = 17,
                    Title = "New Teen Titans",
                    IssueNumber = 2,
                    PublicationDate = new DateTime(1980, 12, 1),
                    Publisher = "DC",
                    Characters = "Teen Titans, Deathstroke",
                    Era = "Bronze Age",
                    Genre = "Superhero",
                    ConditionGrade = "Fine",
                    ConditionDescription = "First full Deathstroke! Good condition.",
                    Description = "First full appearance of Deathstroke the Terminator. The greatest villain of the Titans.",
                    OwnerId = 4,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Deathstroke's first full appearance. Key issue.",
                    CoverImageUrl = "https://imgix-media.wbdndc.net/ingest/book/preview/45fd1ec5-5011-4c2e-b7a1-bc6eef3029c6/b4e9f916-980a-4701-941f-88d40d97387f/0.jpg"
                },
                new Comic
                {
                    Id = 18,
                    Title = "Batman: The Dark Knight Returns",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1986, 2, 1),
                    Publisher = "DC",
                    Characters = "Batman, Commissioner Gordon, Harvey Dent",
                    Era = "Copper Age",
                    Genre = "Superhero/Dystopia",
                    ConditionGrade = "Near Mint",
                    ConditionDescription = "First print. Stored in Mylar since purchase.",
                    Description = "Frank Miller reinvents Batman. The comic that changed superhero storytelling forever.",
                    OwnerId = 4,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 18, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "The book that proved comics could be art.",
                    CoverImageUrl = "https://static.wikia.nocookie.net/batman/images/7/74/The_Dark_Knight_Returns.jpg"
                },

                // ========================================
                // INDIE CLASSICS - Sarah's Collection
                // ========================================
                new Comic
                {
                    Id = 19,
                    Title = "Cerebus the Aardvark",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1977, 12, 1),
                    Publisher = "Aardvark-Vanaheim",
                    Characters = "Cerebus",
                    Era = "Bronze Age",
                    Genre = "Fantasy/Satire",
                    ConditionGrade = "Good",
                    ConditionDescription = "Early indie key. Some wear but complete.",
                    Description = "The beginning of the 300-issue epic. Dave Sim's groundbreaking independent series.",
                    OwnerId = 5,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 26, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Start of the longest-running indie comic ever. A historic piece.",
                    CoverImageUrl = "https://recalledcomics.com/CerebusTheAardvark1.jpg"
                },
                new Comic
                {
                    Id = 20,
                    Title = "Teenage Mutant Ninja Turtles",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1984, 5, 1),
                    Publisher = "Mirage Studios",
                    Characters = "Leonardo, Donatello, Raphael, Michelangelo",
                    Era = "Copper Age",
                    Genre = "Action/Parody",
                    ConditionGrade = "Very Good",
                    ConditionDescription = "Third printing. Black and white indie key.",
                    Description = "Eastman and Laird's indie sensation that became a multimedia empire. Before the toys and cartoons.",
                    OwnerId = 5,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 25, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "The original, darker Turtles. Nothing like the cartoon.",
                    CoverImageUrl = "https://s3.amazonaws.com/comicgeeks/comics/covers/large-2032546.jpg"
                },
                new Comic
                {
                    Id = 21,
                    Title = "Elfquest",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1978, 8, 1),
                    Publisher = "WaRP Graphics",
                    Characters = "Cutter, Leetah, Skywise",
                    Era = "Bronze Age",
                    Genre = "Fantasy",
                    ConditionGrade = "Fine",
                    ConditionDescription = "Original printing. Wendy Pini masterpiece.",
                    Description = "The Pinis create one of the most beloved fantasy comics ever. Groundbreaking indie work.",
                    OwnerId = 5,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 24, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Fantasy comics at their finest. A complete world.",
                    CoverImageUrl = "https://static.wikia.nocookie.net/elfquest/images/2/2c/Fantasy_quarterly.jpg"
                },
                new Comic
                {
                    Id = 22,
                    Title = "American Flagg!",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1983, 10, 1),
                    Publisher = "First Comics",
                    Characters = "Reuben Flagg, Raul the Cat",
                    Era = "Copper Age",
                    Genre = "Sci-Fi/Political Satire",
                    ConditionGrade = "Very Fine",
                    ConditionDescription = "Howard Chaykin's masterwork. Excellent condition.",
                    Description = "Chaykin reinvents comic book design. A satirical near-future America that proved prescient.",
                    OwnerId = 5,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Revolutionary design and storytelling. Way ahead of its time.",
                    CoverImageUrl = "https://i.ebayimg.com/images/g/vfIAAOSwzlFmZNiG/s-l1600.webp"
                },
                new Comic
                {
                    Id = 23,
                    Title = "Love and Rockets",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1982, 1, 1),
                    Publisher = "Fantagraphics",
                    Characters = "Maggie, Hopey, Luba",
                    Era = "Copper Age",
                    Genre = "Drama/Slice of Life",
                    ConditionGrade = "Fine",
                    ConditionDescription = "Hernandez Brothers classic. First printing.",
                    Description = "The Hernandez Brothers create the most acclaimed alternative comic series. Punk rock meets magical realism.",
                    OwnerId = 5,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 21),
                    OwnerNotes = "The definitive indie comic. Literary greatness.",
                    CoverImageUrl = "https://i.ebayimg.com/images/g/VwgAAOSwMQxixHNs/s-l1600.webp"
                },

                // ========================================
                // HORROR CLASSICS - Henry's Collection
                // ========================================
                new Comic
                {
                    Id = 24,
                    Title = "Tomb of Dracula",
                    IssueNumber = 10,
                    PublicationDate = new DateTime(1973, 7, 1),
                    Publisher = "Marvel",
                    Characters = "Dracula, Blade",
                    Era = "Bronze Age",
                    Genre = "Horror",
                    ConditionGrade = "Very Good",
                    ConditionDescription = "First Blade appearance! Some wear but solid.",
                    Description = "First appearance of Blade the Vampire Slayer. Before the movies, there was Marv Wolfman's classic.",
                    OwnerId = 6,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 28, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Blade's first appearance. Key horror comic.",
                    CoverImageUrl = "https://static.wikia.nocookie.net/marveldatabase/images/2/2b/Tomb_of_Dracula_Vol_1_10.jpg"
                },
                new Comic
                {
                    Id = 25,
                    Title = "Tomb of Dracula",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1972, 4, 1),
                    Publisher = "Marvel",
                    Characters = "Dracula, Frank Drake",
                    Era = "Bronze Age",
                    Genre = "Horror",
                    ConditionGrade = "Fine",
                    ConditionDescription = "Gene Colan art. Start of the greatest horror run.",
                    Description = "The beginning of Marvel's longest-running horror title. Colan and Wolfman create magic.",
                    OwnerId = 6,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 27, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "70 issues of horror perfection starts here.",
                    CoverImageUrl = "https://cdn.marvel.com/u/prod/marvel/i/mg/c/30/4bb4fd44b834c/clean.jpg"
                },
                new Comic
                {
                    Id = 26,
                    Title = "Swamp Thing",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1972, 10, 1),
                    Publisher = "DC",
                    Characters = "Swamp Thing, Alec Holland",
                    Era = "Bronze Age",
                    Genre = "Horror",
                    ConditionGrade = "Very Good",
                    ConditionDescription = "Bernie Wrightson art. Classic origin issue.",
                    Description = "Bernie Wrightson's horrifying creation rises from the swamp. Pre-dates the Moore reinvention.",
                    OwnerId = 6,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 26, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Wrightson's gorgeous horror art. Before Moore's genius.",
                    CoverImageUrl = "https://static.wikia.nocookie.net/marvel_dc/images/f/fe/Swamp_Thing_Vol_1_1.jpg"
                },
                new Comic
                {
                    Id = 27,
                    Title = "Ghost Rider",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1973, 9, 1),
                    Publisher = "Marvel",
                    Characters = "Ghost Rider, Johnny Blaze",
                    Era = "Bronze Age",
                    Genre = "Horror/Superhero",
                    ConditionGrade = "Fine",
                    ConditionDescription = "First Johnny Blaze series. Good reading copy.",
                    Description = "Johnny Blaze makes his deal with the devil. Marvel's supernatural rider begins his solo journey.",
                    OwnerId = 6,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 25, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "70s supernatural horror at its finest.",
                    CoverImageUrl = "https://cdn.marvel.com/u/prod/marvel/i/mg/f/90/5caf5a9b36cd8/clean.jpg"
                },
                new Comic
                {
                    Id = 28,
                    Title = "Werewolf by Night",
                    IssueNumber = 32,
                    PublicationDate = new DateTime(1975, 8, 1),
                    Publisher = "Marvel",
                    Characters = "Werewolf by Night, Moon Knight",
                    Era = "Bronze Age",
                    Genre = "Horror",
                    ConditionGrade = "Very Good",
                    ConditionDescription = "First Moon Knight! Key Bronze Age horror issue.",
                    Description = "First appearance of Moon Knight. The character would go on to much greater fame.",
                    OwnerId = 6,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 24, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Moon Knight's humble beginnings in a horror comic.",
                    CoverImageUrl = "https://cdn.marvel.com/u/prod/marvel/i/mg/9/c0/58127df9d72ac/clean.jpg"
                },
                new Comic
                {
                    Id = 29,
                    Title = "Creepy",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1964, 1, 1),
                    Publisher = "Warren Publishing",
                    Characters = "Uncle Creepy (host)",
                    Era = "Silver Age",
                    Genre = "Horror Anthology",
                    ConditionGrade = "Good",
                    ConditionDescription = "Magazine format. Some wear but complete stories.",
                    Description = "Warren's answer to the banned EC Comics. Magazine-format horror with legendary artists.",
                    OwnerId = 6,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 22, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Classic horror magazine. The spirit of EC lives on.",
                    CoverImageUrl = "https://images.wolfgangsvault.com/m/large/OMS797023-MZ/creepy-vintage-magazine-jan-1-1964.webp"
                },
                new Comic
                {
                    Id = 30,
                    Title = "Epic Illustrated",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1980, 4, 1),
                    Publisher = "Marvel/Epic",
                    Characters = "Various",
                    Era = "Bronze Age",
                    Genre = "Anthology/Mature",
                    ConditionGrade = "Very Fine",
                    ConditionDescription = "Marvel's mature magazine. Excellent condition.",
                    Description = "Marvel's answer to Heavy Metal. Mature science fiction and fantasy from top creators.",
                    OwnerId = 6,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Marvel goes mature. Beautiful magazine-format anthology.",
                    CoverImageUrl = "https://static.wikia.nocookie.net/marveldatabase/images/3/3e/Epic_Illustrated_Vol_1_1.jpg"
                },

                // ========================================
                // JAPANESE ALTERNATIVE COMICS - Sofias's Collection
                // ========================================
                new Comic
                {
                    Id = 31,
                    Title = "Berserk Deluxe Edition",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1989, 8, 25),
                    Publisher = "Young Animal",
                    Characters = "Guts, Griffith, Casca",
                    Era = "Modern",
                    Genre = "Dark Fantasy/Action/Horror",
                    ConditionGrade = "Very Fine",
                    ConditionDescription = "First volume of legendary series. Minimal wear.",
                    Description = "A stunning deluxe edition collecting volumes 1–3 of the New York Times bestselling adult fantasy horror manga—now presented in the original oversized serialization format!",
                    OwnerId = 7,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 22, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "One of the greatest manga ever created. First volume in excellent condition.",
                    CoverImageUrl = "https://m.media-amazon.com/images/I/51IrW578SQL._SY445_SX342_PQ99_.jpg"
                },
                new Comic
                {
                    Id = 32,
                    Title = "One Piece",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1997, 7, 22),
                    Publisher = "Shueisha",
                    Characters = "Monkey D. Luffy, Roronoa Zoro, Nami",
                    Era = "Modern",
                    Genre = "Adventure/Fantasy/Shonen",
                    ConditionGrade = "Near Mint",
                    ConditionDescription = "First volume of best-selling manga series. Excellent condition.",
                    Description = "Eiichiro Oda's legendary pirate adventure. Join Luffy's quest to become King of the Pirates and find the One Piece treasure.",
                    OwnerId = 7,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 22, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Best-selling manga of all time. First volume in pristine condition.",
                    CoverImageUrl = "https://m.media-amazon.com/images/I/91NxYvUNf6L.jpg"
                },
                new Comic
                {
                    Id = 33,
                    Title = "Death Note",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(2003, 12, 1),
                    Publisher = "Shueisha",
                    Characters = "Light Yagami, L, Ryuk",
                    Era = "Modern",
                    Genre = "Psychological Thriller/Supernatural",
                    ConditionGrade = "Very Fine",
                    ConditionDescription = "First volume. Very clean with minor shelf wear.",
                    Description = "Tsugumi Ohba & Takeshi Obata's psychological thriller about a student who finds a death god's notebook. Intense cat-and-mouse game.",
                    OwnerId = 7,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Modern classic. Incredibly intelligent psychological warfare story.",
                    CoverImageUrl = "https://m.media-amazon.com/images/I/71ZFXxT85hL._AC_UF894,1000_QL80_.jpg"
                },
                new Comic
                {
                    Id = 34,
                    Title = "Attack on Titan",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(2009, 9, 9),
                    Publisher = "Kodansha",
                    Characters = "Eren Yeager, Mikasa Ackerman, Armin Arlert",
                    Era = "Modern",
                    Genre = "Dark Fantasy/Action/Horror",
                    ConditionGrade = "Near Mint",
                    ConditionDescription = "First volume. Pristine condition.",
                    Description = "Hajime Isayama's post-apocalyptic thriller about humanity's fight against giant humanoid Titans. Intense and unpredictable.",
                    OwnerId = 7,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Cultural phenomenon. First volume in perfect condition.",
                    CoverImageUrl = "https://m.media-amazon.com/images/I/81qPzeEO5IL._AC_UF1000,1000_QL80_.jpg"
                },
                new Comic
                {
                    Id = 35,
                    Title = "Fullmetal Alchemist",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(2001, 7, 12),
                    Publisher = "Square Enix",
                    Characters = "Edward Elric, Alphonse Elric",
                    Era = "Modern",
                    Genre = "Adventure/Fantasy/Shonen",
                    ConditionGrade = "Fine",
                    ConditionDescription = "First volume with light spine wear.",
                    Description = "Hiromu Arakawa's epic tale of two brothers seeking the Philosopher's Stone. Perfect blend of action, humor, and heart.",
                    OwnerId = 7,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 24, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Complete storytelling masterpiece. One of the best-rated manga ever.",
                    CoverImageUrl = "https://m.media-amazon.com/images/I/814IPObkuRL.jpg"
                },
                new Comic
                {
                    Id = 36,
                    Title = "Akira",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1982, 12, 20),
                    Publisher = "Young Magazine",
                    Characters = "Kaneda, Tetsuo, Kei",
                    Era = "Modern",
                    Genre = "Cyberpunk/Sci-Fi/Action",
                    ConditionGrade = "Very Fine",
                    ConditionDescription = "First volume of cyberpunk masterpiece. Great condition.",
                    Description = "Katsuhiro Otomo's groundbreaking cyberpunk epic set in Neo-Tokyo. Revolutionary artwork that defined a generation.",
                    OwnerId = 7,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 24, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "The manga that changed everything. Influenced countless works worldwide.",
                    CoverImageUrl = "https://m.media-amazon.com/images/I/71SKqtvjBAL._AC_UF1000,1000_QL80_.jpg"
                },
                new Comic
                {
                    Id = 37,
                    Title = "Claymore",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(2001, 7, 6),
                    Publisher = "Shueisha",
                    Characters = "Clare, Raki, Teresa",
                    Era = "Modern",
                    Genre = "Dark Fantasy/Action/Horror",
                    ConditionGrade = "Very Fine",
                    ConditionDescription = "First volume. Excellent condition with minimal wear.",
                    Description = "Norihiro Yagi's dark fantasy about half-human, half-monster warriors called Claymores. Follows Clare's quest for revenge in a medieval world.",
                    OwnerId = 7,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 24, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Most similar to Berserk in style and themes. Dark, violent, and beautifully drawn.",
                    CoverImageUrl = "https://m.media-amazon.com/images/I/71FtRJVWfUL._AC_UF1000,1000_QL80_.jpg"
                },
                new Comic
                {
                    Id = 38,
                    Title = "Vinland Saga",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(2005, 4, 13),
                    Publisher = "Kodansha",
                    Characters = "Thorfinn, Askeladd, Thors",
                    Era = "Modern",
                    Genre = "Historical/Action/Drama",
                    ConditionGrade = "Near Mint",
                    ConditionDescription = "First volume in pristine condition.",
                    Description = "Makoto Yukimura's epic Viking saga. Follow Thorfinn's journey from revenge-driven warrior to seeking a land without war. Stunning historical detail.",
                    OwnerId = 7,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 25, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Masterful storytelling with Berserk-level depth. Best historical manga currently running.",
                    CoverImageUrl = "https://m.media-amazon.com/images/I/71skCdi-foL._AC_UF1000,1000_QL80_.jpg"
                },

                new Comic
                {
                    Id = 39,
                    Title = "Guin Saga",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1979, 9, 1),
                    Publisher = "Hayakawa Publishing",
                    Characters = "Guin, Rinda, Remus",
                    Era = "Classic",
                    Genre = "Epic Fantasy/Adventure",
                    ConditionGrade = "Fine",
                    ConditionDescription = "Rare first volume. Some age-related wear, pages intact.",
                    Description = "Kaoru Kurimoto's legendary epic fantasy series. A leopard-headed warrior protects twin royals. The series that inspired Kentaro Miura.",
                    OwnerId = 7,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 25, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "The epic fantasy that inspired Berserk. Rare manga adaptation of the legendary novel series.",
                    CoverImageUrl = "https://m.media-amazon.com/images/I/81qSrZlxpPL._AC_UF1000,1000_QL80_.jpg"
                },

                new Comic
                {
                    Id = 40,
                    Title = "Vagabond",
                    IssueNumber = 1,
                    PublicationDate = new DateTime(1998, 9, 17),
                    Publisher = "Kodansha",
                    Characters = "Musashi Miyamoto, Kojiro Sasaki, Otsu",
                    Era = "Modern",
                    Genre = "Historical/Action/Drama/Seinen",
                    ConditionGrade = "Very Fine",
                    ConditionDescription = "First volume. Exceptional condition.",
                    Description = "Takehiko Inoue's breathtaking samurai epic based on Miyamoto Musashi's life. Philosophical depth meets stunning artwork. A true masterpiece.",
                    OwnerId = 7,
                    IsAvailable = true,
                    DateListed = new DateTime(2025, 1, 25, 0, 0, 0, DateTimeKind.Utc),
                    OwnerNotes = "Arguably the most beautifully drawn manga ever created. Rivals Berserk in artistic achievement.",
                    CoverImageUrl = "https://m.media-amazon.com/images/I/71TY7kJBo9L._AC_UF1000,1000_QL80_.jpg"
                }

            };

            // Set approval defaults for seeded comics
            foreach (var c in list)
            {
                c.ApprovalStatus = ApprovalStatus.Approved;
            }

            return list;
        }

        private static List<Loan> GetPastLoans()
        {
            // Create historical completed loans that match the SuccessfulLoans counts
            // User 1 (Bob): 24 loans, User 2 (Diana): 18 loans, User 3 (Marcus): 42 loans
            // User 4 (Daniel): 31 loans, User 5 (Sarah): 15 loans, User 6 (Henry): 22 loans

            var loans = new List<Loan>();
            int loanId = 1;

            // Bob's completed loans (24 total - 12 as lender, 12 as borrower)
            for (int i = 0; i < 12; i++)
            {
                loans.Add(new Loan
                {
                    Id = loanId++,
                    ComicId = (i % 4) + 1, // Bob's comics (1-4)
                    BorrowerId = (i % 5) + 2, // Users 2-6 as borrowers
                    LenderId = 1,
                    Status = "Returned",
                    DateCreated = DateTime.UtcNow.AddMonths(-(24 - i)),
                    LoanStartDate = DateTime.UtcNow.AddMonths(-(24 - i)),
                    LoanEndDate = DateTime.UtcNow.AddMonths(-(24 - i)).AddDays(14),
                    ActualReturnDate = DateTime.UtcNow.AddMonths(-(24 - i)).AddDays(13),
                    LoanDurationDays = 14,
                    MeetupLocation = "Malmö Central Station",
                    MeetupDateTime = DateTime.UtcNow.AddMonths(-(24 - i)),
                    ReturnMeetupLocation = "Malmö Central Station",
                    ReturnMeetupDateTime = DateTime.UtcNow.AddMonths(-(24 - i)).AddDays(13),
                    LenderConfirmedReturn = true,
                    BorrowerReceivedComic = true
                });
            }

            // Bob as borrower (12 loans)
            for (int i = 0; i < 12; i++)
            {
                int lenderId = (i % 5) + 2; // Users 2-6 as lenders
                int comicId = lenderId == 2 ? (i % 4) + 5 : lenderId == 3 ? (i % 5) + 9 : lenderId == 4 ? (i % 5) + 14 : lenderId == 5 ? (i % 5) + 19 : (i % 7) + 24;

                loans.Add(new Loan
                {
                    Id = loanId++,
                    ComicId = comicId,
                    BorrowerId = 1,
                    LenderId = lenderId,
                    Status = "Returned",
                    DateCreated = DateTime.UtcNow.AddMonths(-(23 - i)),
                    LoanStartDate = DateTime.UtcNow.AddMonths(-(23 - i)),
                    LoanEndDate = DateTime.UtcNow.AddMonths(-(23 - i)).AddDays(14),
                    ActualReturnDate = DateTime.UtcNow.AddMonths(-(23 - i)).AddDays(14),
                    LoanDurationDays = 14,
                    MeetupLocation = "Malmö Triangeln",
                    MeetupDateTime = DateTime.UtcNow.AddMonths(-(23 - i)),
                    ReturnMeetupLocation = "Malmö Triangeln",
                    ReturnMeetupDateTime = DateTime.UtcNow.AddMonths(-(23 - i)).AddDays(14),
                    LenderConfirmedReturn = true,
                    BorrowerReceivedComic = true
                });
            }

            // Diana's completed loans (18 total - 9 as lender, 9 as borrower)
            for (int i = 0; i < 9; i++)
            {
                loans.Add(new Loan
                {
                    Id = loanId++,
                    ComicId = (i % 4) + 5, // Diana's comics (5-8)
                    BorrowerId = (i % 5) + 1 == 2 ? 6 : (i % 5) + 1, // Skip Diana herself
                    LenderId = 2,
                    Status = "Returned",
                    DateCreated = DateTime.UtcNow.AddMonths(-(20 - i)),
                    LoanStartDate = DateTime.UtcNow.AddMonths(-(20 - i)),
                    LoanEndDate = DateTime.UtcNow.AddMonths(-(20 - i)).AddDays(14),
                    ActualReturnDate = DateTime.UtcNow.AddMonths(-(20 - i)).AddDays(14),
                    LoanDurationDays = 14,
                    MeetupLocation = "Lund University Library",
                    MeetupDateTime = DateTime.UtcNow.AddMonths(-(20 - i)),
                    ReturnMeetupLocation = "Lund University Library",
                    ReturnMeetupDateTime = DateTime.UtcNow.AddMonths(-(20 - i)).AddDays(14),
                    LenderConfirmedReturn = true,
                    BorrowerReceivedComic = true
                });
            }

            // Diana as borrower (9 loans)
            for (int i = 0; i < 9; i++)
            {
                int lenderId = (i % 4) + 3; // Users 3, 4, 5, 6
                int comicId = lenderId == 3 ? (i % 5) + 9 : lenderId == 4 ? (i % 5) + 14 : lenderId == 5 ? (i % 5) + 19 : (i % 7) + 24;

                loans.Add(new Loan
                {
                    Id = loanId++,
                    ComicId = comicId,
                    BorrowerId = 2,
                    LenderId = lenderId,
                    Status = "Returned",
                    DateCreated = DateTime.UtcNow.AddMonths(-(19 - i)),
                    LoanStartDate = DateTime.UtcNow.AddMonths(-(19 - i)),
                    LoanEndDate = DateTime.UtcNow.AddMonths(-(19 - i)).AddDays(14),
                    ActualReturnDate = DateTime.UtcNow.AddMonths(-(19 - i)).AddDays(13),
                    LoanDurationDays = 14,
                    MeetupLocation = "Lund Central",
                    MeetupDateTime = DateTime.UtcNow.AddMonths(-(19 - i)),
                    ReturnMeetupLocation = "Lund Central",
                    ReturnMeetupDateTime = DateTime.UtcNow.AddMonths(-(19 - i)).AddDays(13),
                    LenderConfirmedReturn = true,
                    BorrowerReceivedComic = true
                });
            }

            // Marcus's completed loans (42 total - 21 as lender, 21 as borrower)
            for (int i = 0; i < 21; i++)
            {
                loans.Add(new Loan
                {
                    Id = loanId++,
                    ComicId = (i % 5) + 9, // Marcus's comics (9-13)
                    BorrowerId = (i % 5) + 1 == 3 ? 6 : (i % 5) + 1, // Skip Marcus himself
                    LenderId = 3,
                    Status = "Returned",
                    DateCreated = DateTime.UtcNow.AddMonths(-(22 - i)),
                    LoanStartDate = DateTime.UtcNow.AddMonths(-(22 - i)),
                    LoanEndDate = DateTime.UtcNow.AddMonths(-(22 - i)).AddDays(14),
                    ActualReturnDate = DateTime.UtcNow.AddMonths(-(22 - i)).AddDays(14),
                    LoanDurationDays = 14,
                    MeetupLocation = "Helsingborg Central Station",
                    MeetupDateTime = DateTime.UtcNow.AddMonths(-(22 - i)),
                    ReturnMeetupLocation = "Helsingborg Central Station",
                    ReturnMeetupDateTime = DateTime.UtcNow.AddMonths(-(22 - i)).AddDays(14),
                    LenderConfirmedReturn = true,
                    BorrowerReceivedComic = true
                });
            }

            // Marcus as borrower (21 loans)
            for (int i = 0; i < 21; i++)
            {
                int lenderId = (i % 5) + 1 == 3 ? 6 : (i % 5) + 1; // Skip Marcus himself
                int comicId = lenderId == 1 ? (i % 4) + 1 : lenderId == 2 ? (i % 4) + 5 : lenderId == 4 ? (i % 5) + 14 : lenderId == 5 ? (i % 5) + 19 : (i % 7) + 24;

                loans.Add(new Loan
                {
                    Id = loanId++,
                    ComicId = comicId,
                    BorrowerId = 3,
                    LenderId = lenderId,
                    Status = "Returned",
                    DateCreated = DateTime.UtcNow.AddMonths(-(21 - i)),
                    LoanStartDate = DateTime.UtcNow.AddMonths(-(21 - i)),
                    LoanEndDate = DateTime.UtcNow.AddMonths(-(21 - i)).AddDays(14),
                    ActualReturnDate = DateTime.UtcNow.AddMonths(-(21 - i)).AddDays(13),
                    LoanDurationDays = 14,
                    MeetupLocation = "Helsingborg Knutpunkten",
                    MeetupDateTime = DateTime.UtcNow.AddMonths(-(21 - i)),
                    ReturnMeetupLocation = "Helsingborg Knutpunkten",
                    ReturnMeetupDateTime = DateTime.UtcNow.AddMonths(-(21 - i)).AddDays(13),
                    LenderConfirmedReturn = true,
                    BorrowerReceivedComic = true
                });
            }

            // Daniel's completed loans (31 total - 16 as lender, 15 as borrower)
            for (int i = 0; i < 16; i++)
            {
                loans.Add(new Loan
                {
                    Id = loanId++,
                    ComicId = (i % 5) + 14, // Daniel's comics (14-18)
                    BorrowerId = (i % 5) + 1 == 4 ? 6 : (i % 5) + 1, // Skip Daniel himself
                    LenderId = 4,
                    Status = "Returned",
                    DateCreated = DateTime.UtcNow.AddMonths(-(18 - i)),
                    LoanStartDate = DateTime.UtcNow.AddMonths(-(18 - i)),
                    LoanEndDate = DateTime.UtcNow.AddMonths(-(18 - i)).AddDays(14),
                    ActualReturnDate = DateTime.UtcNow.AddMonths(-(18 - i)).AddDays(14),
                    LoanDurationDays = 14,
                    MeetupLocation = "Malmö Västra Hamnen",
                    MeetupDateTime = DateTime.UtcNow.AddMonths(-(18 - i)),
                    ReturnMeetupLocation = "Malmö Västra Hamnen",
                    ReturnMeetupDateTime = DateTime.UtcNow.AddMonths(-(18 - i)).AddDays(14),
                    LenderConfirmedReturn = true,
                    BorrowerReceivedComic = true
                });
            }

            // Daniel as borrower (15 loans)
            for (int i = 0; i < 15; i++)
            {
                int lenderId = (i % 5) + 1 == 4 ? 6 : (i % 5) + 1; // Skip Daniel himself
                int comicId = lenderId == 1 ? (i % 4) + 1 : lenderId == 2 ? (i % 4) + 5 : lenderId == 3 ? (i % 5) + 9 : lenderId == 5 ? (i % 5) + 19 : (i % 7) + 24;

                loans.Add(new Loan
                {
                    Id = loanId++,
                    ComicId = comicId,
                    BorrowerId = 4,
                    LenderId = lenderId,
                    Status = "Returned",
                    DateCreated = DateTime.UtcNow.AddMonths(-(17 - i)),
                    LoanStartDate = DateTime.UtcNow.AddMonths(-(17 - i)),
                    LoanEndDate = DateTime.UtcNow.AddMonths(-(17 - i)).AddDays(14),
                    ActualReturnDate = DateTime.UtcNow.AddMonths(-(17 - i)).AddDays(14),
                    LoanDurationDays = 14,
                    MeetupLocation = "Malmö City Library",
                    MeetupDateTime = DateTime.UtcNow.AddMonths(-(17 - i)),
                    ReturnMeetupLocation = "Malmö City Library",
                    ReturnMeetupDateTime = DateTime.UtcNow.AddMonths(-(17 - i)).AddDays(14),
                    LenderConfirmedReturn = true,
                    BorrowerReceivedComic = true
                });
            }

            // Sarah's completed loans (15 total - 8 as lender, 7 as borrower)
            for (int i = 0; i < 8; i++)
            {
                loans.Add(new Loan
                {
                    Id = loanId++,
                    ComicId = (i % 5) + 19, // Sarah's comics (19-23)
                    BorrowerId = (i % 4) + 1, // Users 1-4
                    LenderId = 5,
                    Status = "Returned",
                    DateCreated = DateTime.UtcNow.AddMonths(-(16 - i)),
                    LoanStartDate = DateTime.UtcNow.AddMonths(-(16 - i)),
                    LoanEndDate = DateTime.UtcNow.AddMonths(-(16 - i)).AddDays(14),
                    ActualReturnDate = DateTime.UtcNow.AddMonths(-(16 - i)).AddDays(13),
                    LoanDurationDays = 14,
                    MeetupLocation = "Lund University",
                    MeetupDateTime = DateTime.UtcNow.AddMonths(-(16 - i)),
                    ReturnMeetupLocation = "Lund University",
                    ReturnMeetupDateTime = DateTime.UtcNow.AddMonths(-(16 - i)).AddDays(13),
                    LenderConfirmedReturn = true,
                    BorrowerReceivedComic = true
                });
            }

            // Sarah as borrower (7 loans)
            for (int i = 0; i < 7; i++)
            {
                int lenderId = (i % 4) + 1; // Users 1-4
                int comicId = lenderId == 1 ? (i % 4) + 1 : lenderId == 2 ? (i % 4) + 5 : lenderId == 3 ? (i % 5) + 9 : (i % 5) + 14;

                loans.Add(new Loan
                {
                    Id = loanId++,
                    ComicId = comicId,
                    BorrowerId = 5,
                    LenderId = lenderId,
                    Status = "Returned",
                    DateCreated = DateTime.UtcNow.AddMonths(-(15 - i)),
                    LoanStartDate = DateTime.UtcNow.AddMonths(-(15 - i)),
                    LoanEndDate = DateTime.UtcNow.AddMonths(-(15 - i)).AddDays(14),
                    ActualReturnDate = DateTime.UtcNow.AddMonths(-(15 - i)).AddDays(14),
                    LoanDurationDays = 14,
                    MeetupLocation = "Lund Central",
                    MeetupDateTime = DateTime.UtcNow.AddMonths(-(15 - i)),
                    ReturnMeetupLocation = "Lund Central",
                    ReturnMeetupDateTime = DateTime.UtcNow.AddMonths(-(15 - i)).AddDays(14),
                    LenderConfirmedReturn = true,
                    BorrowerReceivedComic = true
                });
            }

            // Henry's completed loans (22 total - 11 as lender, 11 as borrower)
            for (int i = 0; i < 11; i++)
            {
                loans.Add(new Loan
                {
                    Id = loanId++,
                    ComicId = (i % 7) + 24, // Henry's comics (24-30)
                    BorrowerId = (i % 5) + 1, // Users 1-5
                    LenderId = 6,
                    Status = "Returned",
                    DateCreated = DateTime.UtcNow.AddMonths(-(14 - i)),
                    LoanStartDate = DateTime.UtcNow.AddMonths(-(14 - i)),
                    LoanEndDate = DateTime.UtcNow.AddMonths(-(14 - i)).AddDays(14),
                    ActualReturnDate = DateTime.UtcNow.AddMonths(-(14 - i)).AddDays(14),
                    LoanDurationDays = 14,
                    MeetupLocation = "Malmö Möllevången",
                    MeetupDateTime = DateTime.UtcNow.AddMonths(-(14 - i)),
                    ReturnMeetupLocation = "Malmö Möllevången",
                    ReturnMeetupDateTime = DateTime.UtcNow.AddMonths(-(14 - i)).AddDays(14),
                    LenderConfirmedReturn = true,
                    BorrowerReceivedComic = true
                });
            }

            // Henry as borrower (11 loans)
            for (int i = 0; i < 11; i++)
            {
                int lenderId = (i % 5) + 1; // Users 1-5
                int comicId = lenderId == 1 ? (i % 4) + 1 : lenderId == 2 ? (i % 4) + 5 : lenderId == 3 ? (i % 5) + 9 : lenderId == 4 ? (i % 5) + 14 : (i % 5) + 19;

                loans.Add(new Loan
                {
                    Id = loanId++,
                    ComicId = comicId,
                    BorrowerId = 6,
                    LenderId = lenderId,
                    Status = "Returned",
                    DateCreated = DateTime.UtcNow.AddMonths(-(13 - i)),
                    LoanStartDate = DateTime.UtcNow.AddMonths(-(13 - i)),
                    LoanEndDate = DateTime.UtcNow.AddMonths(-(13 - i)).AddDays(14),
                    ActualReturnDate = DateTime.UtcNow.AddMonths(-(13 - i)).AddDays(13),
                    LoanDurationDays = 14,
                    MeetupLocation = "Malmö Värnhem",
                    MeetupDateTime = DateTime.UtcNow.AddMonths(-(13 - i)),
                    ReturnMeetupLocation = "Malmö Värnhem",
                    ReturnMeetupDateTime = DateTime.UtcNow.AddMonths(-(13 - i)).AddDays(13),
                    LenderConfirmedReturn = true,
                    BorrowerReceivedComic = true
                });
            }

            return loans;
        }


        private static List<Loan> GetOngoingLoans(int startingId = 1)
        {
            var loans = new List<Loan>();
            int loanId = startingId; // Use passed starting ID
            var today = DateTime.UtcNow.Date;

            // Create ongoing loans with different statuses relative to return date
            // Some due soon (this week), some overdue, some with time remaining

            // Bob's ongoing loans (6 total - 3 as lender, 3 as borrower)
            // Due this Thursday (Dec 12)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 1,
                BorrowerId = 2,
                LenderId = 1,
                Status = "Active",
                DateCreated = today.AddDays(-12),
                LoanStartDate = today.AddDays(-12),
                LoanEndDate = today.AddDays(2), // Thursday Dec 12
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Malmö Central Station",
                MeetupDateTime = today.AddDays(-12),
                ReturnMeetupLocation = "Malmö Central Station",
                ReturnMeetupDateTime = today.AddDays(2),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Due tomorrow (Dec 11)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 2,
                BorrowerId = 3,
                LenderId = 1,
                Status = "Active",
                DateCreated = today.AddDays(-13),
                LoanStartDate = today.AddDays(-13),
                LoanEndDate = today.AddDays(1), // Wednesday Dec 11
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Malmö Central Station",
                MeetupDateTime = today.AddDays(-13),
                ReturnMeetupLocation = "Malmö Central Station",
                ReturnMeetupDateTime = today.AddDays(1),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Overdue by 2 days
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 3,
                BorrowerId = 4,
                LenderId = 1,
                Status = "Overdue",
                DateCreated = today.AddDays(-16),
                LoanStartDate = today.AddDays(-16),
                LoanEndDate = today.AddDays(-2), // Dec 8
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Malmö Triangeln",
                MeetupDateTime = today.AddDays(-16),
                ReturnMeetupLocation = "Malmö Triangeln",
                ReturnMeetupDateTime = today.AddDays(-2),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Bob as borrower - Due in 5 days (Dec 15)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 5,
                BorrowerId = 1,
                LenderId = 2,
                Status = "Active",
                DateCreated = today.AddDays(-9),
                LoanStartDate = today.AddDays(-9),
                LoanEndDate = today.AddDays(5),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Lund University Library",
                MeetupDateTime = today.AddDays(-9),
                ReturnMeetupLocation = "Lund University Library",
                ReturnMeetupDateTime = today.AddDays(5),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Bob as borrower - Due in 8 days (Dec 18)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 9,
                BorrowerId = 1,
                LenderId = 3,
                Status = "Active",
                DateCreated = today.AddDays(-6),
                LoanStartDate = today.AddDays(-6),
                LoanEndDate = today.AddDays(8),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Helsingborg Central Station",
                MeetupDateTime = today.AddDays(-6),
                ReturnMeetupLocation = "Helsingborg Central Station",
                ReturnMeetupDateTime = today.AddDays(8),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Bob as borrower - Overdue by 1 day
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 14,
                BorrowerId = 1,
                LenderId = 4,
                Status = "Overdue",
                DateCreated = today.AddDays(-15),
                LoanStartDate = today.AddDays(-15),
                LoanEndDate = today.AddDays(-1),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Malmö Västra Hamnen",
                MeetupDateTime = today.AddDays(-15),
                ReturnMeetupLocation = "Malmö Västra Hamnen",
                ReturnMeetupDateTime = today.AddDays(-1),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Diana's ongoing loans (4 total - 2 as lender, 2 as borrower)
            // Due this Thursday (Dec 12)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 6,
                BorrowerId = 1,
                LenderId = 2,
                Status = "Active",
                DateCreated = today.AddDays(-12),
                LoanStartDate = today.AddDays(-12),
                LoanEndDate = today.AddDays(2),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Lund University Library",
                MeetupDateTime = today.AddDays(-12),
                ReturnMeetupLocation = "Lund University Library",
                ReturnMeetupDateTime = today.AddDays(2),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Due in 10 days (Dec 20)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 7,
                BorrowerId = 3,
                LenderId = 2,
                Status = "Active",
                DateCreated = today.AddDays(-4),
                LoanStartDate = today.AddDays(-4),
                LoanEndDate = today.AddDays(10),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Lund Central",
                MeetupDateTime = today.AddDays(-4),
                ReturnMeetupLocation = "Lund Central",
                ReturnMeetupDateTime = today.AddDays(10),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Diana as borrower - Due in 3 days (Dec 13)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 11,
                BorrowerId = 2,
                LenderId = 3,
                Status = "Active",
                DateCreated = today.AddDays(-11),
                LoanStartDate = today.AddDays(-11),
                LoanEndDate = today.AddDays(3),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Helsingborg Knutpunkten",
                MeetupDateTime = today.AddDays(-11),
                ReturnMeetupLocation = "Helsingborg Knutpunkten",
                ReturnMeetupDateTime = today.AddDays(3),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Diana as borrower - Due in 7 days (Dec 17)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 19,
                BorrowerId = 2,
                LenderId = 5,
                Status = "Active",
                DateCreated = today.AddDays(-7),
                LoanStartDate = today.AddDays(-7),
                LoanEndDate = today.AddDays(7),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Lund University",
                MeetupDateTime = today.AddDays(-7),
                ReturnMeetupLocation = "Lund University",
                ReturnMeetupDateTime = today.AddDays(7),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Marcus's ongoing loans (5 total - 3 as lender, 2 as borrower)
            // Due today (Dec 10)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 10,
                BorrowerId = 4,
                LenderId = 3,
                Status = "Active",
                DateCreated = today.AddDays(-14),
                LoanStartDate = today.AddDays(-14),
                LoanEndDate = today,
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Helsingborg Central Station",
                MeetupDateTime = today.AddDays(-14),
                ReturnMeetupLocation = "Helsingborg Central Station",
                ReturnMeetupDateTime = today,
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Due in 4 days (Dec 14)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 12,
                BorrowerId = 5,
                LenderId = 3,
                Status = "Active",
                DateCreated = today.AddDays(-10),
                LoanStartDate = today.AddDays(-10),
                LoanEndDate = today.AddDays(4),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Helsingborg Knutpunkten",
                MeetupDateTime = today.AddDays(-10),
                ReturnMeetupLocation = "Helsingborg Knutpunkten",
                ReturnMeetupDateTime = today.AddDays(4),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Overdue by 3 days
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 13,
                BorrowerId = 6,
                LenderId = 3,
                Status = "Overdue",
                DateCreated = today.AddDays(-17),
                LoanStartDate = today.AddDays(-17),
                LoanEndDate = today.AddDays(-3),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Helsingborg Central Station",
                MeetupDateTime = today.AddDays(-17),
                ReturnMeetupLocation = "Helsingborg Central Station",
                ReturnMeetupDateTime = today.AddDays(-3),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Marcus as borrower - Due in 6 days (Dec 16)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 15,
                BorrowerId = 3,
                LenderId = 4,
                Status = "Active",
                DateCreated = today.AddDays(-8),
                LoanStartDate = today.AddDays(-8),
                LoanEndDate = today.AddDays(6),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Malmö City Library",
                MeetupDateTime = today.AddDays(-8),
                ReturnMeetupLocation = "Malmö City Library",
                ReturnMeetupDateTime = today.AddDays(6),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Marcus as borrower - Due in 11 days (Dec 21)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 24,
                BorrowerId = 3,
                LenderId = 6,
                Status = "Active",
                DateCreated = today.AddDays(-3),
                LoanStartDate = today.AddDays(-3),
                LoanEndDate = today.AddDays(11),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Malmö Möllevången",
                MeetupDateTime = today.AddDays(-3),
                ReturnMeetupLocation = "Malmö Möllevången",
                ReturnMeetupDateTime = today.AddDays(11),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Daniel's ongoing loans (3 total - 2 as lender, 1 as borrower)
            // Due this Thursday (Dec 12)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 16,
                BorrowerId = 2,
                LenderId = 4,
                Status = "Active",
                DateCreated = today.AddDays(-12),
                LoanStartDate = today.AddDays(-12),
                LoanEndDate = today.AddDays(2),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Malmö Västra Hamnen",
                MeetupDateTime = today.AddDays(-12),
                ReturnMeetupLocation = "Malmö Västra Hamnen",
                ReturnMeetupDateTime = today.AddDays(2),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Due in 9 days (Dec 19)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 17,
                BorrowerId = 6,
                LenderId = 4,
                Status = "Active",
                DateCreated = today.AddDays(-5),
                LoanStartDate = today.AddDays(-5),
                LoanEndDate = today.AddDays(9),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Malmö City Library",
                MeetupDateTime = today.AddDays(-5),
                ReturnMeetupLocation = "Malmö City Library",
                ReturnMeetupDateTime = today.AddDays(9),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Daniel as borrower - Due in 12 days (Dec 22)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 20,
                BorrowerId = 4,
                LenderId = 5,
                Status = "Active",
                DateCreated = today.AddDays(-2),
                LoanStartDate = today.AddDays(-2),
                LoanEndDate = today.AddDays(12),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Lund Central",
                MeetupDateTime = today.AddDays(-2),
                ReturnMeetupLocation = "Lund Central",
                ReturnMeetupDateTime = today.AddDays(12),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Sarah's ongoing loans (2 total - 1 as lender, 1 as borrower)
            // Due tomorrow (Dec 11)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 21,
                BorrowerId = 4,
                LenderId = 5,
                Status = "Active",
                DateCreated = today.AddDays(-13),
                LoanStartDate = today.AddDays(-13),
                LoanEndDate = today.AddDays(1),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Lund University",
                MeetupDateTime = today.AddDays(-13),
                ReturnMeetupLocation = "Lund University",
                ReturnMeetupDateTime = today.AddDays(1),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Sarah as borrower - Due in 13 days (Dec 23)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 25,
                BorrowerId = 5,
                LenderId = 6,
                Status = "Active",
                DateCreated = today.AddDays(-1),
                LoanStartDate = today.AddDays(-1),
                LoanEndDate = today.AddDays(13),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Malmö Värnhem",
                MeetupDateTime = today.AddDays(-1),
                ReturnMeetupLocation = "Malmö Värnhem",
                ReturnMeetupDateTime = today.AddDays(13),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Henry's ongoing loans (3 total - 2 as lender, 1 as borrower)
            // Due this Thursday (Dec 12)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 26,
                BorrowerId = 1,
                LenderId = 6,
                Status = "Active",
                DateCreated = today.AddDays(-12),
                LoanStartDate = today.AddDays(-12),
                LoanEndDate = today.AddDays(2),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Malmö Möllevången",
                MeetupDateTime = today.AddDays(-12),
                ReturnMeetupLocation = "Malmö Möllevången",
                ReturnMeetupDateTime = today.AddDays(2),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Overdue by 4 days
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 28,
                BorrowerId = 3,
                LenderId = 6,
                Status = "Overdue",
                DateCreated = today.AddDays(-18),
                LoanStartDate = today.AddDays(-18),
                LoanEndDate = today.AddDays(-4),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Malmö Värnhem",
                MeetupDateTime = today.AddDays(-18),
                ReturnMeetupLocation = "Malmö Värnhem",
                ReturnMeetupDateTime = today.AddDays(-4),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            // Henry as borrower - Due in 2 days (Dec 12)
            loans.Add(new Loan
            {
                Id = loanId++,
                ComicId = 4,
                BorrowerId = 6,
                LenderId = 1,
                Status = "Active",
                DateCreated = today.AddDays(-12),
                LoanStartDate = today.AddDays(-12),
                LoanEndDate = today.AddDays(2),
                ActualReturnDate = null,
                LoanDurationDays = 14,
                MeetupLocation = "Malmö Triangeln",
                MeetupDateTime = today.AddDays(-12),
                ReturnMeetupLocation = "Malmö Triangeln",
                ReturnMeetupDateTime = today.AddDays(2),
                LenderConfirmedReturn = false,
                BorrowerReceivedComic = true
            });

            return loans;
        }

        private static List<Review> GetReviews()
        {
            // Create reviews that match the AverageRating for each user
            // User 1 (Bob): 4.9, User 2 (Diana): 5.0, User 3 (Marcus): 4.8
            // User 4 (Daniel): 4.9, User 5 (Sarah): 4.7, User 6 (Henry): 4.8

            // IMPORTANT: ReviewerId is who WROTE the review, ReviewedUserId is who is BEING reviewed
            // For completed loans display, we show the rating the CURRENT USER gave to the OTHER person

            var reviews = new List<Review>();
            int reviewId = 1;

            // Reviews BY User 1 (Bob) - Bob reviewing others after his loans
            // Bob borrowed from users 2-6 (12 loans), so he reviews them
            for (int i = 0; i < 12; i++)
            {
                int reviewedUserId = (i % 5) + 2; // Users 2-6
                int rating = i % 5 == 0 ? 4 : 5;

                reviews.Add(new Review
                {
                    Id = reviewId++,
                    ReviewerId = 1, // Bob is the reviewer
                    ReviewedUserId = reviewedUserId, // He's reviewing users 2-6
                    LoanId = 13 + i, // Bob's borrowing loans (13-24)
                    Rating = rating,
                    Comment = rating == 5 ? "Excellent lender! Comic in perfect condition." : "Great experience, reliable lender.",
                    ConditionAsDescribed = true,
                    CommunicationGood = true,
                    MeetupExperience = true,
                    DateSubmitted = DateTime.UtcNow.AddMonths(-(23 - i)).AddDays(14)
                });
            }

            // Reviews FOR User 1 (Bob) - Others reviewing Bob after lending from him
            for (int i = 0; i < 12; i++)
            {
                int reviewerId = (i % 5) + 2; // Users 2-6 reviewing Bob
                int rating = i % 5 == 0 ? 4 : 5;

                reviews.Add(new Review
                {
                    Id = reviewId++,
                    ReviewerId = reviewerId, // Users 2-6 are reviewers
                    ReviewedUserId = 1, // They're reviewing Bob
                    LoanId = i + 1, // Bob's lending loans (1-12)
                    Rating = rating,
                    Comment = rating == 5 ? "Excellent lender! Comic in perfect condition." : "Great borrower, took good care of comic.",
                    ConditionAsDescribed = true,
                    CommunicationGood = true,
                    MeetupExperience = true,
                    DateSubmitted = DateTime.UtcNow.AddMonths(-(24 - i)).AddDays(14)
                });
            }

            // Reviews BY User 2 (Diana) - Diana reviewing others
            for (int i = 0; i < 9; i++)
            {
                int reviewedUserId = (i % 4) + 3; // Users 3-6

                reviews.Add(new Review
                {
                    Id = reviewId++,
                    ReviewerId = 2, // Diana is the reviewer
                    ReviewedUserId = reviewedUserId,
                    LoanId = 34 + i, // Diana's borrowing loans
                    Rating = 5,
                    Comment = "Perfect transaction! Highly recommended.",
                    ConditionAsDescribed = true,
                    CommunicationGood = true,
                    MeetupExperience = true,
                    DateSubmitted = DateTime.UtcNow.AddMonths(-(19 - i)).AddDays(14)
                });
            }

            // Reviews FOR User 2 (Diana) - Others reviewing Diana
            for (int i = 0; i < 9; i++)
            {
                int reviewerId = (i % 5) + 1 == 2 ? 6 : (i % 5) + 1;

                reviews.Add(new Review
                {
                    Id = reviewId++,
                    ReviewerId = reviewerId,
                    ReviewedUserId = 2, // Reviewing Diana
                    LoanId = 25 + i, // Diana's lending loans
                    Rating = 5,
                    Comment = "Perfect transaction! Highly recommended.",
                    ConditionAsDescribed = true,
                    CommunicationGood = true,
                    MeetupExperience = true,
                    DateSubmitted = DateTime.UtcNow.AddMonths(-(20 - i)).AddDays(14)
                });
            }

            // Reviews BY User 3 (Marcus) - Marcus reviewing others
            for (int i = 0; i < 21; i++)
            {
                int reviewedUserId = (i % 5) + 1 == 3 ? 6 : (i % 5) + 1;
                int rating = i % 6 == 0 ? 4 : 5;

                reviews.Add(new Review
                {
                    Id = reviewId++,
                    ReviewerId = 3, // Marcus is the reviewer
                    ReviewedUserId = reviewedUserId,
                    LoanId = 64 + i, // Marcus's borrowing loans
                    Rating = rating,
                    Comment = rating == 5 ? "Amazing collection! Very knowledgeable." : "Great lender, minor delay but good communication.",
                    ConditionAsDescribed = true,
                    CommunicationGood = rating == 5,
                    MeetupExperience = true,
                    DateSubmitted = DateTime.UtcNow.AddMonths(-(21 - (i / 2))).AddDays(14)
                });
            }

            // Reviews FOR User 3 (Marcus) - Others reviewing Marcus
            for (int i = 0; i < 21; i++)
            {
                int reviewerId = (i % 5) + 1 == 3 ? 6 : (i % 5) + 1;
                int rating = i % 6 == 0 ? 4 : 5;

                reviews.Add(new Review
                {
                    Id = reviewId++,
                    ReviewerId = reviewerId,
                    ReviewedUserId = 3, // Reviewing Marcus
                    LoanId = 43 + i, // Marcus's lending loans
                    Rating = rating,
                    Comment = rating == 5 ? "Amazing X-Men collection! Very knowledgeable." : "Good lender, recommended.",
                    ConditionAsDescribed = true,
                    CommunicationGood = rating == 5,
                    MeetupExperience = true,
                    DateSubmitted = DateTime.UtcNow.AddMonths(-(22 - (i / 2))).AddDays(14)
                });
            }

            // Reviews BY User 4 (Daniel) - Daniel reviewing others
            for (int i = 0; i < 15; i++)
            {
                int reviewedUserId = (i % 5) + 1 == 4 ? 6 : (i % 5) + 1;
                int rating = i % 10 == 0 ? 4 : 5;

                reviews.Add(new Review
                {
                    Id = reviewId++,
                    ReviewerId = 4, // Daniel is the reviewer
                    ReviewedUserId = reviewedUserId,
                    LoanId = 101 + i, // Daniel's borrowing loans
                    Rating = rating,
                    Comment = rating == 5 ? "Fantastic collection! Highly recommend." : "Good experience overall.",
                    ConditionAsDescribed = true,
                    CommunicationGood = true,
                    MeetupExperience = true,
                    DateSubmitted = DateTime.UtcNow.AddMonths(-(17 - (i / 2))).AddDays(14)
                });
            }

            // Reviews FOR User 4 (Daniel) - Others reviewing Daniel
            for (int i = 0; i < 16; i++)
            {
                int reviewerId = (i % 5) + 1 == 4 ? 6 : (i % 5) + 1;
                int rating = i % 10 == 0 ? 4 : 5;

                reviews.Add(new Review
                {
                    Id = reviewId++,
                    ReviewerId = reviewerId,
                    ReviewedUserId = 4, // Reviewing Daniel
                    LoanId = 85 + i, // Daniel's lending loans
                    Rating = rating,
                    Comment = rating == 5 ? "Fantastic DC collection! Highly recommend." : "Good experience overall.",
                    ConditionAsDescribed = true,
                    CommunicationGood = true,
                    MeetupExperience = true,
                    DateSubmitted = DateTime.UtcNow.AddMonths(-(18 - (i / 2))).AddDays(14)
                });
            }

            // Reviews BY User 5 (Sarah) - Sarah reviewing others
            // Borrowing loans (124-130) - already handled above
            for (int i = 0; i < 7; i++)
            {
                int reviewedUserId = (i % 4) + 1;
                int rating = i % 3 == 0 ? 4 : 5;

                reviews.Add(new Review
                {
                    Id = reviewId++,
                    ReviewerId = 5, // Sarah is the reviewer
                    ReviewedUserId = reviewedUserId,
                    LoanId = 124 + i, // Sarah's borrowing loans
                    Rating = rating,
                    Comment = rating == 5 ? "Great collection! Love the variety." : "Good lender, comics as described.",
                    ConditionAsDescribed = true,
                    CommunicationGood = true,
                    MeetupExperience = rating == 5,
                    DateSubmitted = DateTime.UtcNow.AddMonths(-(15 - i)).AddDays(14)
                });
            }

            // Reviews BY User 5 for LENDING loans (116-123) - reviewing the borrowers
            for (int i = 0; i < 8; i++)
            {
                int reviewedUserId = (i % 4) + 1; // Users 1-4
                int rating = i % 3 == 0 ? 4 : 5;

                reviews.Add(new Review
                {
                    Id = reviewId++,
                    ReviewerId = 5, // Sarah is the reviewer
                    ReviewedUserId = reviewedUserId, // Reviewing the borrowers
                    LoanId = 116 + i, // Sarah's LENDING loans
                    Rating = rating,
                    Comment = rating == 5 ? "Great borrower! Took excellent care of the comic." : "Good borrower, returned on time.",
                    ConditionAsDescribed = true,
                    CommunicationGood = true,
                    MeetupExperience = rating == 5,
                    DateSubmitted = DateTime.UtcNow.AddMonths(-(16 - i)).AddDays(14)
                });
            }

            // Reviews BY User 6 (Henry) - Henry reviewing others
            for (int i = 0; i < 11; i++)
            {
                int reviewedUserId = (i % 5) + 1;
                int rating = i % 6 == 0 ? 4 : 5;

                reviews.Add(new Review
                {
                    Id = reviewId++,
                    ReviewerId = 6, // Henry is the reviewer
                    ReviewedUserId = reviewedUserId,
                    LoanId = 142 + i, // Henry's borrowing loans
                    Rating = rating,
                    Comment = rating == 5 ? "Excellent collection! Very punctual." : "Great experience, would borrow again.",
                    ConditionAsDescribed = true,
                    CommunicationGood = true,
                    MeetupExperience = true,
                    DateSubmitted = DateTime.UtcNow.AddMonths(-(13 - (i / 2))).AddDays(14)
                });
            }

            // Reviews FOR User 6 (Henry) - Others reviewing Henry
            for (int i = 0; i < 11; i++)
            {
                int reviewerId = (i % 5) + 1;
                int rating = i % 6 == 0 ? 4 : 5;

                reviews.Add(new Review
                {
                    Id = reviewId++,
                    ReviewerId = reviewerId,
                    ReviewedUserId = 6, // Reviewing Henry
                    LoanId = 131 + i, // Henry's lending loans
                    Rating = rating,
                    Comment = rating == 5 ? "Excellent horror collection! Very punctual." : "Great experience, would lend again.",
                    ConditionAsDescribed = true,
                    CommunicationGood = true,
                    MeetupExperience = true,
                    DateSubmitted = DateTime.UtcNow.AddMonths(-(14 - (i / 2))).AddDays(14)
                });
            }

            return reviews;
        }

        private static List<Message> GetSeedMessages()
        {
            var now = DateTime.UtcNow;
            return new List<Message>
    {
        // Conversation 1: Diana (vertigo_veteran) and Henry (horror_comics_hank) - Preacher trade
        new Message
        {
            Id = 1,
            SenderId = 2, // vertigo_veteran
            ReceiverId = 6, // horror_comics_hank
            Subject = "Borrow request: Preacher #1",
            Content = "Hi Henry, I saw your horror collection and wondered if you'd be open to a trade sometime. Also, I noticed you might enjoy 'Preacher #1'—happy to lend if interested.",
            SentDate = now.AddDays(-14),
            IsRead = true
        },
        new Message
        {
            Id = 2,
            SenderId = 6, // horror_comics_hank
            ReceiverId = 2, // vertigo_veteran
            Subject = "Re: Borrow request: Preacher #1",
            Content = "Thanks, Diana! I'd love to borrow it for two weeks. We can meet in Malmö or Lund—whatever suits you. I've been wanting to read Preacher for years!",
            SentDate = now.AddDays(-13),
            IsRead = true
        },
        new Message
        {
            Id = 3,
            SenderId = 2, // vertigo_veteran
            ReceiverId = 6, // horror_comics_hank
            Subject = "Re: Borrow request: Preacher #1",
            Content = "Perfect! How about we meet at Malmö C on Saturday around 2pm? I can bring the first arc (issues 1-7). In return, could I borrow some of your Tomb of Dracula run?",
            SentDate = now.AddDays(-12),
            IsRead = true
        },
        new Message
        {
            Id = 4,
            SenderId = 6, // horror_comics_hank
            ReceiverId = 2, // vertigo_veteran
            Subject = "Re: Borrow request: Preacher #1",
            Content = "Saturday at 2pm works great! I'll bring Tomb of Dracula #1-10. The Gene Colan artwork is phenomenal. See you at the station entrance!",
            SentDate = now.AddDays(-11),
            IsRead = true
        },

        // Conversation 2: Robert (bronze_age_bob) and Marcus (xmen_completist) - Spider-Man/X-Men trade
        new Message
        {
            Id = 5,
            SenderId = 1, // bronze_age_bob
            ReceiverId = 3, // xmen_completist
            Subject = "Trade idea: Spider-Man for X-Men",
            Content = "Marcus, would you be up for swapping 'ASM #129' for a short read of 'Uncanny X-Men #129'? Both first appearances - Punisher vs Kitty Pryde!",
            SentDate = now.AddDays(-10),
            IsRead = true
        },
        new Message
        {
            Id = 6,
            SenderId = 3, // xmen_completist
            ReceiverId = 1, // bronze_age_bob
            Subject = "Re: Trade idea: Spider-Man for X-Men",
            Content = "Robert! That's a great matchup. I'd love to read the first Punisher appearance. X-Men #129 is in great condition - the Dark Phoenix Saga is heating up at that point. Two week loan work for you?",
            SentDate = now.AddDays(-9),
            IsRead = true
        },
        new Message
        {
            Id = 7,
            SenderId = 1, // bronze_age_bob
            ReceiverId = 3, // xmen_completist
            Subject = "Re: Trade idea: Spider-Man for X-Men",
            Content = "Two weeks is perfect! I'm in central Malmö most weekdays. Could we meet at Triangeln shopping center? Maybe Tuesday evening?",
            SentDate = now.AddDays(-8),
            IsRead = true
        },

        // Conversation 3: Daniel (classic_dc_dan) and Robert (bronze_age_bob) - Batman discussion
        new Message
        {
            Id = 8,
            SenderId = 4, // classic_dc_dan
            ReceiverId = 1, // bronze_age_bob
            Subject = "O'Neil/Adams Batman - interested?",
            Content = "Hey Robert! Saw you're into Bronze Age Marvel. Ever venture into the DC side? I have the complete O'Neil/Adams Batman run and it's incredible. The art alone is worth the read.",
            SentDate = now.AddDays(-7),
            IsRead = true
        },
        new Message
        {
            Id = 9,
            SenderId = 1, // bronze_age_bob
            ReceiverId = 4, // classic_dc_dan
            Subject = "Re: O'Neil/Adams Batman - interested?",
            Content = "Daniel! I've heard so much about those issues. I'd absolutely love to borrow them. I'm mostly Marvel but those Batman stories are legendary. What would you want in return?",
            SentDate = now.AddDays(-6),
            IsRead = true
        },
        new Message
        {
            Id = 10,
            SenderId = 4, // classic_dc_dan
            ReceiverId = 1, // bronze_age_bob
            Subject = "Re: O'Neil/Adams Batman - interested?",
            Content = "No trade needed! Just happy to share them. I have Batman #227, 234, 251 and the Detective Comics run. How about you start with the Joker's Five-Way Revenge (Batman #251)? We're both in Malmö so meeting up is easy.",
            SentDate = now.AddDays(-5),
            IsRead = true
        },

        // Conversation 4: Sarah (indie_origins) and Diana (vertigo_veteran) - Independent comics
        new Message
        {
            Id = 11,
            SenderId = 5, // indie_origins
            ReceiverId = 2, // vertigo_veteran
            Subject = "Vertigo roots in indie comics",
            Content = "Diana, as a fellow Lund resident and Vertigo fan, I thought you might be interested in some of the indie books that influenced the Vertigo line. I have early Swamp Thing (pre-Moore) and some American Flagg that shows the mature comics evolution.",
            SentDate = now.AddDays(-5),
            IsRead = true
        },
        new Message
        {
            Id = 12,
            SenderId = 2, // vertigo_veteran
            ReceiverId = 5, // indie_origins
            Subject = "Re: Vertigo roots in indie comics",
            Content = "Sarah! I'd LOVE to read those. I've mostly focused on the mature Vertigo era but understanding the roots would be fascinating. American Flagg is on my wish list. Can I borrow a few issues?",
            SentDate = now.AddDays(-4),
            IsRead = true
        },
        new Message
        {
            Id = 13,
            SenderId = 5, // indie_origins
            ReceiverId = 2, // vertigo_veteran
            Subject = "Re: Vertigo roots in indie comics",
            Content = "Absolutely! I'll bring American Flagg #1-4 and Swamp Thing #1-10 (Len Wein era). You'll see Moore's blueprint was already there. Coffee at Lund C this week?",
            SentDate = now.AddDays(-3),
            IsRead = false
        },

        // Conversation 5: Marcus (xmen_completist) and Daniel (classic_dc_dan) - Cross-publisher discussion
        new Message
        {
            Id = 14,
            SenderId = 3, // xmen_completist
            ReceiverId = 4, // classic_dc_dan
            Subject = "Marvel vs DC Bronze Age question",
            Content = "Daniel, I noticed you're heavily into Bronze Age DC. I'm purely Marvel (X-Men obsessed!). What DC titles from that era would you recommend to a Marvel zombie like me?",
            SentDate = now.AddDays(-8),
            IsRead = true
        },
        new Message
        {
            Id = 15,
            SenderId = 4, // classic_dc_dan
            ReceiverId = 3, // xmen_completist
            Subject = "Re: Marvel vs DC Bronze Age question",
            Content = "Marcus! Great question. If you love Claremont's character development, you'll love the O'Neil/Adams Green Lantern/Green Arrow run. Social issues + superhero action. Also New Teen Titans by Wolfman/Pérez - it's DC's X-Men basically!",
            SentDate = now.AddDays(-7),
            IsRead = true
        },
        new Message
        {
            Id = 16,
            SenderId = 3, // xmen_completist
            ReceiverId = 4, // classic_dc_dan
            Subject = "Re: Marvel vs DC Bronze Age question",
            Content = "I've heard amazing things about New Teen Titans! Would you be willing to lend some issues? I can trade some X-Men in return - maybe the first Rogue appearance or Days of Future Past?",
            SentDate = now.AddDays(-6),
            IsRead = false
        },

        // Conversation 6: Henry (horror_comics_hank) and Robert (bronze_age_bob) - Horror Marvel
        new Message
        {
            Id = 17,
            SenderId = 6, // horror_comics_hank
            ReceiverId = 1, // bronze_age_bob
            Subject = "Marvel's horror line - Bronze Age crossover",
            Content = "Hey Robert! Saw you're into Bronze Age Marvel. Did you collect any of the horror titles? Tomb of Dracula, Werewolf by Night, Man-Thing? They're amazing Bronze Age stories but often overlooked.",
            SentDate = now.AddDays(-4),
            IsRead = true
        },
        new Message
        {
            Id = 18,
            SenderId = 1, // bronze_age_bob
            ReceiverId = 6, // horror_comics_hank
            Subject = "Re: Marvel's horror line - Bronze Age crossover",
            Content = "Henry! I've been curious about Tomb of Dracula but never jumped in. I know Blade first appeared there. Would love to borrow some issues if you're willing to share!",
            SentDate = now.AddDays(-3),
            IsRead = true
        },
        new Message
        {
            Id = 19,
            SenderId = 6, // horror_comics_hank
            ReceiverId = 1, // bronze_age_bob
            Subject = "Re: Marvel's horror line - Bronze Age crossover",
            Content = "Perfect timing! Tomb of Dracula #10 (first Blade) and #1-5 to get the full story. Gene Colan's art is stunning. We're both in Malmö - Möllevången for coffee exchange this weekend?",
            SentDate = now.AddDays(-2),
            IsRead = false
        },

        // Conversation 7: Sarah (indie_origins) and Marcus (xmen_completist) - TMNT
        new Message
        {
            Id = 20,
            SenderId = 5, // indie_origins
            ReceiverId = 3, // xmen_completist
            Subject = "TMNT origin - X-Men connection",
            Content = "Marcus! You collect X-Men, so you might find this interesting - the original TMNT comics are a parody of X-Men and Daredevil. The ooze that creates them is from the same accident that created Daredevil. I have the original Mirage issues if you want to see where it started!",
            SentDate = now.AddDays(-6),
            IsRead = true
        },
        new Message
        {
            Id = 21,
            SenderId = 3, // xmen_completist
            ReceiverId = 5, // indie_origins
            Subject = "Re: TMNT origin - X-Men connection",
            Content = "Sarah, I had NO idea about the X-Men parody angle! I only know TMNT from the cartoon. Would love to read the original black and white comics. The gritty original must be so different from the kids' version.",
            SentDate = now.AddDays(-5),
            IsRead = true
        },
        new Message
        {
            Id = 22,
            SenderId = 5, // indie_origins
            ReceiverId = 3, // xmen_completist
            Subject = "Re: TMNT origin - X-Men connection",
            Content = "It's night and day! The original is dark, violent, and brilliant. I'll bring TMNT #1-4 (first printings). The Shredder story is brutal. Can we meet halfway between Lund and Helsingborg? Maybe Landskrona?",
            SentDate = now.AddDays(-4),
            IsRead = false
        },

        // Conversation 8: Diana (vertigo_veteran) and Daniel (classic_dc_dan) - Swamp Thing evolution
        new Message
        {
            Id = 23,
            SenderId = 2, // vertigo_veteran
            ReceiverId = 4, // classic_dc_dan
            Subject = "Swamp Thing pre-Moore issues",
            Content = "Daniel, I'm a huge Alan Moore Swamp Thing fan. Do you have any of the pre-Moore issues? I'd love to see how Wein originally handled the character before Moore revolutionized it.",
            SentDate = now.AddDays(-3),
            IsRead = true
        },
        new Message
        {
            Id = 24,
            SenderId = 4, // classic_dc_dan
            ReceiverId = 2, // vertigo_veteran
            Subject = "Re: Swamp Thing pre-Moore issues",
            Content = "Diana! I have the Wein/Wrightson run - the original 10 issues are gorgeous. Wrightson's art is incredible. You'll see Moore built on a strong foundation. The 'Anatomy Lesson' wouldn't hit as hard without Wein's setup.",
            SentDate = now.AddDays(-2),
            IsRead = true
        },
        new Message
        {
            Id = 25,
            SenderId = 2, // vertigo_veteran
            ReceiverId = 4, // classic_dc_dan
            Subject = "Re: Swamp Thing pre-Moore issues",
            Content = "Yes! I need to read those. The Wrightson art alone is worth it. Could we arrange a trade? I have some later Vertigo titles you might not have read - Hellblazer, Sandman Mystery Theatre?",
            SentDate = now.AddDays(-1),
            IsRead = false
        },

        // Conversation 9: Robert (bronze_age_bob) and Sarah (indie_origins) - Underground influence
        new Message
        {
            Id = 26,
            SenderId = 1, // bronze_age_bob
            ReceiverId = 5, // indie_origins
            Subject = "Bronze Age indie crossover?",
            Content = "Sarah, I'm purely superhero Marvel but I keep hearing about how underground and indie comics influenced the mainstream. What should I read to understand that evolution?",
            SentDate = now.AddDays(-5),
            IsRead = true
        },
        new Message
        {
            Id = 27,
            SenderId = 5, // indie_origins
            ReceiverId = 1, // bronze_age_bob
            Subject = "Re: Bronze Age indie crossover?",
            Content = "Robert! Start with Cerebus - it begins as Conan parody but becomes something much deeper. Also American Flagg and the early TMNT. These showed creators they could own their work and tell mature stories. Happy to lend!",
            SentDate = now.AddDays(-4),
            IsRead = true
        },

        // Conversation 10: Henry (horror_comics_hank) and Marcus (xmen_completist) - Crossovers
        new Message
        {
            Id = 28,
            SenderId = 6, // horror_comics_hank
            ReceiverId = 3, // xmen_completist
            Subject = "X-Men horror crossovers",
            Content = "Marcus! Did you collect any of the X-Men/Dracula crossovers? Uncanny X-Men #159 with Dracula is one of my favorite issues. The horror/superhero mix works so well!",
            SentDate = now.AddDays(-2),
            IsRead = true
        },
        new Message
        {
            Id = 29,
            SenderId = 3, // xmen_completist
            ReceiverId = 6, // horror_comics_hank
            Subject = "Re: X-Men horror crossovers",
            Content = "Henry! I have that issue - it's brilliant! Storm vs Dracula is epic. Have you read the earlier X-Men #30s where they fight vampires? I could lend those if you want to see the first vampire encounters.",
            SentDate = now.AddDays(-1),
            IsRead = false
        },

        // Conversation 11: Daniel (classic_dc_dan) and Sarah (indie_origins) - Political comics
        new Message
        {
            Id = 30,
            SenderId = 4, // classic_dc_dan
            ReceiverId = 5, // indie_origins
            Subject = "Socially conscious comics",
            Content = "Sarah, I focus on the O'Neil/Adams social commentary era of DC. I know indie comics tackled even more controversial topics. What should I read to see how far underground comics pushed boundaries?",
            SentDate = now.AddDays(-3),
            IsRead = true
        },
        new Message
        {
            Id = 31,
            SenderId = 5, // indie_origins
            ReceiverId = 4, // classic_dc_dan
            Subject = "Re: Socially conscious comics",
            Content = "Daniel! You'd appreciate Howard Chaykin's American Flagg - it's political satire with gorgeous art. Also some of the underground comix dealt with topics DC couldn't touch in the 70s. I can create a curated reading list for you!",
            SentDate = now.AddDays(-2),
            IsRead = false
        },

        // Conversation 12: Marcus (xmen_completist) and Diana (vertigo_veteran)
        new Message
        {
            Id = 32,
            SenderId = 3, // xmen_completist
            ReceiverId = 2, // vertigo_veteran
            Subject = "Question about mature comics evolution",
            Content = "Diana, when did comics really 'grow up'? I know X-Men got darker with Claremont, but Vertigo seems like a different level. What's the connection between 80s Marvel and mature Vertigo?",
            SentDate = now.AddDays(-4),
            IsRead = true
        },
        new Message
        {
            Id = 33,
            SenderId = 2, // vertigo_veteran
            ReceiverId = 3, // xmen_completist
            Subject = "Re: Question about mature comics evolution",
            Content = "Marcus! Great question. Moore's Swamp Thing and Watchmen in the mid-80s opened the door. X-Men was getting mature but still had Comics Code restrictions. Vertigo let creators tell truly adult stories. I'd recommend reading Dark Knight Returns and Watchmen to see the shift!",
            SentDate = now.AddDays(-3),
            IsRead = false
        },

        // Conversation 13: All users - Group interest message
        new Message
        {
            Id = 34,
            SenderId = 1, // bronze_age_bob
            ReceiverId = 2, // vertigo_veteran
            Subject = "Lending library meetup idea?",
            Content = "Diana, I've been trading with several people in the group. Think we should organize a Malmö/Lund comic swap meetup? Could be fun to all meet in person and swap recommendations!",
            SentDate = now.AddDays(-1),
            IsRead = false
        },

        // Conversation 14: Recent inquiry
        new Message
        {
            Id = 35,
            SenderId = 4, // classic_dc_dan
            ReceiverId = 6, // horror_comics_hank
            Subject = "Batman/horror crossover",
            Content = "Henry! Just realized we're both in Malmö and never connected. I have some Batman horror stories (Man-Bat, early Scarecrow) that might interest you. Want to trade for some of your horror collection?",
            SentDate = now.AddHours(-12),
            IsRead = false
        },

        // Conversation 15: Sarah reaching out to Henry
        new Message
        {
            Id = 36,
            SenderId = 5, // indie_origins
            ReceiverId = 6, // horror_comics_hank
            Subject = "Swamp Thing - indie to mainstream",
            Content = "Henry, Swamp Thing is fascinating because it bridges indie sensibilities with mainstream DC. I have some of the Wein issues and would love to compare notes with your collection. Trade?",
            SentDate = now.AddHours(-6),
            IsRead = false
        }
        };
        }

        private static List<Announcement> GetSeedAnnouncements()
        {
            var now = DateTime.UtcNow;
            return new List<Announcement>
            {
                new Announcement
                {
                    Id = 1,
                    Title = "Welcome to Comic Books Loan Exchange! 📚",
                    Content = "We're excited to launch this platform connecting comic book collectors across Skåne. Our community is built on trust, shared passion, and the joy of discovering great stories. Start by browsing available comics or listing your own collection!",
                    Type = AnnouncementType.General,
                    CreatedByUserId = 6, // Admin user
                    CreatedAt = now.AddDays(-30),
                    IsActive = true
                },
                new Announcement
                {
                    Id = 2,
                    Title = "New Feature: Review System Live! ⭐",
                    Content = "You can now leave reviews after completing loans! Help build trust in our community by sharing your experiences as both a lender and borrower. Great reviews help everyone make informed decisions about who to lend to.",
                    Type = AnnouncementType.Feature,
                    CreatedByUserId = 6, // Admin user
                    CreatedAt = now.AddDays(-15),
                    IsActive = true
                },
                new Announcement
                {
                    Id = 3,
                    Title = "Meetup Guidelines Updated 📍",
                    Content = "For everyone's safety, we recommend meeting in public places like cafes, libraries, or comic book shops. Popular spots in Malmö include Stortorget, Malmö Library, and Central Station. Always verify identity and inspect comics during the handoff.",
                    Type = AnnouncementType.Update,
                    CreatedByUserId = 6, // Admin user
                    CreatedAt = now.AddDays(-7),
                    IsActive = true
                },
                new Announcement
                {
                    Id = 4,
                    Title = "Growing Community: 100+ Comics Available! 🎉",
                    Content = "Our lending library has reached over 100 comics available for loan! From Bronze Age classics to modern indie titles, there's something for everyone. Thank you to all our collectors for sharing their passion.",
                    Type = AnnouncementType.Event,
                    CreatedByUserId = 6, // Admin user
                    CreatedAt = now.AddDays(-3),
                    IsActive = true
                },
                new Announcement
                {
                    Id = 5,
                    Title = "Tips for New Members 💡",
                    Content = "New to comic lending? Start small! Request a shorter loan period for your first exchanges to build trust. Always communicate clearly about condition expectations, and don't hesitate to use our messaging system to coordinate meetups.",
                    Type = AnnouncementType.General,
                    CreatedByUserId = 6, // Admin user
                    CreatedAt = now.AddHours(-12),
                    IsActive = true
                }
            };
        }

        /// <summary>
        /// Hashes a password using PBKDF2 with SHA256 (matching AuthenticationService).
        /// In production, use proper hashing like BCrypt or Argon2.
        /// </summary>
        private static string HashPassword(string password)
        {
            byte[] salt = new byte[20];
            // Use a fixed salt for seeded users so hashes are consistent across migrations
            var fixedSalt = System.Text.Encoding.UTF8.GetBytes("ComicBooksSeedSalt20");
            Array.Copy(fixedSalt, salt, Math.Min(fixedSalt.Length, 20));

            using (var pdb = new System.Security.Cryptography.Rfc2898DeriveBytes(
                password, salt, 10000, System.Security.Cryptography.HashAlgorithmName.SHA256))
            {
                byte[] key = pdb.GetBytes(20);

                // Combine salt and hashed password
                byte[] hashBytes = new byte[40];
                Array.Copy(salt, 0, hashBytes, 0, 20);
                Array.Copy(key, 0, hashBytes, 20, 20);

                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
