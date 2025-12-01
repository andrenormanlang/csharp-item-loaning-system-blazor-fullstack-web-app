using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ComicBooksExchangeAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    CollectingFocus = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PreferredEras = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FavoriteCharacters = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuccessfulExchanges = table.Column<int>(type: "int", nullable: false),
                    AverageRating = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    MemberSince = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    PreferredExchangeMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradePreferences = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    OriginalCoverPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EstimatedValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConditionGrade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ConditionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsProfessionallyGraded = table.Column<bool>(type: "bit", nullable: false),
                    ProfessionalGradeInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Era = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsKeyIssue = table.Column<bool>(type: "bit", nullable: false),
                    KeyIssueDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    DateListed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CollectorNotes = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Exchanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InitiatorId = table.Column<int>(type: "int", nullable: false),
                    RecipientId = table.Column<int>(type: "int", nullable: false),
                    OfferedComicId = table.Column<int>(type: "int", nullable: false),
                    RequestedComicId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OfferMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateResponded = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCompleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exchanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exchanges_Comics_OfferedComicId",
                        column: x => x.OfferedComicId,
                        principalTable: "Comics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exchanges_Comics_RequestedComicId",
                        column: x => x.RequestedComicId,
                        principalTable: "Comics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exchanges_Users_InitiatorId",
                        column: x => x.InitiatorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exchanges_Users_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExchangeId = table.Column<int>(type: "int", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateInitiated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateShipped = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateReceived = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceivedConditionNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasDispute = table.Column<bool>(type: "bit", nullable: false),
                    DisputeDetails = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Exchanges_ExchangeId",
                        column: x => x.ExchangeId,
                        principalTable: "Exchanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewerId = table.Column<int>(type: "int", nullable: false),
                    ReviewedUserId = table.Column<int>(type: "int", nullable: false),
                    ExchangeId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Reviews_Exchanges_ExchangeId",
                        column: x => x.ExchangeId,
                        principalTable: "Exchanges",
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

            migrationBuilder.CreateIndex(
                name: "IX_Comics_OwnerId",
                table: "Comics",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Exchanges_InitiatorId",
                table: "Exchanges",
                column: "InitiatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Exchanges_OfferedComicId",
                table: "Exchanges",
                column: "OfferedComicId");

            migrationBuilder.CreateIndex(
                name: "IX_Exchanges_RecipientId",
                table: "Exchanges",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_Exchanges_RequestedComicId",
                table: "Exchanges",
                column: "RequestedComicId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ExchangeId",
                table: "Reviews",
                column: "ExchangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewedUserId",
                table: "Reviews",
                column: "ReviewedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewerId",
                table: "Reviews",
                column: "ReviewerId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ExchangeId",
                table: "Transactions",
                column: "ExchangeId");

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
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Exchanges");

            migrationBuilder.DropTable(
                name: "Comics");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
