using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComicBooksLoanAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddAnnouncementsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Announcements_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "Content", "CreatedAt", "CreatedById", "CreatedByUserId", "IsActive", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "We're excited to launch this platform connecting comic book collectors across Skåne. Our community is built on trust, shared passion, and the joy of discovering great stories. Start by browsing available comics or listing your own collection!", new DateTime(2025, 11, 12, 10, 1, 11, 512, DateTimeKind.Utc).AddTicks(5136), null, 6, true, "Welcome to Comic Books Loan Exchange! 📚", 0, null },
                    { 2, "You can now leave reviews after completing loans! Help build trust in our community by sharing your experiences as both a lender and borrower. Great reviews help everyone make informed decisions about who to lend to.", new DateTime(2025, 11, 27, 10, 1, 11, 512, DateTimeKind.Utc).AddTicks(5136), null, 6, true, "New Feature: Review System Live! ⭐", 1, null },
                    { 3, "For everyone's safety, we recommend meeting in public places like cafes, libraries, or comic book shops. Popular spots in Malmö include Stortorget, Malmö Library, and Central Station. Always verify identity and inspect comics during the handoff.", new DateTime(2025, 12, 5, 10, 1, 11, 512, DateTimeKind.Utc).AddTicks(5136), null, 6, true, "Meetup Guidelines Updated 📍", 4, null },
                    { 4, "Our lending library has reached over 100 comics available for loan! From Bronze Age classics to modern indie titles, there's something for everyone. Thank you to all our collectors for sharing their passion.", new DateTime(2025, 12, 9, 10, 1, 11, 512, DateTimeKind.Utc).AddTicks(5136), null, 6, true, "Growing Community: 100+ Comics Available! 🎉", 3, null },
                    { 5, "New to comic lending? Start small! Request a shorter loan period for your first exchanges to build trust. Always communicate clearly about condition expectations, and don't hesitate to use our messaging system to coordinate meetups.", new DateTime(2025, 12, 11, 22, 1, 11, 512, DateTimeKind.Utc).AddTicks(5136), null, 6, true, "Tips for New Members 💡", 0, null }
                });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 1,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 2,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 3,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 4,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 5,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 6,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 7,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 9,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 10,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 11,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 12,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 13,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 14,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 15,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 16,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 17,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 19,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 20,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 21,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 24,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 25,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 25, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 26,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 28,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2023, 12, 25, 10, 1, 11, 506, DateTimeKind.Utc).AddTicks(8757), new DateTime(2023, 12, 12, 10, 1, 11, 506, DateTimeKind.Utc).AddTicks(7815), new DateTime(2023, 12, 26, 10, 1, 11, 506, DateTimeKind.Utc).AddTicks(8524), new DateTime(2023, 12, 12, 10, 1, 11, 506, DateTimeKind.Utc).AddTicks(8184), new DateTime(2023, 12, 12, 10, 1, 11, 506, DateTimeKind.Utc).AddTicks(9352), new DateTime(2023, 12, 25, 10, 1, 11, 506, DateTimeKind.Utc).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(464), new DateTime(2024, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(460), new DateTime(2024, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(463), new DateTime(2024, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(462), new DateTime(2024, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(465), new DateTime(2024, 1, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(470), new DateTime(2024, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(468), new DateTime(2024, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(469), new DateTime(2024, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(469), new DateTime(2024, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(470), new DateTime(2024, 2, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(473), new DateTime(2024, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(472), new DateTime(2024, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(473), new DateTime(2024, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(472), new DateTime(2024, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(473), new DateTime(2024, 3, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(477), new DateTime(2024, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(475), new DateTime(2024, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(476), new DateTime(2024, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(476), new DateTime(2024, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(477), new DateTime(2024, 4, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(485), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(484), new DateTime(2024, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(485), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(484), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(486), new DateTime(2024, 5, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(489), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(487), new DateTime(2024, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(488), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(488), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(489), new DateTime(2024, 6, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(492), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(491), new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(492), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(491), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(493), new DateTime(2024, 7, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(496), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(494), new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(495), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(495), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(496), new DateTime(2024, 8, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(500), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(499), new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(500), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(499), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(501), new DateTime(2024, 9, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(503), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(502), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(503), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(503), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(504), new DateTime(2024, 10, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(507), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(506), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(506), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(506), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(507), new DateTime(2024, 11, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(552), new DateTime(2024, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(549), new DateTime(2024, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(551), new DateTime(2024, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(550), new DateTime(2024, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(553), new DateTime(2024, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(557), new DateTime(2024, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(556), new DateTime(2024, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(557), new DateTime(2024, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(556), new DateTime(2024, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(558), new DateTime(2024, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(561), new DateTime(2024, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(559), new DateTime(2024, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(560), new DateTime(2024, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(560), new DateTime(2024, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(561), new DateTime(2024, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(564), new DateTime(2024, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(563), new DateTime(2024, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(564), new DateTime(2024, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(563), new DateTime(2024, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(565), new DateTime(2024, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(568), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(566), new DateTime(2024, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(567), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(567), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(568), new DateTime(2024, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(572), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(571), new DateTime(2024, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(572), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(571), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(573), new DateTime(2024, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(575), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(574), new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(575), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(575), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(576), new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(579), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(578), new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(579), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(578), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(580), new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(583), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(581), new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(582), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(582), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(583), new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(586), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(585), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(586), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(585), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(587), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(590), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(588), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(589), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(589), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(590), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(593), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(592), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(593), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(592), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(594), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(598), new DateTime(2024, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(596), new DateTime(2024, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(597), new DateTime(2024, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(596), new DateTime(2024, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(599), new DateTime(2024, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(602), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(601), new DateTime(2024, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(602), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(602), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(603), new DateTime(2024, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(606), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(605), new DateTime(2024, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(606), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(605), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(606), new DateTime(2024, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(609), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(608), new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(609), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(608), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(610), new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(613), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(611), new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(612), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(612), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(613), new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(616), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(615), new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(616), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(615), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(616), new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(619), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(618), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(619), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(618), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(620), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(623), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(621), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(622), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(622), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(623), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(626), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(625), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(625), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(625), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(626), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(631), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(629), new DateTime(2024, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(630), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(630), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(632), new DateTime(2024, 5, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(636), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(634), new DateTime(2024, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(635), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(635), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(636), new DateTime(2024, 6, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(639), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(638), new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(639), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(638), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(640), new DateTime(2024, 7, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(642), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(641), new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(642), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(642), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(643), new DateTime(2024, 8, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(646), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(644), new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(645), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(645), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(646), new DateTime(2024, 9, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(649), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(648), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(649), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(648), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(650), new DateTime(2024, 10, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(653), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(652), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(652), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(652), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(653), new DateTime(2024, 11, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(656), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(655), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(656), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(655), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(657), new DateTime(2024, 12, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(660), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(658), new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(660), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(659), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(661), new DateTime(2025, 1, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(677), new DateTime(2024, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(674), new DateTime(2024, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(676), new DateTime(2024, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(675), new DateTime(2024, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(678), new DateTime(2024, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(688), new DateTime(2024, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(686), new DateTime(2024, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(687), new DateTime(2024, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(687), new DateTime(2024, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(688), new DateTime(2024, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(691), new DateTime(2024, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(690), new DateTime(2024, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(691), new DateTime(2024, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(691), new DateTime(2024, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(692), new DateTime(2024, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(695), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(694), new DateTime(2024, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(694), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(694), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(696), new DateTime(2024, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(698), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(697), new DateTime(2024, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(698), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(697), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(699), new DateTime(2024, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(702), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(700), new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(701), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(701), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(702), new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(705), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(704), new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(704), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(704), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(705), new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(708), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(707), new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(708), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(707), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(709), new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(712), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(710), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(711), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(711), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(712), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(715), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(714), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(714), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(714), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(715), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(718), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(717), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(718), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(717), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(719), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(722), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(720), new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(721), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(721), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(722), new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(725), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(724), new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(725), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(724), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(726), new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(729), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(727), new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(728), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(728), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(729), new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(732), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(730), new DateTime(2025, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(731), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(731), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(732), new DateTime(2025, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(735), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(734), new DateTime(2025, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(734), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(734), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(735), new DateTime(2025, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(738), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(737), new DateTime(2025, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(738), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(737), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(739), new DateTime(2025, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(742), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(740), new DateTime(2025, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(741), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(741), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(742), new DateTime(2025, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(745), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(744), new DateTime(2025, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(745), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(744), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(746), new DateTime(2025, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(748), new DateTime(2025, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(747), new DateTime(2025, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(748), new DateTime(2025, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(747), new DateTime(2025, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(749), new DateTime(2025, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(751), new DateTime(2025, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(750), new DateTime(2025, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(751), new DateTime(2025, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(751), new DateTime(2025, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(752), new DateTime(2025, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(756), new DateTime(2024, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(754), new DateTime(2024, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(756), new DateTime(2024, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(755), new DateTime(2024, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(757), new DateTime(2024, 3, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(761), new DateTime(2024, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(760), new DateTime(2024, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(761), new DateTime(2024, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(760), new DateTime(2024, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(762), new DateTime(2024, 4, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(765), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(764), new DateTime(2024, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(765), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(765), new DateTime(2024, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(766), new DateTime(2024, 5, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(770), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(768), new DateTime(2024, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(769), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(768), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(770), new DateTime(2024, 6, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(773), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(772), new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(773), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(772), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(774), new DateTime(2024, 7, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(777), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(775), new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(776), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(776), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(777), new DateTime(2024, 8, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(780), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(779), new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(780), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(779), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(781), new DateTime(2024, 9, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(783), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(782), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(783), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(783), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(784), new DateTime(2024, 10, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(787), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(786), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(787), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(786), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(788), new DateTime(2024, 11, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(791), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(789), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(790), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(790), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(791), new DateTime(2024, 12, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(800), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(798), new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(799), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(799), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(800), new DateTime(2025, 1, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(803), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(802), new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(802), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(802), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(804), new DateTime(2025, 2, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(806), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(805), new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(806), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(806), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(807), new DateTime(2025, 3, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(810), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(809), new DateTime(2025, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(810), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(809), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(811), new DateTime(2025, 4, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(813), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(812), new DateTime(2025, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(813), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(813), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(814), new DateTime(2025, 5, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(817), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(816), new DateTime(2025, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(816), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(816), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(817), new DateTime(2025, 6, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(820), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(819), new DateTime(2025, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(820), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(819), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(821), new DateTime(2025, 7, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(824), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(822), new DateTime(2025, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(823), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(823), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(824), new DateTime(2025, 8, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(827), new DateTime(2025, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(826), new DateTime(2025, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(826), new DateTime(2025, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(826), new DateTime(2025, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(827), new DateTime(2025, 9, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(830), new DateTime(2025, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(829), new DateTime(2025, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(830), new DateTime(2025, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(830), new DateTime(2025, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(831), new DateTime(2025, 10, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(834), new DateTime(2025, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(832), new DateTime(2025, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(833), new DateTime(2025, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(833), new DateTime(2025, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(834), new DateTime(2025, 11, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(838), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(836), new DateTime(2024, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(838), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(837), new DateTime(2024, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(839), new DateTime(2024, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(843), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(842), new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(842), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(842), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(843), new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(846), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(845), new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(846), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(845), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(847), new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(850), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(849), new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(850), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(849), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(851), new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(853), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(852), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(853), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(853), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(854), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(857), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(856), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(856), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(856), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(857), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(860), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(859), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(860), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(860), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(861), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(864), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(863), new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(864), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(863), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(865), new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(867), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(866), new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(867), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(867), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(868), new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(871), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(869), new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(870), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(870), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(871), new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(874), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(873), new DateTime(2025, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(873), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(873), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(874), new DateTime(2025, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(877), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(876), new DateTime(2025, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(877), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(876), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(878), new DateTime(2025, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(880), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(879), new DateTime(2025, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(880), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(879), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(881), new DateTime(2025, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(884), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(882), new DateTime(2025, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(883), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(883), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(884), new DateTime(2025, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(887), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(886), new DateTime(2025, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(887), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(886), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(887), new DateTime(2025, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(890), new DateTime(2025, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(889), new DateTime(2025, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(890), new DateTime(2025, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(889), new DateTime(2025, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(891), new DateTime(2025, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(907), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(905), new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(906), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(905), new DateTime(2024, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(908), new DateTime(2024, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(912), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(910), new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(911), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(911), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(912), new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(916), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(914), new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(915), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(915), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(916), new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(919), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(918), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(919), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(918), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(920), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(923), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(922), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(922), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(922), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(923), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(926), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(925), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(926), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(925), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(927), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(930), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(929), new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(930), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(929), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(931), new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(939), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(938), new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(939), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(939), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(940), new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(943), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(941), new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(942), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(942), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(943), new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(946), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(945), new DateTime(2025, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(946), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(945), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(947), new DateTime(2025, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(950), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(948), new DateTime(2025, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(949), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(949), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(950), new DateTime(2025, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(953), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(952), new DateTime(2025, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(953), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(952), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(954), new DateTime(2025, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(956), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(955), new DateTime(2025, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(956), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(956), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(957), new DateTime(2025, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(960), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(958), new DateTime(2025, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(959), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(959), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(960), new DateTime(2025, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(963), new DateTime(2025, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(962), new DateTime(2025, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(963), new DateTime(2025, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(962), new DateTime(2025, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(964), new DateTime(2025, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(968), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(966), new DateTime(2024, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(967), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(967), new DateTime(2024, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(969), new DateTime(2024, 8, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(972), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(971), new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(972), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(972), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(973), new DateTime(2024, 9, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(976), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(975), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(975), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(975), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(976), new DateTime(2024, 10, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(979), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(978), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(979), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(978), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(980), new DateTime(2024, 11, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(982), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(981), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(982), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(981), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(983), new DateTime(2024, 12, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(986), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(984), new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(986), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(985), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(987), new DateTime(2025, 1, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(989), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(988), new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(989), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(989), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(990), new DateTime(2025, 2, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(993), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(991), new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(992), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(992), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(993), new DateTime(2025, 3, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(998), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(996), new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(997), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(996), new DateTime(2024, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(998), new DateTime(2024, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1002), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1001), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1002), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1001), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1003), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1006), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1004), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1005), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1005), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1006), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1009), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1008), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1009), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1008), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1010), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1013), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1011), new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1012), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1012), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1014), new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1016), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1015), new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1016), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1016), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1017), new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1022), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1020), new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1021), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1021), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1022), new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1026), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1024), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1026), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1025), new DateTime(2024, 10, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1027), new DateTime(2024, 10, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1031), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1029), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1031), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1034), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1033), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1033), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1033), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1035), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1043), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1041), new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1042), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1042), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1043), new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1046), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1045), new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1046), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1045), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1047), new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1049), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1048), new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1049), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1048), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1050), new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1052), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1051), new DateTime(2025, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1052), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1052), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1053), new DateTime(2025, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1056), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1054), new DateTime(2025, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1055), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1055), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1056), new DateTime(2025, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1059), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1058), new DateTime(2025, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1058), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1058), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1059), new DateTime(2025, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1062), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1061), new DateTime(2025, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1062), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1061), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1063), new DateTime(2025, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1063) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1065), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1064), new DateTime(2025, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1065), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1064), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1066), new DateTime(2025, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1070), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1068), new DateTime(2024, 11, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1070), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1069), new DateTime(2024, 11, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1071), new DateTime(2024, 11, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1075), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1074), new DateTime(2024, 12, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1075), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1074), new DateTime(2024, 12, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1076), new DateTime(2024, 12, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1079), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1078), new DateTime(2025, 1, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1079), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1078), new DateTime(2025, 1, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1080), new DateTime(2025, 1, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1083), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1082), new DateTime(2025, 2, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1082), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1082), new DateTime(2025, 2, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1083), new DateTime(2025, 2, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1086), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1085), new DateTime(2025, 3, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1086), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1086), new DateTime(2025, 3, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1087), new DateTime(2025, 3, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1090), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1089), new DateTime(2025, 4, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1089), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1089), new DateTime(2025, 4, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1090), new DateTime(2025, 4, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1093), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1092), new DateTime(2025, 5, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1093), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1092), new DateTime(2025, 5, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1094), new DateTime(2025, 5, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1097), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1095), new DateTime(2025, 6, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1096), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1096), new DateTime(2025, 6, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1097), new DateTime(2025, 6, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1100), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1099), new DateTime(2025, 7, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1100), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1099), new DateTime(2025, 7, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 7, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1104), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1102), new DateTime(2025, 8, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1103), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1103), new DateTime(2025, 8, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1104), new DateTime(2025, 8, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1107), new DateTime(2025, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1106), new DateTime(2025, 9, 26, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1106), new DateTime(2025, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1106), new DateTime(2025, 9, 12, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1107), new DateTime(2025, 9, 25, 10, 1, 11, 507, DateTimeKind.Utc).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentDate",
                value: new DateTime(2025, 11, 28, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentDate",
                value: new DateTime(2025, 11, 29, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SentDate",
                value: new DateTime(2025, 11, 30, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SentDate",
                value: new DateTime(2025, 12, 1, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SentDate",
                value: new DateTime(2025, 12, 2, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SentDate",
                value: new DateTime(2025, 12, 3, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SentDate",
                value: new DateTime(2025, 12, 4, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SentDate",
                value: new DateTime(2025, 12, 5, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SentDate",
                value: new DateTime(2025, 12, 6, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SentDate",
                value: new DateTime(2025, 12, 7, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SentDate",
                value: new DateTime(2025, 12, 7, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SentDate",
                value: new DateTime(2025, 12, 8, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SentDate",
                value: new DateTime(2025, 12, 9, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SentDate",
                value: new DateTime(2025, 12, 4, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SentDate",
                value: new DateTime(2025, 12, 5, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SentDate",
                value: new DateTime(2025, 12, 6, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SentDate",
                value: new DateTime(2025, 12, 8, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SentDate",
                value: new DateTime(2025, 12, 9, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SentDate",
                value: new DateTime(2025, 12, 10, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SentDate",
                value: new DateTime(2025, 12, 6, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SentDate",
                value: new DateTime(2025, 12, 7, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SentDate",
                value: new DateTime(2025, 12, 8, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SentDate",
                value: new DateTime(2025, 12, 9, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SentDate",
                value: new DateTime(2025, 12, 10, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SentDate",
                value: new DateTime(2025, 12, 11, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SentDate",
                value: new DateTime(2025, 12, 7, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SentDate",
                value: new DateTime(2025, 12, 8, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SentDate",
                value: new DateTime(2025, 12, 10, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SentDate",
                value: new DateTime(2025, 12, 11, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SentDate",
                value: new DateTime(2025, 12, 9, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SentDate",
                value: new DateTime(2025, 12, 10, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SentDate",
                value: new DateTime(2025, 12, 8, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SentDate",
                value: new DateTime(2025, 12, 9, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SentDate",
                value: new DateTime(2025, 12, 11, 10, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SentDate",
                value: new DateTime(2025, 12, 11, 22, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SentDate",
                value: new DateTime(2025, 12, 12, 4, 1, 11, 511, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateSubmitted",
                value: new DateTime(2024, 1, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateSubmitted",
                value: new DateTime(2023, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateSubmitted",
                value: new DateTime(2024, 1, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateSubmitted",
                value: new DateTime(2025, 4, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 26, 10, 1, 11, 510, DateTimeKind.Utc).AddTicks(8337));

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_CreatedById",
                table: "Announcements",
                column: "CreatedById");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 1,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 2,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 3,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 4,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 5,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 6,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 7,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 9,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 10,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 11,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 12,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 13,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 14,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 15,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 16,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 17,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 19,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 20,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 21,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 24,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 25,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 26,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 28,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2023, 12, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(4195), new DateTime(2023, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(3343), new DateTime(2023, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(3973), new DateTime(2023, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(3661), new DateTime(2023, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(4783), new DateTime(2023, 12, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5757), new DateTime(2024, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5754), new DateTime(2024, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5756), new DateTime(2024, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5756), new DateTime(2024, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5758), new DateTime(2024, 1, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5763), new DateTime(2024, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5761), new DateTime(2024, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5762), new DateTime(2024, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5762), new DateTime(2024, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5763), new DateTime(2024, 2, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5790), new DateTime(2024, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5788), new DateTime(2024, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5789), new DateTime(2024, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5789), new DateTime(2024, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5790), new DateTime(2024, 3, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5793), new DateTime(2024, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5792), new DateTime(2024, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5793), new DateTime(2024, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5793), new DateTime(2024, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5794), new DateTime(2024, 4, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5801), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5801), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5802), new DateTime(2024, 5, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5805), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5804), new DateTime(2024, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5804), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5804), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5805), new DateTime(2024, 6, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5808), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5807), new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5808), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5807), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5809), new DateTime(2024, 7, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5812), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5810), new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5811), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5811), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5812), new DateTime(2024, 8, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5816), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5815), new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5816), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5815), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5817), new DateTime(2024, 9, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5820), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5818), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5819), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5819), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5820), new DateTime(2024, 10, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5823), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5822), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5822), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5822), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5823), new DateTime(2024, 11, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5827), new DateTime(2024, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5826), new DateTime(2024, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5827), new DateTime(2024, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5826), new DateTime(2024, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5828), new DateTime(2024, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5832), new DateTime(2024, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5831), new DateTime(2024, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5832), new DateTime(2024, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5831), new DateTime(2024, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5833), new DateTime(2024, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5836), new DateTime(2024, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5835), new DateTime(2024, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5835), new DateTime(2024, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5835), new DateTime(2024, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5836), new DateTime(2024, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5840), new DateTime(2024, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5838), new DateTime(2024, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5839), new DateTime(2024, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5839), new DateTime(2024, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5840), new DateTime(2024, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5843), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5842), new DateTime(2024, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5843), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5842), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5844), new DateTime(2024, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5848), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5846), new DateTime(2024, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5847), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5847), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5848), new DateTime(2024, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5851), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5850), new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5851), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5850), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5852), new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5855), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5853), new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5854), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5854), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5855), new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5858), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5857), new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5858), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5858), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5859), new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5862), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5861), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5861), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5861), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5862), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5865), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5864), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5865), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5864), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5866), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5869), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5868), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5869), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5868), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5869), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5873), new DateTime(2024, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5872), new DateTime(2024, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5873), new DateTime(2024, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5872), new DateTime(2024, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5874), new DateTime(2024, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5878), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5877), new DateTime(2024, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5877), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5877), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5879), new DateTime(2024, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5881), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5880), new DateTime(2024, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5881), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5881), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5882), new DateTime(2024, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5885), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5884), new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5884), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5884), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5885), new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5888), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5887), new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5888), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5887), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5889), new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5891), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5890), new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5891), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5891), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5892), new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5895), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5894), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5895), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5894), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5895), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5898), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5897), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5898), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5898), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5899), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5902), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5900), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5901), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5901), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5902), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5936), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5933), new DateTime(2024, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5935), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5934), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5937), new DateTime(2024, 5, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5941), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5939), new DateTime(2024, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5940), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5940), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5941), new DateTime(2024, 6, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5945), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5943), new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5944), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5944), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5945), new DateTime(2024, 7, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5948), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5947), new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5948), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5947), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5949), new DateTime(2024, 8, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5952), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5950), new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5951), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5951), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5952), new DateTime(2024, 9, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5955), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5954), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5955), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5954), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5956), new DateTime(2024, 10, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5959), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5957), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5958), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5958), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5959), new DateTime(2024, 11, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5962), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5961), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5962), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5961), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5963), new DateTime(2024, 12, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5966), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5964), new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5966), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5965), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5967), new DateTime(2025, 1, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5970), new DateTime(2024, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5969), new DateTime(2024, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5970), new DateTime(2024, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5969), new DateTime(2024, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5971), new DateTime(2024, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5975), new DateTime(2024, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5973), new DateTime(2024, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5974), new DateTime(2024, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5974), new DateTime(2024, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5975), new DateTime(2024, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5979), new DateTime(2024, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5977), new DateTime(2024, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5978), new DateTime(2024, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5978), new DateTime(2024, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5979), new DateTime(2024, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5982), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5981), new DateTime(2024, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5981), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5981), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5982), new DateTime(2024, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5985), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5984), new DateTime(2024, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5985), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5984), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5986), new DateTime(2024, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5988), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5987), new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5988), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5988), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5989), new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5992), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5990), new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5991), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5991), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5992), new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5995), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5994), new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5995), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5994), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5996), new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5999), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5997), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5998), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5998), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(5999), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6002), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6001), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6002), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6001), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6003), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6005), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6004), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6005), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6005), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6006), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6009), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6007), new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6008), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6008), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6009), new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6012), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6011), new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6012), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6012), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6013), new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6016), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6014), new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6015), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6015), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6016), new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6019), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6018), new DateTime(2025, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6018), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6018), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6019), new DateTime(2025, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6022), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6021), new DateTime(2025, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6022), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6021), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6023), new DateTime(2025, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6025), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6024), new DateTime(2025, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6025), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6025), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6026), new DateTime(2025, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6029), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6028), new DateTime(2025, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6028), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6028), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6029), new DateTime(2025, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6032), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6031), new DateTime(2025, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6032), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6031), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6033), new DateTime(2025, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6036), new DateTime(2025, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6034), new DateTime(2025, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6035), new DateTime(2025, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6035), new DateTime(2025, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6036), new DateTime(2025, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6039), new DateTime(2025, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6038), new DateTime(2025, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6039), new DateTime(2025, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6038), new DateTime(2025, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6039), new DateTime(2025, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6044), new DateTime(2024, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6042), new DateTime(2024, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6043), new DateTime(2024, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6042), new DateTime(2024, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6044), new DateTime(2024, 3, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6048), new DateTime(2024, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6047), new DateTime(2024, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6048), new DateTime(2024, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6047), new DateTime(2024, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6049), new DateTime(2024, 4, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6058), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6057), new DateTime(2024, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6057), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6057), new DateTime(2024, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6058), new DateTime(2024, 5, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6062), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6060), new DateTime(2024, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6061), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6061), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6062), new DateTime(2024, 6, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6065), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6064), new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6065), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6064), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6066), new DateTime(2024, 7, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6069), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6067), new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6068), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6068), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6069), new DateTime(2024, 8, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6072), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6071), new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6072), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6071), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6073), new DateTime(2024, 9, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6076), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6075), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6075), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6075), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6076), new DateTime(2024, 10, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6080), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6078), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6079), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6079), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6080), new DateTime(2024, 11, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6083), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6082), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6083), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6082), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6084), new DateTime(2024, 12, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6087), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6085), new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6086), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6086), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6087), new DateTime(2025, 1, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6090), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6089), new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6090), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6089), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6091), new DateTime(2025, 2, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6094), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6092), new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6093), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6093), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6094), new DateTime(2025, 3, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6097), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6096), new DateTime(2025, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6097), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6096), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6098), new DateTime(2025, 4, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6101), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6099), new DateTime(2025, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6100), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6100), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6101), new DateTime(2025, 5, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6104), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6103), new DateTime(2025, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6103), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6103), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6104), new DateTime(2025, 6, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6107), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6106), new DateTime(2025, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6107), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6106), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6108), new DateTime(2025, 7, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6111), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6109), new DateTime(2025, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6110), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6110), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6111), new DateTime(2025, 8, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6114), new DateTime(2025, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6113), new DateTime(2025, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6114), new DateTime(2025, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6113), new DateTime(2025, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6115), new DateTime(2025, 9, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6118), new DateTime(2025, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6116), new DateTime(2025, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6117), new DateTime(2025, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6117), new DateTime(2025, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6118), new DateTime(2025, 10, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6121), new DateTime(2025, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6120), new DateTime(2025, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6121), new DateTime(2025, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6120), new DateTime(2025, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6121), new DateTime(2025, 11, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6137), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6135), new DateTime(2024, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6136), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6136), new DateTime(2024, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6138), new DateTime(2024, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6142), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6141), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6141), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6142), new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6145), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6144), new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6145), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6144), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6146), new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6149), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6147), new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6148), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6148), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6149), new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6152), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6151), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6152), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6151), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6153), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6156), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6154), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6155), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6155), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6156), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6159), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6158), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6158), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6158), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6159), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6163), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6161), new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6162), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6162), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6163), new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6166), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6165), new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6166), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6165), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6167), new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6170), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6168), new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6169), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6169), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6170), new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6172), new DateTime(2025, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6172), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6172), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6176), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6175), new DateTime(2025, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6176), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6175), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6177), new DateTime(2025, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6179), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6178), new DateTime(2025, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6179), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6179), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6180), new DateTime(2025, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6188), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6187), new DateTime(2025, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6188), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6187), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6189), new DateTime(2025, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6192), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6190), new DateTime(2025, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6191), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6191), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6192), new DateTime(2025, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6195), new DateTime(2025, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6194), new DateTime(2025, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6194), new DateTime(2025, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6194), new DateTime(2025, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6195), new DateTime(2025, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6199), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6198), new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6199), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6198), new DateTime(2024, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6200), new DateTime(2024, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6204), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6203), new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6204), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6203), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6205), new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6208), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6206), new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6207), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6207), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6208), new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6211), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6210), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6211), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6210), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6212), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6215), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6214), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6214), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6214), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6215), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6218), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6217), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6218), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6217), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6219), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6222), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6221), new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6222), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6221), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6223), new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6226), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6224), new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6225), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6225), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6226), new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6229), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6228), new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6228), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6228), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6229), new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6232), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6231), new DateTime(2025, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6232), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6232), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6233), new DateTime(2025, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6236), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6235), new DateTime(2025, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6235), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6235), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6236), new DateTime(2025, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6239), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6238), new DateTime(2025, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6239), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6239), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6240), new DateTime(2025, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6243), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6242), new DateTime(2025, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6242), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6242), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6243), new DateTime(2025, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6246), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6245), new DateTime(2025, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6246), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6246), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6247), new DateTime(2025, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6250), new DateTime(2025, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6249), new DateTime(2025, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6249), new DateTime(2025, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6249), new DateTime(2025, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6250), new DateTime(2025, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6254), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6252), new DateTime(2024, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6254), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6253), new DateTime(2024, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6255), new DateTime(2024, 8, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6258), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6257), new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6258), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6258), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6259), new DateTime(2024, 9, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6262), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6260), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6261), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6261), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6262), new DateTime(2024, 10, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6265), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6264), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6265), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6264), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6266), new DateTime(2024, 11, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6268), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6267), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6268), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6268), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6269), new DateTime(2024, 12, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6272), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6270), new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6271), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6271), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6273), new DateTime(2025, 1, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6275), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6274), new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6275), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6274), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6276), new DateTime(2025, 2, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6278), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6277), new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6278), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6278), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6279), new DateTime(2025, 3, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6279) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6283), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6281), new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6282), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6282), new DateTime(2024, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6284), new DateTime(2024, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6287), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6286), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6287), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6286), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6288), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6291), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6290), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6290), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6290), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6291), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6294), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6293), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6294), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6293), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6295), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6298), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6296), new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6297), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6297), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6299), new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6301), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6300), new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6301), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6301), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6302), new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6311), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6310), new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6310), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6310), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6311), new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6315), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6314), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6315), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6314), new DateTime(2024, 10, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6316), new DateTime(2024, 10, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6320), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6318), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6319), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6319), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6320), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6324), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6322), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6323), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6323), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6324), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6327), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6326), new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6327), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6326), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6328), new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6331), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6329), new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6330), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6330), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6331), new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6334), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6332), new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6333), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6333), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6334), new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6337), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6336), new DateTime(2025, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6336), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6336), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6337), new DateTime(2025, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6340), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6339), new DateTime(2025, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6340), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6339), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6341), new DateTime(2025, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6343), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6342), new DateTime(2025, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6343), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6342), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6344), new DateTime(2025, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6347), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6345), new DateTime(2025, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6346), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6346), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6347), new DateTime(2025, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6350), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6349), new DateTime(2025, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6349), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6349), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6350), new DateTime(2025, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6355), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6353), new DateTime(2024, 11, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6354), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6353), new DateTime(2024, 11, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6355), new DateTime(2024, 11, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6359), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6358), new DateTime(2024, 12, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6359), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6358), new DateTime(2024, 12, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6360), new DateTime(2024, 12, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6363), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6361), new DateTime(2025, 1, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6362), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6362), new DateTime(2025, 1, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6363), new DateTime(2025, 1, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6366), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6365), new DateTime(2025, 2, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6366), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6366), new DateTime(2025, 2, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6367), new DateTime(2025, 2, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6370), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6369), new DateTime(2025, 3, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6369), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6369), new DateTime(2025, 3, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6370), new DateTime(2025, 3, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6373), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6372), new DateTime(2025, 4, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6373), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6372), new DateTime(2025, 4, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6374), new DateTime(2025, 4, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6377), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6375), new DateTime(2025, 5, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6376), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6376), new DateTime(2025, 5, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6377), new DateTime(2025, 5, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6380), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6379), new DateTime(2025, 6, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6379), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6379), new DateTime(2025, 6, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6380), new DateTime(2025, 6, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6383), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6382), new DateTime(2025, 7, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6383), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6382), new DateTime(2025, 7, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6384), new DateTime(2025, 7, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6387), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6385), new DateTime(2025, 8, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6386), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6386), new DateTime(2025, 8, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6387), new DateTime(2025, 8, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6390), new DateTime(2025, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6389), new DateTime(2025, 9, 25, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6389), new DateTime(2025, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6389), new DateTime(2025, 9, 11, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6390), new DateTime(2025, 9, 24, 11, 36, 11, 105, DateTimeKind.Utc).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentDate",
                value: new DateTime(2025, 11, 27, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentDate",
                value: new DateTime(2025, 11, 28, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SentDate",
                value: new DateTime(2025, 11, 29, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SentDate",
                value: new DateTime(2025, 11, 30, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SentDate",
                value: new DateTime(2025, 12, 1, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SentDate",
                value: new DateTime(2025, 12, 2, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SentDate",
                value: new DateTime(2025, 12, 3, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SentDate",
                value: new DateTime(2025, 12, 4, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SentDate",
                value: new DateTime(2025, 12, 5, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SentDate",
                value: new DateTime(2025, 12, 6, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SentDate",
                value: new DateTime(2025, 12, 6, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SentDate",
                value: new DateTime(2025, 12, 7, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SentDate",
                value: new DateTime(2025, 12, 8, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SentDate",
                value: new DateTime(2025, 12, 3, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SentDate",
                value: new DateTime(2025, 12, 4, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SentDate",
                value: new DateTime(2025, 12, 5, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SentDate",
                value: new DateTime(2025, 12, 7, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SentDate",
                value: new DateTime(2025, 12, 8, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SentDate",
                value: new DateTime(2025, 12, 9, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SentDate",
                value: new DateTime(2025, 12, 5, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SentDate",
                value: new DateTime(2025, 12, 6, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SentDate",
                value: new DateTime(2025, 12, 7, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SentDate",
                value: new DateTime(2025, 12, 8, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SentDate",
                value: new DateTime(2025, 12, 9, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SentDate",
                value: new DateTime(2025, 12, 10, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SentDate",
                value: new DateTime(2025, 12, 6, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SentDate",
                value: new DateTime(2025, 12, 7, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SentDate",
                value: new DateTime(2025, 12, 9, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SentDate",
                value: new DateTime(2025, 12, 10, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SentDate",
                value: new DateTime(2025, 12, 8, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SentDate",
                value: new DateTime(2025, 12, 9, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SentDate",
                value: new DateTime(2025, 12, 7, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SentDate",
                value: new DateTime(2025, 12, 8, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SentDate",
                value: new DateTime(2025, 12, 10, 11, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SentDate",
                value: new DateTime(2025, 12, 10, 23, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SentDate",
                value: new DateTime(2025, 12, 11, 5, 36, 11, 109, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateSubmitted",
                value: new DateTime(2024, 1, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateSubmitted",
                value: new DateTime(2023, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateSubmitted",
                value: new DateTime(2024, 1, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateSubmitted",
                value: new DateTime(2025, 4, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 25, 11, 36, 11, 108, DateTimeKind.Utc).AddTicks(9476));
        }
    }
}
