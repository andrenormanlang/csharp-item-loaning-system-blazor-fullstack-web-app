using ComicBooksExchangeAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ComicBooksExchangeAppAPI.Data
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
        /// Seeds the database with initial data.
        /// </summary>
        public static void SeedDatabase(ModelBuilder modelBuilder)
        {
            // Seed Users
            var users = GetSampleUsers();
            modelBuilder.Entity<User>().HasData(users);

            // Seed Comics
            var comics = GetSampleComics();
            modelBuilder.Entity<Comic>().HasData(comics);
        }

        private static List<User> GetSampleUsers()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    Username = "bronze_age_bob",
                    FullName = "Robert Mitchell",
                    Email = "robert@example.com",
                    PreferredEras = "Bronze Age, Copper Age",
                    FavoriteCharacters = "Spider-Man, X-Men, Teen Titans, Swamp Thing",
                    Biography = "Started reading comics in 1975. Took a break in the 90s and just getting back into it. Love sharing the classics I grew up with through this lending library.",
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
                    PreferredEras = "Copper Age, Modern Age",
                    FavoriteCharacters = "Sandman, Swamp Thing, Hellblazer, Preacher",
                    Biography = "Former bookstore owner. Passionate about mature, literary comics. The Vertigo line changed everything for me.",
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
                    PreferredEras = "Bronze Age, Copper Age",
                    FavoriteCharacters = "X-Men, Wolverine, Storm, Nightcrawler",
                    Biography = "Have been collecting X-Men since Claremont took over. Own nearly every issue from Giant-Size #1 through the 90s. Happy to share the classics!",
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
                    PreferredEras = "Bronze Age",
                    FavoriteCharacters = "Batman, Green Lantern, Green Arrow, Teen Titans",
                    Biography = "Grew up on O'Neil/Adams Batman and the classic Teen Titans. Still think the 70s-80s were the golden era of DC storytelling.",
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
                    PreferredEras = "Bronze Age, Copper Age",
                    FavoriteCharacters = "Cerebus, TMNT, Elfquest, American Flagg",
                    Biography = "Was there when the indie revolution started. Own runs of many titles that launched careers. Love sharing these overlooked gems.",
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
                    PreferredEras = "Bronze Age, Copper Age",
                    FavoriteCharacters = "Swamp Thing, Man-Thing, Ghost Rider, Tomb of Dracula",
                    Biography = "Been reading horror comics since the 70s revival. Have extensive runs of Tomb of Dracula, Swamp Thing, and more.",
                    SuccessfulLoans = 22,
                    AverageRating = 4.8m,
                    MemberSince = new DateTime(2023, 4, 12),
                    IsVerified = true,
                    ImageUrl = "https://i.pravatar.cc/150?img=51",
                    PasswordHash = HashPassword("Comics123!")
                }
            };
        }

        private static List<Comic> GetSampleComics()
        {
            return new List<Comic>
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
                    DateListed = new DateTime(2025, 1, 21, 0, 0, 0, DateTimeKind.Utc),
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
