using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicBooksLoanAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixReviewSeedDataReviewerLogic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2023, 12, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(5685), new DateTime(2023, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(4775), new DateTime(2023, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(5448), new DateTime(2023, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(5107), new DateTime(2023, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(6283), new DateTime(2023, 12, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7274), new DateTime(2024, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7271), new DateTime(2024, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7273), new DateTime(2024, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7272), new DateTime(2024, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7275), new DateTime(2024, 1, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7279), new DateTime(2024, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7278), new DateTime(2024, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7279), new DateTime(2024, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7278), new DateTime(2024, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7280), new DateTime(2024, 2, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7283), new DateTime(2024, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7281), new DateTime(2024, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7282), new DateTime(2024, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7282), new DateTime(2024, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7283), new DateTime(2024, 3, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7286), new DateTime(2024, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7285), new DateTime(2024, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7286), new DateTime(2024, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7285), new DateTime(2024, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7287), new DateTime(2024, 4, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7292), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7291), new DateTime(2024, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7291), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7291), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7292), new DateTime(2024, 5, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7295), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7294), new DateTime(2024, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7295), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7294), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7296), new DateTime(2024, 6, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7299), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7298), new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7298), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7298), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7299), new DateTime(2024, 7, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7345), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7344), new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7345), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7344), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7346), new DateTime(2024, 8, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7350), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7348), new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7349), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7349), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7350), new DateTime(2024, 9, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7353), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7352), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7353), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7352), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7354), new DateTime(2024, 10, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7356), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7355), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7356), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7355), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7357), new DateTime(2024, 11, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7361), new DateTime(2024, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7359), new DateTime(2024, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7360), new DateTime(2024, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7360), new DateTime(2024, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7362), new DateTime(2024, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7366), new DateTime(2024, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7364), new DateTime(2024, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7365), new DateTime(2024, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7365), new DateTime(2024, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7366), new DateTime(2024, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7369), new DateTime(2024, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7368), new DateTime(2024, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7369), new DateTime(2024, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7369), new DateTime(2024, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7370), new DateTime(2024, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7373), new DateTime(2024, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7372), new DateTime(2024, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7373), new DateTime(2024, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7372), new DateTime(2024, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7374), new DateTime(2024, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7376), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7375), new DateTime(2024, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7376), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7376), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7377), new DateTime(2024, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7381), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7379), new DateTime(2024, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7380), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7380), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7381), new DateTime(2024, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7384), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7383), new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7384), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7383), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7385), new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7388), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7386), new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7387), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7387), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7388), new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7391), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7390), new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7391), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7390), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7392), new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7394), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7393), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7394), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7394), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7395), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7398), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7396), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7397), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7397), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7398), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7401), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7400), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7401), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7400), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7402), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7406), new DateTime(2024, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7404), new DateTime(2024, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7405), new DateTime(2024, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7405), new DateTime(2024, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7407), new DateTime(2024, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7410), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7409), new DateTime(2024, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7410), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7409), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7411), new DateTime(2024, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7414), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7413), new DateTime(2024, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7413), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7413), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7415), new DateTime(2024, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7417), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7416), new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7417), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7416), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7418), new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7421), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7419), new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7420), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7420), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7421), new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7424), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7422), new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7423), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7423), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7424), new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7427), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7426), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7427), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7426), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7428), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7430), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7429), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7430), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7429), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7431), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7434), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7432), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7433), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7433), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7434), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7455), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7453), new DateTime(2024, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7454), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7453), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7456), new DateTime(2024, 5, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7460), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7458), new DateTime(2024, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7459), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7459), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7460), new DateTime(2024, 6, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7463), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7462), new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7463), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7462), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7464), new DateTime(2024, 7, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7467), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7465), new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7466), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7466), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7467), new DateTime(2024, 8, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7471), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7469), new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7470), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7470), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7471), new DateTime(2024, 9, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7502), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7500), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7501), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7501), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7502), new DateTime(2024, 10, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7505), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7504), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7505), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7504), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7506), new DateTime(2024, 11, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7508), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7507), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7508), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7507), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7509), new DateTime(2024, 12, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7512), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7510), new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7512), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7511), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7512), new DateTime(2025, 1, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7516), new DateTime(2024, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7515), new DateTime(2024, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7516), new DateTime(2024, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7515), new DateTime(2024, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7517), new DateTime(2024, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7521), new DateTime(2024, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7520), new DateTime(2024, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7520), new DateTime(2024, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7520), new DateTime(2024, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7521), new DateTime(2024, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7524), new DateTime(2024, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7523), new DateTime(2024, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7524), new DateTime(2024, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7523), new DateTime(2024, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7525), new DateTime(2024, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7528), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7526), new DateTime(2024, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7527), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7527), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7528), new DateTime(2024, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7531), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7530), new DateTime(2024, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7531), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7530), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7532), new DateTime(2024, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7534), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7533), new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7534), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7533), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7535), new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7538), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7536), new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7537), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7537), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7538), new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7541), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7540), new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7541), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7540), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7541), new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7544), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7543), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7544), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7543), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7545), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7547), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7546), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7547), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7547), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7548), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7551), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7549), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7550), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7550), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7551), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7554), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7553), new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7554), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7553), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7555), new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7558), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7556), new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7557), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7557), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7558), new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7561), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7560), new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7560), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7560), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7561), new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7564), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7563), new DateTime(2025, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7564), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7563), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7565), new DateTime(2025, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7567), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7566), new DateTime(2025, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7567), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7566), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7568), new DateTime(2025, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7570), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7569), new DateTime(2025, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7570), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7569), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7571), new DateTime(2025, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7574), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7572), new DateTime(2025, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7573), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7573), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7574), new DateTime(2025, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7577), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7575), new DateTime(2025, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7576), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7576), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7577), new DateTime(2025, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7580), new DateTime(2025, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7579), new DateTime(2025, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7579), new DateTime(2025, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7579), new DateTime(2025, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7580), new DateTime(2025, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7583), new DateTime(2025, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7582), new DateTime(2025, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7583), new DateTime(2025, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7582), new DateTime(2025, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7584), new DateTime(2025, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7588), new DateTime(2024, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7586), new DateTime(2024, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7587), new DateTime(2024, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7586), new DateTime(2024, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7588), new DateTime(2024, 3, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7592), new DateTime(2024, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7591), new DateTime(2024, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7592), new DateTime(2024, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7591), new DateTime(2024, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7593), new DateTime(2024, 4, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7596), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7595), new DateTime(2024, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7596), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7595), new DateTime(2024, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7597), new DateTime(2024, 5, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7600), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7599), new DateTime(2024, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7600), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7599), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7600), new DateTime(2024, 6, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7629), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7628), new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7629), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7628), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7630), new DateTime(2024, 7, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7633), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7631), new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7632), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7632), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7633), new DateTime(2024, 8, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7636), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7635), new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7636), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7635), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7637), new DateTime(2024, 9, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7640), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7638), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7639), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7639), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7640), new DateTime(2024, 10, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7643), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7642), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7643), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7642), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7644), new DateTime(2024, 11, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7647), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7645), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7646), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7646), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7647), new DateTime(2024, 12, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7650), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7649), new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7650), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7649), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7651), new DateTime(2025, 1, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7654), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7653), new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7653), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7653), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7654), new DateTime(2025, 2, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7657), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7656), new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7657), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7656), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7658), new DateTime(2025, 3, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7660), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7659), new DateTime(2025, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7660), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7660), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7661), new DateTime(2025, 4, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7664), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7663), new DateTime(2025, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7663), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7663), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7664), new DateTime(2025, 5, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7667), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7666), new DateTime(2025, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7667), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7666), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7668), new DateTime(2025, 6, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7671), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7669), new DateTime(2025, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7670), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7670), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7671), new DateTime(2025, 7, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7674), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7673), new DateTime(2025, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7674), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7673), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7675), new DateTime(2025, 8, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7677), new DateTime(2025, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7676), new DateTime(2025, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7677), new DateTime(2025, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7677), new DateTime(2025, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7678), new DateTime(2025, 9, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7681), new DateTime(2025, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7680), new DateTime(2025, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7680), new DateTime(2025, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7680), new DateTime(2025, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7681), new DateTime(2025, 10, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7684), new DateTime(2025, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7683), new DateTime(2025, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7684), new DateTime(2025, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7683), new DateTime(2025, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7685), new DateTime(2025, 11, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7701), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7699), new DateTime(2024, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7700), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7700), new DateTime(2024, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7702), new DateTime(2024, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7705), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7704), new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7705), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7705), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7706), new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7709), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7708), new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7708), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7708), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7709), new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7712), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7711), new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7712), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7711), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7713), new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7716), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7714), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7715), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7715), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7716), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7719), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7718), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7719), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7718), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7720), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7722), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7721), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7722), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7721), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7723), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7726), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7724), new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7725), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7725), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7726), new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7729), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7728), new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7729), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7728), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7730), new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7733), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7731), new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7732), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7732), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7733), new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7736), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7735), new DateTime(2025, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7735), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7735), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7736), new DateTime(2025, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7739), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7738), new DateTime(2025, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7738), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7738), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7739), new DateTime(2025, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7742), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7741), new DateTime(2025, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7742), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7741), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7743), new DateTime(2025, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7745), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7744), new DateTime(2025, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7745), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7744), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7746), new DateTime(2025, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7748), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7747), new DateTime(2025, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7748), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7748), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7749), new DateTime(2025, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7752), new DateTime(2025, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7750), new DateTime(2025, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7751), new DateTime(2025, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7751), new DateTime(2025, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7752), new DateTime(2025, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7756), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7754), new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7756), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7755), new DateTime(2024, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7757), new DateTime(2024, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7761), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7759), new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7760), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7760), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7761), new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7795), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7794), new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7795), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7794), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7796), new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7799), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7797), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7798), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7798), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7799), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7802), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7801), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7802), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7802), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7803), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7806), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7805), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7805), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7805), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7806), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7810), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7808), new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7809), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7809), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7810), new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7813), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7812), new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7813), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7812), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7814), new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7816), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7815), new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7816), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7816), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7817), new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7820), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7819), new DateTime(2025, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7820), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7819), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7821), new DateTime(2025, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7822), new DateTime(2025, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7824), new DateTime(2025, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7827), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7826), new DateTime(2025, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7827), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7826), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7827), new DateTime(2025, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7830), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7829), new DateTime(2025, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7830), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7829), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7831), new DateTime(2025, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7834), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7832), new DateTime(2025, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7833), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7833), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7834), new DateTime(2025, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7837), new DateTime(2025, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7836), new DateTime(2025, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7837), new DateTime(2025, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7836), new DateTime(2025, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7837), new DateTime(2025, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7842), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7840), new DateTime(2024, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7841), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7840), new DateTime(2024, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7842), new DateTime(2024, 8, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7846), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7845), new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7845), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7845), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7846), new DateTime(2024, 9, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7849), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7848), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7849), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7848), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7850), new DateTime(2024, 10, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7852), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7851), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7852), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7851), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7853), new DateTime(2024, 11, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7853) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7856), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7854), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7855), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7855), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7856), new DateTime(2024, 12, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7859), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7857), new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7858), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7858), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7860), new DateTime(2025, 1, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7862), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7861), new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7862), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7861), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7863), new DateTime(2025, 2, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7865), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7864), new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7865), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7865), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7866), new DateTime(2025, 3, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7870), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7868), new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7870), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7869), new DateTime(2024, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7871), new DateTime(2024, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7875), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7873), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7874), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7874), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7875), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7878), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7877), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7878), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7877), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7879), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7881), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7880), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7881), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7881), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7882), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7885), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7883), new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7885), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7884), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7886), new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7889), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7887), new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7888), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7888), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7889), new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7913), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7912), new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7913), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7912), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7914), new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7918), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7916), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7917), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7916), new DateTime(2024, 10, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7919), new DateTime(2024, 10, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7922), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7921), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7922), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7921), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7923), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7926), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7924), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7925), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7925), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7926), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7929), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7928), new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7929), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7928), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7930), new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7932), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7931), new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7932), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7932), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7933), new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7936), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7934), new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7935), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7935), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7936), new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7939), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7938), new DateTime(2025, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7938), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7938), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7939), new DateTime(2025, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7942), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7941), new DateTime(2025, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7942), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7941), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7943), new DateTime(2025, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7945), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7944), new DateTime(2025, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7945), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7944), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7946), new DateTime(2025, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7948), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7947), new DateTime(2025, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7948), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7947), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7949), new DateTime(2025, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7951), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7950), new DateTime(2025, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7951), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7950), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7952), new DateTime(2025, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7956), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7954), new DateTime(2024, 11, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7955), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7955), new DateTime(2024, 11, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7957), new DateTime(2024, 11, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7961), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7959), new DateTime(2024, 12, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7960), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7960), new DateTime(2024, 12, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7961), new DateTime(2024, 12, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7964), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7963), new DateTime(2025, 1, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7964), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7963), new DateTime(2025, 1, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7965), new DateTime(2025, 1, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7968), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7967), new DateTime(2025, 2, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7967), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7967), new DateTime(2025, 2, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7968), new DateTime(2025, 2, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7971), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7970), new DateTime(2025, 3, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7971), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7970), new DateTime(2025, 3, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7972), new DateTime(2025, 3, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7975), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7973), new DateTime(2025, 4, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7974), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7974), new DateTime(2025, 4, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7975), new DateTime(2025, 4, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7978), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7977), new DateTime(2025, 5, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7978), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7977), new DateTime(2025, 5, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7979), new DateTime(2025, 5, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7981), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7980), new DateTime(2025, 6, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7981), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7981), new DateTime(2025, 6, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7982), new DateTime(2025, 6, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7985), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7984), new DateTime(2025, 7, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7984), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7984), new DateTime(2025, 7, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7985), new DateTime(2025, 7, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7988), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7987), new DateTime(2025, 8, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7988), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7987), new DateTime(2025, 8, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7989), new DateTime(2025, 8, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7991), new DateTime(2025, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7990), new DateTime(2025, 9, 23, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7991), new DateTime(2025, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7990), new DateTime(2025, 9, 9, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7992), new DateTime(2025, 9, 22, 15, 44, 28, 960, DateTimeKind.Utc).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Great experience, reliable lender.", new DateTime(2024, 1, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(237), 13, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 2, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(453), 14, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 3, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(455), 15, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 4, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(456), 16, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(457), 17, 6, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Great experience, reliable lender.", new DateTime(2024, 6, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(461), 18, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 7, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(462), 19, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(463), 20, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(464), 21, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 10, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(466), 22, 6, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Great experience, reliable lender.", new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(468), 23, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(469), 24, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Great borrower, took good care of comic.", new DateTime(2023, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(471), 1, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 1, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(472), 2, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 2, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(474), 3, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Excellent lender! Comic in perfect condition.", new DateTime(2024, 3, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(475), 4, 5, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 4, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(476), 5, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Great borrower, took good care of comic.", new DateTime(2024, 5, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(478), 6, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 6, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(480), 7, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 7, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(481), 8, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Excellent lender! Comic in perfect condition.", new DateTime(2024, 8, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(482), 9, 5, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(483), 10, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Great borrower, took good care of comic.", new DateTime(2024, 10, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(484), 11, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(486), 12, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(487), 34, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 6, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(489), 35, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 7, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(490), 36, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(491), 37, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(492), 38, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 10, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(493), 39, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(494), 40, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(495), 41, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 1, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(495), 42, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 4, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(499), 25, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(500), 26, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 6, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(501), 27, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 7, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(502), 28, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(503), 29, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(504), 30, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2024, 10, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(505), 31 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(506), 32 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(507), 33 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 3, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(528), 64, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2024, 3, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(530), 65, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2024, 4, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(531), 66, 6, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2024, 4, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(532), 67, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2024, 5, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(534), 68, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2024, 5, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(535), 69, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 6, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(536), 70, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2024, 6, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(537), 71, 6, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2024, 7, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(538), 72, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2024, 7, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(539), 73, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2024, 8, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(540), 74, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2024, 8, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(588), 75, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(590), 76, 6, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2024, 9, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(591), 77, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2024, 10, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(592), 78, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2024, 10, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(593), 79, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(594), 80, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(595), 81, 6, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(597), 82, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2024, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(598), 83, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable.", new DateTime(2025, 1, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(599), 84, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Comment", "CommunicationGood", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Good lender, recommended.", false, new DateTime(2024, 2, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(601), 43, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", new DateTime(2024, 2, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(602), 44, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", new DateTime(2024, 3, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(605), 45, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Comment", "CommunicationGood", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", true, new DateTime(2024, 3, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(606), 46, 5, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", new DateTime(2024, 4, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(607), 47, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", new DateTime(2024, 4, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(608), 48, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Comment", "CommunicationGood", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Good lender, recommended.", false, new DateTime(2024, 5, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(610), 49, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", new DateTime(2024, 5, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(611), 50, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", new DateTime(2024, 6, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(612), 51, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Comment", "CommunicationGood", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", true, new DateTime(2024, 6, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(613), 52, 5, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", new DateTime(2024, 7, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(614), 53, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", new DateTime(2024, 7, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(615), 54, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Comment", "CommunicationGood", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Good lender, recommended.", false, new DateTime(2024, 8, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(617), 55, 4, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", new DateTime(2024, 8, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(618), 56, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", new DateTime(2024, 9, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(619), 57, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Comment", "CommunicationGood", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", true, new DateTime(2024, 9, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(620), 58, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", new DateTime(2024, 10, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(621), 59, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", new DateTime(2024, 10, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(622), 60, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Comment", "CommunicationGood", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Good lender, recommended.", false, new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(624), 61, 4, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(624), 62, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing X-Men collection! Very knowledgeable.", new DateTime(2024, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(626), 63, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 7, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(628), 101, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic collection! Highly recommend.", new DateTime(2024, 7, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(629), 102, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic collection! Highly recommend.", new DateTime(2024, 8, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(630), 103, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic collection! Highly recommend.", new DateTime(2024, 8, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(632), 104, 6, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic collection! Highly recommend.", new DateTime(2024, 9, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(633), 105, 5, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic collection! Highly recommend.", new DateTime(2024, 9, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(634), 106, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic collection! Highly recommend.", new DateTime(2024, 10, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(635), 107, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic collection! Highly recommend.", new DateTime(2024, 10, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(636), 108, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic collection! Highly recommend.", new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(637), 109, 6, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic collection! Highly recommend.", new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(638), 110, 5, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(639), 111, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic collection! Highly recommend.", new DateTime(2024, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(640), 112, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic collection! Highly recommend.", new DateTime(2025, 1, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(641), 113, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic collection! Highly recommend.", new DateTime(2025, 1, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(643), 114, 6, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic collection! Highly recommend.", new DateTime(2025, 2, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(644), 115, 5, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating" },
                values: new object[] { "Good experience overall.", new DateTime(2024, 6, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(646), 85, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2024, 6, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(647), 86 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2024, 7, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(648), 87 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2024, 7, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(649), 88 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(650), 89 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2024, 8, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(651), 90, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(652), 91 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(653), 92 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2024, 10, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(654), 93 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2024, 10, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(655), 94 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating" },
                values: new object[] { "Good experience overall.", new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(657), 95, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(658), 96 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(659), 97 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(660), 98 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2025, 1, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(661), 99 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2025, 1, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(662), 100, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(664), 124, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Great collection! Love the variety.", new DateTime(2024, 10, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(666), 125, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Great collection! Love the variety.", new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(667), 126, 3, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(668), 127, 4, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Great collection! Love the variety.", new DateTime(2025, 1, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(669), 128, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Great collection! Love the variety.", new DateTime(2025, 2, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(670), 129, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 3, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(672), 130, 3, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "MeetupExperience", "Rating", "ReviewerId" },
                values: new object[] { "Good lender, comics as described.", new DateTime(2024, 8, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(674), 116, false, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(675), 117, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "MeetupExperience", "Rating", "ReviewerId" },
                values: new object[] { "Great indie collection! Love the variety.", new DateTime(2024, 10, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(676), 118, true, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "MeetupExperience", "Rating", "ReviewerId" },
                values: new object[] { "Good lender, comics as described.", new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(677), 119, false, 4, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(679), 120, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "MeetupExperience", "Rating", "ReviewerId" },
                values: new object[] { "Great indie collection! Love the variety.", new DateTime(2025, 1, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(680), 121, true, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "MeetupExperience", "Rating", "ReviewerId" },
                values: new object[] { "Good lender, comics as described.", new DateTime(2025, 2, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(681), 122, false, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 3, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(709), 123, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(711), 142, 1, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent collection! Very punctual.", new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(712), 143, 2, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent collection! Very punctual.", new DateTime(2024, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(713), 144, 3, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent collection! Very punctual.", new DateTime(2024, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(714), 145, 4, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent collection! Very punctual.", new DateTime(2025, 1, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(715), 146, 5, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent collection! Very punctual.", new DateTime(2025, 1, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(717), 147, 1, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(718), 148, 2, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent collection! Very punctual.", new DateTime(2025, 2, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(719), 149, 3, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent collection! Very punctual.", new DateTime(2025, 3, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(720), 150, 4, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent collection! Very punctual.", new DateTime(2025, 3, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(721), 151, 5, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent collection! Very punctual.", new DateTime(2025, 4, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(722), 152, 1, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Great experience, would lend again.", new DateTime(2024, 10, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(724), 131, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Excellent horror collection! Very punctual.", new DateTime(2024, 10, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(726), 132, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(727), 133, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(728), 134, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(729), 135, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(730), 136, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Great experience, would lend again.", new DateTime(2025, 1, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(731), 137, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Excellent horror collection! Very punctual.", new DateTime(2025, 1, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(732), 138, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(733), 139, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(734), 140, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 3, 23, 15, 44, 28, 962, DateTimeKind.Utc).AddTicks(735), 141, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2023, 12, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(8049), new DateTime(2023, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(6940), new DateTime(2023, 12, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(7801), new DateTime(2023, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(7419), new DateTime(2023, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(8670), new DateTime(2023, 12, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9727), new DateTime(2024, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9724), new DateTime(2024, 1, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9726), new DateTime(2024, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9725), new DateTime(2024, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9728), new DateTime(2024, 1, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9733), new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9732), new DateTime(2024, 2, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9732), new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9732), new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9734), new DateTime(2024, 2, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9737), new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9735), new DateTime(2024, 3, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9736), new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9736), new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9738), new DateTime(2024, 3, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9741), new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9740), new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9741), new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9740), new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9742), new DateTime(2024, 4, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9753), new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9751), new DateTime(2024, 5, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9752), new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9752), new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9753), new DateTime(2024, 5, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9756), new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9755), new DateTime(2024, 6, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9756), new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9755), new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9757), new DateTime(2024, 6, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9760), new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9758), new DateTime(2024, 7, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9759), new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9759), new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9760), new DateTime(2024, 7, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9763), new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9762), new DateTime(2024, 8, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9762), new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9762), new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9763), new DateTime(2024, 8, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9767), new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9766), new DateTime(2024, 9, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9766), new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9766), new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9767), new DateTime(2024, 9, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9770), new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9769), new DateTime(2024, 10, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9770), new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9769), new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9771), new DateTime(2024, 10, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9774), new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9772), new DateTime(2024, 11, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9773), new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9773), new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9774), new DateTime(2024, 11, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9778), new DateTime(2024, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9776), new DateTime(2024, 1, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9778), new DateTime(2024, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9777), new DateTime(2024, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9779), new DateTime(2024, 1, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9783), new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9782), new DateTime(2024, 2, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9783), new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9782), new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9784), new DateTime(2024, 2, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9787), new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9785), new DateTime(2024, 3, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9786), new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9786), new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9787), new DateTime(2024, 3, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9790), new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9789), new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9790), new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9789), new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9791), new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9794), new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9792), new DateTime(2024, 5, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9793), new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9793), new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9794), new DateTime(2024, 5, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9798), new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9797), new DateTime(2024, 6, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9798), new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9797), new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9799), new DateTime(2024, 6, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9802), new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9800), new DateTime(2024, 7, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9801), new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9801), new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9802), new DateTime(2024, 7, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9881), new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9880), new DateTime(2024, 8, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9881), new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9880), new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9882), new DateTime(2024, 8, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9885), new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9884), new DateTime(2024, 9, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9885), new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9884), new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9886), new DateTime(2024, 9, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9889), new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9887), new DateTime(2024, 10, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9888), new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9888), new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9889), new DateTime(2024, 10, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9892), new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9891), new DateTime(2024, 11, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9892), new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9891), new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9893), new DateTime(2024, 11, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9896), new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9894), new DateTime(2024, 12, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9895), new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9895), new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9896), new DateTime(2024, 12, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9900), new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9898), new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9900), new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9899), new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9901), new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9905), new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9904), new DateTime(2024, 5, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9905), new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9904), new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9906), new DateTime(2024, 5, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9909), new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9908), new DateTime(2024, 6, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9908), new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9908), new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9909), new DateTime(2024, 6, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9912), new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9911), new DateTime(2024, 7, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9912), new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9911), new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9913), new DateTime(2024, 7, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9916), new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9914), new DateTime(2024, 8, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9915), new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9915), new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9916), new DateTime(2024, 8, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9919), new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9918), new DateTime(2024, 9, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9919), new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9918), new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9920), new DateTime(2024, 9, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9922), new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9921), new DateTime(2024, 10, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9922), new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9922), new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9923), new DateTime(2024, 10, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9926), new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9925), new DateTime(2024, 11, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9926), new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9925), new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9927), new DateTime(2024, 11, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9929), new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9928), new DateTime(2024, 12, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9929), new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9928), new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9930), new DateTime(2024, 12, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9955), new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9952), new DateTime(2024, 5, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9954), new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9953), new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9956), new DateTime(2024, 5, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9960), new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9959), new DateTime(2024, 6, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9959), new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9959), new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9960), new DateTime(2024, 6, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9964), new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9962), new DateTime(2024, 7, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9963), new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9963), new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9964), new DateTime(2024, 7, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9967), new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9966), new DateTime(2024, 8, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9967), new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9966), new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9967), new DateTime(2024, 8, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9970), new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9969), new DateTime(2024, 9, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9970), new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9969), new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9971), new DateTime(2024, 9, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9974), new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9973), new DateTime(2024, 10, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9973), new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9973), new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9974), new DateTime(2024, 10, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9977), new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9976), new DateTime(2024, 11, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9977), new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9976), new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9978), new DateTime(2024, 11, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9981), new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9979), new DateTime(2024, 12, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9980), new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9980), new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9981), new DateTime(2024, 12, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9985), new DateTime(2025, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9983), new DateTime(2025, 1, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9985), new DateTime(2025, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9984), new DateTime(2025, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9986), new DateTime(2025, 1, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9990), new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9988), new DateTime(2024, 2, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9989), new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9989), new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9991), new DateTime(2024, 2, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9995), new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9993), new DateTime(2024, 3, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9994), new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9994), new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9995), new DateTime(2024, 3, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9998), new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9997), new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9998), new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9997), new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9999), new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(2), new DateTime(2024, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc), new DateTime(2024, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(1), new DateTime(2024, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(1), new DateTime(2024, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(2), new DateTime(2024, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(5), new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(4), new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(4), new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(4), new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(5), new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(8), new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(7), new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(8), new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(7), new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9), new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(12), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(10), new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(11), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(11), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(12), new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(15), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(14), new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(15), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(14), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(16), new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(18), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(17), new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(18), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(18), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(19), new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(52), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(51), new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(52), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(51), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(53), new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(56), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(54), new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(55), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(55), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(56), new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(59), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(58), new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(59), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(58), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(60), new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(63), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(62), new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(63), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(62), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(64), new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(66), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(65), new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(66), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(66), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(67), new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(70), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(69), new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(69), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(69), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(70), new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(73), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(72), new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(73), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(72), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(74), new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(76), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(75), new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(76), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(76), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(77), new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(80), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(78), new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(79), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(79), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(80), new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(83), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(82), new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(82), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(82), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(83), new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(86), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(85), new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(86), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(85), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(87), new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(89), new DateTime(2025, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(88), new DateTime(2025, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(89), new DateTime(2025, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(89), new DateTime(2025, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(90), new DateTime(2025, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(94), new DateTime(2024, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(92), new DateTime(2024, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(93), new DateTime(2024, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(93), new DateTime(2024, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(95), new DateTime(2024, 3, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(99), new DateTime(2024, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(98), new DateTime(2024, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(98), new DateTime(2024, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(98), new DateTime(2024, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(99), new DateTime(2024, 4, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(104), new DateTime(2024, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(102), new DateTime(2024, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(103), new DateTime(2024, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(103), new DateTime(2024, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(104), new DateTime(2024, 5, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(107), new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(106), new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(107), new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(107), new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(108), new DateTime(2024, 6, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(111), new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(110), new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(110), new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(110), new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(111), new DateTime(2024, 7, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(114), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(113), new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(114), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(113), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(115), new DateTime(2024, 8, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(118), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(117), new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(117), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(117), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(118), new DateTime(2024, 9, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(121), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(121), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(122), new DateTime(2024, 10, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(125), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(124), new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(125), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(124), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(126), new DateTime(2024, 11, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(129), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(127), new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(128), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(128), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(129), new DateTime(2024, 12, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(132), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(131), new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(132), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(131), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(133), new DateTime(2025, 1, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(136), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(135), new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(136), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(135), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(136), new DateTime(2025, 2, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(139), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(138), new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(139), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(138), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(140), new DateTime(2025, 3, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(143), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(142), new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(142), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(142), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(143), new DateTime(2025, 4, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(146), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(145), new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(146), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(145), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(147), new DateTime(2025, 5, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(150), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(148), new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(149), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(149), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(150), new DateTime(2025, 6, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(153), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(152), new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(153), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(152), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 7, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(183), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(182), new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(182), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(182), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(183), new DateTime(2025, 8, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(186), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(185), new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(186), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(186), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(187), new DateTime(2025, 9, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(190), new DateTime(2025, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(189), new DateTime(2025, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(189), new DateTime(2025, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(189), new DateTime(2025, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(190), new DateTime(2025, 10, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(193), new DateTime(2025, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(192), new DateTime(2025, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(193), new DateTime(2025, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(192), new DateTime(2025, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(194), new DateTime(2025, 11, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(211), new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(209), new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(210), new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(209), new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(212), new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(216), new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(214), new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(215), new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(215), new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(216), new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(219), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(218), new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(219), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(218), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(220), new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(223), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(221), new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(222), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(222), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(223), new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(226), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(225), new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(226), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(225), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(227), new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(228), new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(229), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(229), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(233), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(232), new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(233), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(232), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(233), new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(237), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(235), new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(236), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(236), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(237), new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(240), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(239), new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(240), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(239), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(241), new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(244), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(242), new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(243), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(243), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(244), new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(247), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(246), new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(247), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(246), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(247), new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(250), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(249), new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(250), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(249), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(253), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(252), new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(253), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(253), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(254), new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(257), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(256), new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(256), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(256), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(257), new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(260), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(259), new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(260), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(259), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(261), new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(263), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(262), new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(263), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(262), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(264), new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(268), new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(266), new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(267), new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(267), new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(269), new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(273), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(271), new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(272), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(272), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(273), new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(277), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(275), new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(276), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(276), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(277), new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(280), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(279), new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(280), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(279), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(281), new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(284), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(283), new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(283), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(283), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(284), new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(288), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(286), new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(287), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(287), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(288), new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(291), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(290), new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(291), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(290), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(292), new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(295), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(294), new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(295), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(294), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(296), new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(298), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(297), new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(298), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(298), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(299), new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(302), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(301), new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(302), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(301), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(303), new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(306), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(304), new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(305), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(305), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(306), new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(309), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(308), new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(309), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(308), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(310), new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(312), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(311), new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(312), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(312), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(313), new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(316), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(315), new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(315), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(315), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(316), new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(319), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(318), new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(319), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(319), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(320), new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(363), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(360), new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(362), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(361), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(363), new DateTime(2024, 8, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(367), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(366), new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(367), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(366), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(368), new DateTime(2024, 9, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(371), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(369), new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(370), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(370), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(371), new DateTime(2024, 10, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(374), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(373), new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(373), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(373), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(374), new DateTime(2024, 11, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(377), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(376), new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(377), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(376), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(378), new DateTime(2024, 12, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(381), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(379), new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(380), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(380), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(381), new DateTime(2025, 1, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(384), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(383), new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(384), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(383), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(385), new DateTime(2025, 2, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(387), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(386), new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(387), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(387), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(388), new DateTime(2025, 3, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(392), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(390), new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(392), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(391), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(393), new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(397), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(396), new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(396), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(396), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(397), new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(400), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(399), new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(400), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(399), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(401), new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(404), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(403), new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(403), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(403), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(404), new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(408), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(406), new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(407), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(407), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(408), new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(411), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(410), new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(411), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(410), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(412), new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(417), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(415), new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(416), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(416), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(417), new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(421), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(419), new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(420), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(420), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(422), new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(426), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(424), new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(425), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(425), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(426), new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(429), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(428), new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(429), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(428), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(430), new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(433), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(431), new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(432), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(432), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(433), new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(436), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(435), new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(436), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(435), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(437), new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(440), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(438), new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(439), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(439), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(440), new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(443), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(442), new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(442), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(442), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(444), new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(446), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(445), new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(446), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(445), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(447), new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(449), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(448), new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(449), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(449), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(450), new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(453), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(451), new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(453), new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(481), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(480), new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(481), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(480), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(482), new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(486), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(484), new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(486), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(485), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(487), new DateTime(2024, 11, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(491), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(490), new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(491), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(490), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(492), new DateTime(2024, 12, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(495), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(494), new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(495), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(494), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(496), new DateTime(2025, 1, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(499), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(498), new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(499), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(498), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(500), new DateTime(2025, 2, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(503), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(501), new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(502), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(502), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(503), new DateTime(2025, 3, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(506), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(505), new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(505), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(505), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(506), new DateTime(2025, 4, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(509), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(508), new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(509), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(509), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(510), new DateTime(2025, 5, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(513), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(512), new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(512), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(512), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(513), new DateTime(2025, 6, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(516), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(515), new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(516), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(515), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(517), new DateTime(2025, 7, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(520), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(518), new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(519), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(519), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(520), new DateTime(2025, 8, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(523), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(522), new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(522), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(522), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(524), new DateTime(2025, 9, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Great experience, reliable borrower.", new DateTime(2023, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9627), 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9849), 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9852), 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9853), 4, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9854), 5, 1, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Great experience, reliable borrower.", new DateTime(2024, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9858), 6, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9859), 7, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9860), 8, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9861), 9, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9909), 10, 1, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Great experience, reliable borrower.", new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9911), 11, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9912), 12, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Excellent lender! Comic in perfect condition.", new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9913), 13, 5, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9914), 14, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9915), 15, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Great experience, reliable borrower.", new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9916), 16, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9917), 17, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Excellent lender! Comic in perfect condition.", new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9919), 18, 5, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9920), 19, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9921), 20, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Great experience, reliable borrower.", new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9922), 21, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9924), 22, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Excellent lender! Comic in perfect condition.", new DateTime(2025, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9925), 23, 5, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9926), 24, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9928), 25, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9930), 26, 2, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9931), 27, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9932), 28, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9933), 29, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9934), 30, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9935), 31, 2, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9936), 32, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9937), 33, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9939), 34, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9940), 35, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9941), 36, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9942), 37, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9943), 38, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9944), 39, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9945), 40 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9946), 41 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9947), 42 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9949), 43, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9950), 44, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9952), 45, 3, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9953), 46, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9954), 47, 3, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9955), 48, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9957), 49, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9958), 50, 3, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9959), 51, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9960), 52, 3, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9962), 53, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9963), 54, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9964), 55, 3, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9965), 56, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9966), 57, 3, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9967), 58, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9968), 59, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9969), 60, 3, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9971), 61, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9972), 62, 3, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9973), 63, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Comment", "CommunicationGood", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", true, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9974), 64, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9976), 65, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9978), 66, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Comment", "CommunicationGood", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Great lender, minor delay but good communication.", false, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9979), 67, 4, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9980), 68, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9981), 69, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Comment", "CommunicationGood", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", true, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9982), 70, 5, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9984), 71, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9985), 72, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Comment", "CommunicationGood", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Great lender, minor delay but good communication.", false, new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9986), 73, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9987), 74, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9988), 75, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Comment", "CommunicationGood", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", true, new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9989), 76, 5, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9990), 77, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9991), 78, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Comment", "CommunicationGood", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Great lender, minor delay but good communication.", false, new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9992), 79, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2025, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(20), 80, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2025, 9, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(21), 81, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Comment", "CommunicationGood", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", true, new DateTime(2025, 9, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(22), 82, 5, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2025, 10, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(23), 83, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { "Amazing collection! Very knowledgeable about X-Men.", new DateTime(2025, 10, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(24), 84, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 6, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(26), 85, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2024, 6, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(28), 86, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2024, 7, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(29), 87, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2024, 7, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(30), 88, 4, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2024, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(31), 89, 4, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2024, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(32), 90, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2024, 9, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(33), 91, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2024, 9, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(34), 92, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2024, 10, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(35), 93, 4, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2024, 10, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(36), 94, 4, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 11, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(38), 95, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2024, 11, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(39), 96, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2024, 12, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(40), 97, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2024, 12, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(41), 98, 4, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2025, 1, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(42), 99, 4, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2025, 1, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(43), 100, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(44), 101 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(45), 102 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2025, 3, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(46), 103 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2025, 3, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(48), 104 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating" },
                values: new object[] { "Good experience overall.", new DateTime(2025, 4, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(49), 105, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2025, 4, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(50), 106 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2025, 5, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(51), 107 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2025, 5, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(52), 108 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2025, 6, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(53), 109 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating" },
                values: new object[] { "Fantastic DC collection! Highly recommend.", new DateTime(2025, 6, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(55), 110, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2025, 7, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(56), 111 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2025, 7, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(57), 112 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2025, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(58), 113 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateSubmitted", "LoanId" },
                values: new object[] { new DateTime(2025, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(59), 114 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating" },
                values: new object[] { "Good experience overall.", new DateTime(2025, 9, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(60), 115, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(62), 116, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Great indie collection! Love the variety.", new DateTime(2024, 9, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(64), 117, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Great indie collection! Love the variety.", new DateTime(2024, 10, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(65), 118, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 11, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(66), 119, 5, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Great indie collection! Love the variety.", new DateTime(2024, 12, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(67), 120, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Great indie collection! Love the variety.", new DateTime(2025, 1, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(69), 121, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(70), 122, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "MeetupExperience", "Rating", "ReviewerId" },
                values: new object[] { "Great indie collection! Love the variety.", new DateTime(2025, 3, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(71), 123, true, 5, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 4, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(72), 124, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "MeetupExperience", "Rating", "ReviewerId" },
                values: new object[] { "Good lender, comics as described.", new DateTime(2025, 5, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(73), 125, false, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "MeetupExperience", "Rating", "ReviewerId" },
                values: new object[] { "Great indie collection! Love the variety.", new DateTime(2025, 6, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(75), 126, true, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 7, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(76), 127, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "MeetupExperience", "Rating", "ReviewerId" },
                values: new object[] { "Good lender, comics as described.", new DateTime(2025, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(77), 128, false, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "MeetupExperience", "Rating", "ReviewerId" },
                values: new object[] { "Great indie collection! Love the variety.", new DateTime(2025, 9, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(78), 129, true, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 10, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(80), 130, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2024, 10, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(82), 131, 6, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent horror collection! Very punctual.", new DateTime(2024, 10, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(84), 132, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent horror collection! Very punctual.", new DateTime(2024, 11, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(85), 133, 6, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent horror collection! Very punctual.", new DateTime(2024, 11, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(86), 134, 6, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent horror collection! Very punctual.", new DateTime(2024, 12, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(87), 135, 6, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent horror collection! Very punctual.", new DateTime(2024, 12, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(88), 136, 6, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(90), 137, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent horror collection! Very punctual.", new DateTime(2025, 1, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(91), 138, 6, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent horror collection! Very punctual.", new DateTime(2025, 2, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(92), 139, 6, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent horror collection! Very punctual.", new DateTime(2025, 2, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(93), 140, 6, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "ReviewedUserId", "ReviewerId" },
                values: new object[] { "Excellent horror collection! Very punctual.", new DateTime(2025, 3, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(94), 141, 6, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Excellent horror collection! Very punctual.", new DateTime(2025, 3, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(95), 142, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Great experience, would borrow again.", new DateTime(2025, 4, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(96), 143, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 4, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(98), 144, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 5, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(99), 145, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 5, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(99), 146, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 6, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(100), 147, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Excellent horror collection! Very punctual.", new DateTime(2025, 6, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(102), 148, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Comment", "DateSubmitted", "LoanId", "Rating", "ReviewerId" },
                values: new object[] { "Great experience, would borrow again.", new DateTime(2025, 7, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(103), 149, 4, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 7, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(123), 150, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(124), 151, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateSubmitted", "LoanId", "ReviewerId" },
                values: new object[] { new DateTime(2025, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(125), 152, 2 });
        }
    }
}
