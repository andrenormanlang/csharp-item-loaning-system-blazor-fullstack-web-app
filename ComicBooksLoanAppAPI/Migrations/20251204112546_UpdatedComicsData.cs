using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComicBooksLoanAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedComicsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReadingFocus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferredEras = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FavoriteCharacters = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuccessfulLoans = table.Column<int>(type: "int", nullable: false),
                    AverageRating = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    MemberSince = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    PreferredDeliveryMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LendingPreferences = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IssueNumber = table.Column<int>(type: "int", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Characters = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Era = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ConditionGrade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ConditionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    IsOnLoan = table.Column<bool>(type: "bit", nullable: false),
                    CurrentLoanId = table.Column<int>(type: "int", nullable: true),
                    LoanReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateListed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OwnerNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comics_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    ReceiverId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    SentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Subject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Users_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoanRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequesterId = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    RequestedComicId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RequestedLoanDurationDays = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ShippingMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WithInsurance = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateResponded = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResponseMessage = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanRequests_Comics_RequestedComicId",
                        column: x => x.RequestedComicId,
                        principalTable: "Comics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoanRequests_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoanRequests_Users_RequesterId",
                        column: x => x.RequesterId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BorrowerId = table.Column<int>(type: "int", nullable: false),
                    LenderId = table.Column<int>(type: "int", nullable: false),
                    ComicId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoanStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LoanEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LoanDurationDays = table.Column<int>(type: "int", nullable: false),
                    BorrowerNotes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    LenderNotes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    BorrowerReceivedComic = table.Column<bool>(type: "bit", nullable: false),
                    LenderConfirmedReturn = table.Column<bool>(type: "bit", nullable: false),
                    ShippingMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OutboundTrackingNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReturnTrackingNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LoanRequestId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loans_Comics_ComicId",
                        column: x => x.ComicId,
                        principalTable: "Comics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Loans_LoanRequests_LoanRequestId",
                        column: x => x.LoanRequestId,
                        principalTable: "LoanRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Loans_Users_BorrowerId",
                        column: x => x.BorrowerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Loans_Users_LenderId",
                        column: x => x.LenderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewerId = table.Column<int>(type: "int", nullable: false),
                    ReviewedUserId = table.Column<int>(type: "int", nullable: false),
                    LoanId = table.Column<int>(type: "int", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DateSubmitted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConditionAsDescribed = table.Column<bool>(type: "bit", nullable: false),
                    CommunicationRating = table.Column<bool>(type: "bit", nullable: false),
                    ShippingPackagingRating = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Loans_LoanId",
                        column: x => x.LoanId,
                        principalTable: "Loans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_ReviewedUserId",
                        column: x => x.ReviewedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_ReviewerId",
                        column: x => x.ReviewerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AverageRating", "Biography", "ReadingFocus", "Email", "FavoriteCharacters", "FullName", "ImageUrl", "IsVerified", "Location", "MemberSince", "PasswordHash", "PhoneNumber", "PreferredEras", "PreferredDeliveryMethod", "SuccessfulLoans", "LendingPreferences", "Username" },
                values: new object[,]
                {
                    { 1, 4.9m, "Started reading comics in 1975. Took a break in the 90s and just getting back into it. Love sharing the classics I grew up with through this lending library.", "Bronze Age Marvel & DC", "robert@example.com", "Spider-Man, X-Men, Teen Titans, Swamp Thing", "Robert Mitchell", "https://i.pravatar.cc/150?img=12", true, "Cleveland, OH", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Q29taWNCb29rc1NlZWRTYWx0MjCYN7lr3RVs0TBC7ml19bRSCkbAKg==", "555-0101", "Bronze Age, Copper Age", "Mail with Insurance", 24, "Handle with care! These books mean a lot to me. Prefer lending to established members.", "bronze_age_bob" },
                    { 2, 5.0m, "Former bookstore owner. Passionate about mature, literary comics. The Vertigo line changed everything for me.", "Vertigo & Mature Readers", "diana@example.com", "Sandman, Swamp Thing, Hellblazer, Preacher", "Diana Chen", "https://i.pravatar.cc/150?img=47", true, "Portland, OR", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Q29taWNCb29rc1NlZWRTYWx0MjCYN7lr3RVs0TBC7ml19bRSCkbAKg==", "555-0102", "Copper Age, Modern Age", "Mail with Insurance", 18, "Love introducing new readers to quality mature comics. Please respect the condition.", "vertigo_veteran" },
                    { 3, 4.8m, "Have been collecting X-Men since Claremont took over. Own nearly every issue from Giant-Size #1 through the 90s. Happy to share the classics!", "Complete X-Men Runs", "marcus@example.com", "X-Men, Wolverine, Storm, Nightcrawler", "Marcus Williams", "https://i.pravatar.cc/150?img=33", true, "Atlanta, GA", new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Q29taWNCb29rc1NlZWRTYWx0MjCYN7lr3RVs0TBC7ml19bRSCkbAKg==", "555-0103", "Bronze Age, Copper Age", "Mail with Insurance", 42, "Claremont era is my specialty. Will lend full story arcs when possible.", "xmen_completist" },
                    { 4, 4.9m, "Grew up on O'Neil/Adams Batman and the classic Teen Titans. Still think the 70s-80s were the golden era of DC storytelling.", "Classic DC Bronze Age", "daniel@example.com", "Batman, Green Lantern, Green Arrow, Teen Titans", "Daniel Torres", "https://i.pravatar.cc/150?img=15", true, "Phoenix, AZ", new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Q29taWNCb29rc1NlZWRTYWx0MjCYN7lr3RVs0TBC7ml19bRSCkbAKg==", "555-0104", "Bronze Age", "Mail", 31, "Big on sharing Wolfman/Perez Titans and Adams-era Batman. Careful shipping always.", "classic_dc_dan" },
                    { 5, 4.7m, "Was there when the indie revolution started. Own runs of many titles that launched careers. Love sharing these overlooked gems.", "Early Independent Comics", "sarah@example.com", "Cerebus, TMNT, Elfquest, American Flagg", "Sarah McKenzie", "https://i.pravatar.cc/150?img=29", true, "Austin, TX", new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Q29taWNCb29rc1NlZWRTYWx0MjCYN7lr3RVs0TBC7ml19bRSCkbAKg==", "555-0105", "Bronze Age, Copper Age", "Mail with Insurance", 15, "Focus on forgotten indies that deserve more attention. Happy to recommend starting points.", "indie_origins" },
                    { 6, 4.8m, "Been reading horror comics since the 70s revival. Have extensive runs of Tomb of Dracula, Swamp Thing, and more.", "Horror Comics & Epic Magazine", "henry@example.com", "Swamp Thing, Man-Thing, Ghost Rider, Tomb of Dracula", "Henry Patterson", "https://i.pravatar.cc/150?img=51", true, "Boston, MA", new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Q29taWNCb29rc1NlZWRTYWx0MjCYN7lr3RVs0TBC7ml19bRSCkbAKg==", "555-0106", "Bronze Age, Copper Age", "Mail", 22, "Horror fans unite! These are mature comics - please be aware of content.", "horror_comics_hank" }
                });

            migrationBuilder.InsertData(
                table: "Comics",
                columns: new[] { "Id", "Characters", "ConditionDescription", "ConditionGrade", "CoverImageUrl", "CurrentLoanId", "DateListed", "Description", "Era", "Genre", "IsAvailable", "IsOnLoan", "IssueNumber", "LoanReturnDate", "OwnerId", "OwnerNotes", "PublicationDate", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "Spider-Man, Punisher, Jackal", "Slight spine stress, bright colors. Classic issue.", "Very Fine", "https://cdn.marvel.com/u/prod/marvel/i/mg/e/b0/57b7694649690/clean.jpg", null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "First appearance of the Punisher. One of the most significant Bronze Age issues.", "Bronze Age", "Superhero", true, false, 129, null, 1, "Handle with care - this is a key issue.", new DateTime(1974, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel", "The Amazing Spider-Man" },
                    { 2, "Spider-Man, Green Goblin, Gwen Stacy", "Minor wear, complete story. Historic issue.", "Fine", "https://cdn.marvel.com/u/prod/marvel/i/mg/a/00/57b71f662fdc8/clean.jpg", null, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), "The Night Gwen Stacy Died. The comic that changed everything about superhero storytelling.", "Bronze Age", "Superhero", true, false, 121, null, 1, "One of the most important comics ever published. Read with tissues.", new DateTime(1973, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel", "The Amazing Spider-Man" },
                    { 3, "Hulk, Wolverine, Wendigo", "Some spine wear, complete with MVS stamp.", "Very Good", "https://cdn.marvel.com/u/prod/marvel/i/mg/9/d0/5c93f5a6e62b7/clean.jpg", null, new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Utc), "First full appearance of Wolverine. The Bronze Age key issue.", "Bronze Age", "Superhero", true, false, 181, null, 1, "The book that launched Wolverine! MVS intact.", new DateTime(1974, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel", "Incredible Hulk" },
                    { 4, "X-Men, Storm, Wolverine, Colossus, Nightcrawler", "Tight binding, vibrant cover. Small corner crease.", "Fine", "https://m.media-amazon.com/images/I/81WxtKOsJrL._AC_UF894,1000_QL80_.jpg", null, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Utc), "The relaunch that made X-Men the biggest franchise in comics. Introduces Storm, Colossus, Nightcrawler, and more.", "Bronze Age", "Superhero", true, false, 1, null, 1, "Start of the Claremont era. Essential reading.", new DateTime(1975, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel", "Giant-Size X-Men" },
                    { 5, "Morpheus, Dream, Cain, Abel", "Excellent condition, stored properly since purchase.", "Near Mint", "https://static.dc.com/dc/files/default_images/sandman_1_5bdcac3465cb99.69674278.jpg?w=640", null, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Neil Gaiman's masterpiece begins. The comic that proved comics could be literature.", "Modern Age", "Fantasy/Horror", true, false, 1, null, 2, "Start of the greatest comic series ever written. Mature readers.", new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DC/Vertigo", "Sandman" },
                    { 6, "Swamp Thing, Abby Cable", "Alan Moore's first issue. Excellent condition.", "Very Fine", "https://imgix-media.wbdndc.net/ingest/book/preview/38880d58-1b51-4aca-9e18-80337ef0a9f8/62d92087-bb30-4f40-bf53-cbedfbc52db9/0.jpg", null, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), "The Anatomy Lesson. Alan Moore reimagines Swamp Thing in this legendary issue that changed horror comics.", "Copper Age", "Horror", true, false, 21, null, 2, "Moore's first issue. One of the most important comics of the 80s.", new DateTime(1984, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DC", "Saga of the Swamp Thing" },
                    { 7, "John Constantine", "Good reading copy. Some minor wear.", "Fine", "https://m.media-amazon.com/images/I/716ZMMCUw7L._AC_UF1000,1000_QL80_.jpg", null, new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), "John Constantine gets his own series. Working-class horror meets social commentary.", "Modern Age", "Horror/Urban Fantasy", true, false, 1, null, 2, "Constantine at his best. Mature content throughout the series.", new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DC/Vertigo", "Hellblazer" },
                    { 8, "Jesse Custer, Tulip O'Hare, Cassidy", "Well-preserved, bright white pages.", "Very Fine", "https://static.wikia.nocookie.net/marvel_dc/images/8/82/Preacher_01b.jpg", null, new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Garth Ennis and Steve Dillon's controversial masterpiece begins. A Texas preacher gains the power of God.", "Modern Age", "Action/Dark Comedy", true, false, 1, null, 2, "WARNING: Extremely mature content. Not for the easily offended.", new DateTime(1995, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DC/Vertigo", "Preacher" },
                    { 9, "X-Men, Thunderbird, Count Nefaria", "Solid copy. Death of Thunderbird story.", "Fine", "https://cdn.marvel.com/u/prod/marvel/i/mg/3/50/58a60168b290d/clean.jpg", null, new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), "The new X-Men's first regular issue. Death of Thunderbird. Claremont's run truly begins.", "Bronze Age", "Superhero", true, false, 94, null, 3, "First issue of the regular series with new team.", new DateTime(1975, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel", "Uncanny X-Men" },
                    { 10, "X-Men, Kitty Pryde, Emma Frost", "First Kitty Pryde! Excellent condition.", "Very Fine", "https://cdn.marvel.com/u/prod/marvel/i/mg/3/e0/519b7f491722f/clean.jpg", null, new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), "First appearance of Kitty Pryde and Emma Frost. The Dark Phoenix Saga begins.", "Bronze Age", "Superhero", true, false, 129, null, 3, "Essential issue. Beginning of the greatest X-Men story ever.", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel", "Uncanny X-Men" },
                    { 11, "X-Men, Phoenix, Imperial Guard", "Complete. Dark Phoenix finale. Some spine wear.", "Fine", "https://cdn.marvel.com/u/prod/marvel/i/mg/6/80/5372a8d26e25e/clean.jpg", null, new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), "The death of Phoenix. One of the most emotional issues in comics history.", "Bronze Age", "Superhero", true, false, 137, null, 3, "Bring tissues. Still gets me after all these years.", new DateTime(1980, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel", "Uncanny X-Men" },
                    { 12, "X-Men, Future Wolverine, Sentinels", "Days of Future Past part 1! Excellent copy.", "Very Fine", "https://cdn.marvel.com/u/prod/marvel/i/mg/6/40/64e760f6051cb/clean.jpg", null, new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Days of Future Past begins. The story that defined dystopian superhero comics.", "Bronze Age", "Superhero", true, false, 141, null, 3, "The iconic cover. Essential reading for any X-Men fan.", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel", "Uncanny X-Men" },
                    { 13, "Wolverine, Mariko, Silver Samurai", "First limited series! Miller/Claremont classic.", "Very Fine", "https://cdn.marvel.com/u/prod/marvel/i/mg/4/00/5854497f12e1f/clean.jpg", null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "The Claremont/Miller limited series that defined Wolverine. 'I'm the best there is at what I do.'", "Bronze Age", "Superhero/Action", true, false, 1, null, 3, "Frank Miller on Wolverine. Doesn't get better than this.", new DateTime(1982, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel", "Wolverine" },
                    { 14, "Batman, Ra's al Ghul, Talia", "First Ra's al Ghul! Neal Adams art. Some wear.", "Fine", "https://static.wikia.nocookie.net/marvel_dc/images/9/9c/Batman_232.jpg", null, new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), "First appearance of Ra's al Ghul. O'Neil and Adams redefine Batman as the Dark Knight.", "Bronze Age", "Superhero/Adventure", true, false, 232, null, 4, "The issue that brought Batman back to his roots.", new DateTime(1971, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DC", "Batman" },
                    { 15, "Green Lantern, Green Arrow", "Start of the legendary run. Cover wear present.", "Very Good", "https://static.wikia.nocookie.net/marvel_dc/images/1/1c/Green_Lantern_Vol_2_76.jpg", null, new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), "The O'Neil/Adams run begins. Comics tackle social issues for the first time. A landmark in the medium.", "Bronze Age", "Superhero/Social Commentary", true, false, 76, null, 4, "Comics grow up. This changed everything.", new DateTime(1970, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DC", "Green Lantern/Green Arrow" },
                    { 16, "Robin, Starfire, Raven, Cyborg, Beast Boy", "Wolfman/Perez magic begins! Bright, tight copy.", "Very Fine", "https://static.wikia.nocookie.net/marvel_dc/images/8/8b/New_Teen_Titans_Vol_1_1.jpg", null, new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), "The start of DC's biggest 80s hit. Wolfman and Perez create a new generation of heroes.", "Bronze Age", "Superhero", true, false, 1, null, 4, "DC's answer to X-Men. And it was amazing.", new DateTime(1980, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DC", "New Teen Titans" },
                    { 17, "Teen Titans, Deathstroke", "First full Deathstroke! Good condition.", "Fine", "https://imgix-media.wbdndc.net/ingest/book/preview/45fd1ec5-5011-4c2e-b7a1-bc6eef3029c6/b4e9f916-980a-4701-941f-88d40d97387f/0.jpg", null, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), "First full appearance of Deathstroke the Terminator. The greatest villain of the Titans.", "Bronze Age", "Superhero", true, false, 2, null, 4, "Deathstroke's first full appearance. Key issue.", new DateTime(1980, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DC", "New Teen Titans" },
                    { 18, "Batman, Commissioner Gordon, Harvey Dent", "First print. Stored in Mylar since purchase.", "Near Mint", "https://static.wikia.nocookie.net/batman/images/7/74/The_Dark_Knight_Returns.jpg", null, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Frank Miller reinvents Batman. The comic that changed superhero storytelling forever.", "Copper Age", "Superhero/Dystopia", true, false, 1, null, 4, "The book that proved comics could be art.", new DateTime(1986, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DC", "Batman: The Dark Knight Returns" },
                    { 19, "Cerebus", "Early indie key. Some wear but complete.", "Good", "https://recalledcomics.com/CerebusTheAardvark1.jpg", null, new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), "The beginning of the 300-issue epic. Dave Sim's groundbreaking independent series.", "Bronze Age", "Fantasy/Satire", true, false, 1, null, 5, "Start of the longest-running indie comic ever. A historic piece.", new DateTime(1977, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aardvark-Vanaheim", "Cerebus the Aardvark" },
                    { 20, "Leonardo, Donatello, Raphael, Michelangelo", "Third printing. Black and white indie key.", "Very Good", "https://s3.amazonaws.com/comicgeeks/comics/covers/large-2032546.jpg", null, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Eastman and Laird's indie sensation that became a multimedia empire. Before the toys and cartoons.", "Copper Age", "Action/Parody", true, false, 1, null, 5, "The original, darker Turtles. Nothing like the cartoon.", new DateTime(1984, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mirage Studios", "Teenage Mutant Ninja Turtles" },
                    { 21, "Cutter, Leetah, Skywise", "Original printing. Wendy Pini masterpiece.", "Fine", "https://static.wikia.nocookie.net/elfquest/images/2/2c/Fantasy_quarterly.jpg", null, new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), "The Pinis create one of the most beloved fantasy comics ever. Groundbreaking indie work.", "Bronze Age", "Fantasy", true, false, 1, null, 5, "Fantasy comics at their finest. A complete world.", new DateTime(1978, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WaRP Graphics", "Elfquest" },
                    { 22, "Reuben Flagg, Raul the Cat", "Howard Chaykin's masterwork. Excellent condition.", "Very Fine", "https://i.ebayimg.com/images/g/vfIAAOSwzlFmZNiG/s-l1600.webp", null, new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Chaykin reinvents comic book design. A satirical near-future America that proved prescient.", "Copper Age", "Sci-Fi/Political Satire", true, false, 1, null, 5, "Revolutionary design and storytelling. Way ahead of its time.", new DateTime(1983, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Comics", "American Flagg!" },
                    { 23, "Maggie, Hopey, Luba", "Hernandez Brothers classic. First printing.", "Fine", "https://i.ebayimg.com/images/g/VwgAAOSwMQxixHNs/s-l1600.webp", null, new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), "The Hernandez Brothers create the most acclaimed alternative comic series. Punk rock meets magical realism.", "Copper Age", "Drama/Slice of Life", true, false, 1, null, 5, "The definitive indie comic. Literary greatness.", new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantagraphics", "Love and Rockets" },
                    { 24, "Dracula, Blade", "First Blade appearance! Some wear but solid.", "Very Good", "https://static.wikia.nocookie.net/marveldatabase/images/2/2b/Tomb_of_Dracula_Vol_1_10.jpg", null, new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), "First appearance of Blade the Vampire Slayer. Before the movies, there was Marv Wolfman's classic.", "Bronze Age", "Horror", true, false, 10, null, 6, "Blade's first appearance. Key horror comic.", new DateTime(1973, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel", "Tomb of Dracula" },
                    { 25, "Dracula, Frank Drake", "Gene Colan art. Start of the greatest horror run.", "Fine", "https://cdn.marvel.com/u/prod/marvel/i/mg/c/30/4bb4fd44b834c/clean.jpg", null, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), "The beginning of Marvel's longest-running horror title. Colan and Wolfman create magic.", "Bronze Age", "Horror", true, false, 1, null, 6, "70 issues of horror perfection starts here.", new DateTime(1972, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel", "Tomb of Dracula" },
                    { 26, "Swamp Thing, Alec Holland", "Bernie Wrightson art. Classic origin issue.", "Very Good", "https://static.wikia.nocookie.net/marvel_dc/images/f/fe/Swamp_Thing_Vol_1_1.jpg", null, new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Bernie Wrightson's horrifying creation rises from the swamp. Pre-dates the Moore reinvention.", "Bronze Age", "Horror", true, false, 1, null, 6, "Wrightson's gorgeous horror art. Before Moore's genius.", new DateTime(1972, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DC", "Swamp Thing" },
                    { 27, "Ghost Rider, Johnny Blaze", "First Johnny Blaze series. Good reading copy.", "Fine", "https://cdn.marvel.com/u/prod/marvel/i/mg/f/90/5caf5a9b36cd8/clean.jpg", null, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Johnny Blaze makes his deal with the devil. Marvel's supernatural rider begins his solo journey.", "Bronze Age", "Horror/Superhero", true, false, 1, null, 6, "70s supernatural horror at its finest.", new DateTime(1973, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel", "Ghost Rider" },
                    { 28, "Werewolf by Night, Moon Knight", "First Moon Knight! Key Bronze Age horror issue.", "Very Good", "https://cdn.marvel.com/u/prod/marvel/i/mg/9/c0/58127df9d72ac/clean.jpg", null, new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), "First appearance of Moon Knight. The character would go on to much greater fame.", "Bronze Age", "Horror", true, false, 32, null, 6, "Moon Knight's humble beginnings in a horror comic.", new DateTime(1975, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel", "Werewolf by Night" },
                    { 29, "Uncle Creepy (host)", "Magazine format. Some wear but complete stories.", "Good", "https://images.wolfgangsvault.com/m/large/OMS797023-MZ/creepy-vintage-magazine-jan-1-1964.webp", null, new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Warren's answer to the banned EC Comics. Magazine-format horror with legendary artists.", "Silver Age", "Horror Anthology", true, false, 1, null, 6, "Classic horror magazine. The spirit of EC lives on.", new DateTime(1964, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warren Publishing", "Creepy" },
                    { 30, "Various", "Marvel's mature magazine. Excellent condition.", "Very Fine", "https://static.wikia.nocookie.net/marveldatabase/images/3/3e/Epic_Illustrated_Vol_1_1.jpg", null, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Marvel's answer to Heavy Metal. Mature science fiction and fantasy from top creators.", "Bronze Age", "Anthology/Mature", true, false, 1, null, 6, "Marvel goes mature. Beautiful magazine-format anthology.", new DateTime(1980, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel/Epic", "Epic Illustrated" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comics_OwnerId",
                table: "Comics",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanRequests_OwnerId",
                table: "LoanRequests",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanRequests_RequestedComicId",
                table: "LoanRequests",
                column: "RequestedComicId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanRequests_RequesterId",
                table: "LoanRequests",
                column: "RequesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_BorrowerId",
                table: "Loans",
                column: "BorrowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_ComicId",
                table: "Loans",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LenderId",
                table: "Loans",
                column: "LenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LoanRequestId",
                table: "Loans",
                column: "LoanRequestId",
                unique: true,
                filter: "[LoanRequestId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_LoanId",
                table: "Reviews",
                column: "LoanId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewedUserId",
                table: "Reviews",
                column: "ReviewedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewerId",
                table: "Reviews",
                column: "ReviewerId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "LoanRequests");

            migrationBuilder.DropTable(
                name: "Comics");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
