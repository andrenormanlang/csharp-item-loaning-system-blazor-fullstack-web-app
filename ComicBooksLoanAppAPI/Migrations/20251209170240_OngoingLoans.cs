using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComicBooksLoanAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class OngoingLoans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(3392), new DateTime(2023, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(2455), new DateTime(2023, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(3159), new DateTime(2023, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(2812), new DateTime(2023, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(3990), new DateTime(2023, 12, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5224), new DateTime(2024, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5220), new DateTime(2024, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5223), new DateTime(2024, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5222), new DateTime(2024, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5225), new DateTime(2024, 1, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5230), new DateTime(2024, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5228), new DateTime(2024, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5229), new DateTime(2024, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5229), new DateTime(2024, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5230), new DateTime(2024, 2, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5233), new DateTime(2024, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5232), new DateTime(2024, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5233), new DateTime(2024, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5232), new DateTime(2024, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5234), new DateTime(2024, 3, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5237), new DateTime(2024, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5235), new DateTime(2024, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5236), new DateTime(2024, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5236), new DateTime(2024, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5237), new DateTime(2024, 4, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5245), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5244), new DateTime(2024, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5245), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5244), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5246), new DateTime(2024, 5, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5249), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5247), new DateTime(2024, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5248), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5248), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5249), new DateTime(2024, 6, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5252), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5251), new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5252), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5251), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5253), new DateTime(2024, 7, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5256), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5255), new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5256), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5255), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5257), new DateTime(2024, 8, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5294), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5292), new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5293), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5293), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5294), new DateTime(2024, 9, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5298), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5296), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5297), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5297), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5298), new DateTime(2024, 10, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5301), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5300), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5300), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5300), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5301), new DateTime(2024, 11, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5305), new DateTime(2024, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5304), new DateTime(2024, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5305), new DateTime(2024, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5304), new DateTime(2024, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5306), new DateTime(2024, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5310), new DateTime(2024, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5309), new DateTime(2024, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5309), new DateTime(2024, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5309), new DateTime(2024, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5310), new DateTime(2024, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5313), new DateTime(2024, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5312), new DateTime(2024, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5313), new DateTime(2024, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5313), new DateTime(2024, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5314), new DateTime(2024, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5317), new DateTime(2024, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5316), new DateTime(2024, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5317), new DateTime(2024, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5316), new DateTime(2024, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5318), new DateTime(2024, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5321), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5319), new DateTime(2024, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5320), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5320), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5321), new DateTime(2024, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5325), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5324), new DateTime(2024, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5325), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5324), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5326), new DateTime(2024, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5329), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5328), new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5329), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5328), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5330), new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5333), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5331), new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5332), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5332), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5333), new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5336), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5335), new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5336), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5335), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5337), new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5340), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5338), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5339), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5339), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5340), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5343), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5342), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5343), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5342), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5344), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5615), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5613), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5614), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5614), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5615), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5619), new DateTime(2024, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5617), new DateTime(2024, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5619), new DateTime(2024, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5618), new DateTime(2024, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5620), new DateTime(2024, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5624), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5622), new DateTime(2024, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5623), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5623), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5624), new DateTime(2024, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5627), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5626), new DateTime(2024, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5627), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5626), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5628), new DateTime(2024, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5630), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5629), new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5630), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5629), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5631), new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5634), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5632), new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5633), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5633), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5634), new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5637), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5636), new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5637), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5636), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5638), new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5640), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5639), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5640), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5640), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5641), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5644), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5643), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5643), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5643), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5644), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5647), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5646), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5647), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5646), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5648), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5668), new DateTime(2024, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5669), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5669), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5671), new DateTime(2024, 5, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5675), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5673), new DateTime(2024, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5674), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5674), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5675), new DateTime(2024, 6, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5678), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5677), new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5678), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5677), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5679), new DateTime(2024, 7, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5682), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5680), new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5681), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5681), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5682), new DateTime(2024, 8, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5685), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5684), new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5685), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5684), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5686), new DateTime(2024, 9, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5688), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5687), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5688), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5688), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5689), new DateTime(2024, 10, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5692), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5691), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5691), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5691), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5692), new DateTime(2024, 11, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5695), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5694), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5695), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5694), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5696), new DateTime(2024, 12, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5699), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5697), new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5698), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5698), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5699), new DateTime(2025, 1, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5703), new DateTime(2024, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5702), new DateTime(2024, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5703), new DateTime(2024, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5702), new DateTime(2024, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5704), new DateTime(2024, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5708), new DateTime(2024, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5706), new DateTime(2024, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5707), new DateTime(2024, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5707), new DateTime(2024, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5708), new DateTime(2024, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5711), new DateTime(2024, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5710), new DateTime(2024, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5711), new DateTime(2024, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5710), new DateTime(2024, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5711), new DateTime(2024, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5714), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5713), new DateTime(2024, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5714), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5713), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5715), new DateTime(2024, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5718), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5716), new DateTime(2024, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5717), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5717), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5718), new DateTime(2024, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5721), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5720), new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5720), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5720), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5721), new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5724), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5723), new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5724), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5723), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5725), new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5727), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5726), new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5727), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5727), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5728), new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5731), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5729), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5730), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5730), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5731), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5734), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5733), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5733), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5733), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5734), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5737), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5736), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5737), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5736), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5738), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5741), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5739), new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5740), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5740), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5742), new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5744), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5743), new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5744), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5743), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5745), new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5791), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5790), new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5791), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5790), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5792), new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5795), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5793), new DateTime(2025, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5794), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5794), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5795), new DateTime(2025, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5798), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5796), new DateTime(2025, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5797), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5797), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5798), new DateTime(2025, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5801), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5800), new DateTime(2025, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5800), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5800), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5801), new DateTime(2025, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5804), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5803), new DateTime(2025, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5804), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5803), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5805), new DateTime(2025, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5807), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5806), new DateTime(2025, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5807), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5806), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5808), new DateTime(2025, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5810), new DateTime(2025, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5809), new DateTime(2025, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5810), new DateTime(2025, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5810), new DateTime(2025, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5811), new DateTime(2025, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5814), new DateTime(2025, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5813), new DateTime(2025, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5813), new DateTime(2025, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5813), new DateTime(2025, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5814), new DateTime(2025, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5828), new DateTime(2024, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5829), new DateTime(2024, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5829), new DateTime(2024, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5831), new DateTime(2024, 3, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5834), new DateTime(2024, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5833), new DateTime(2024, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5834), new DateTime(2024, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5834), new DateTime(2024, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5835), new DateTime(2024, 4, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5839), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5837), new DateTime(2024, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5838), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5838), new DateTime(2024, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5839), new DateTime(2024, 5, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5842), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5841), new DateTime(2024, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5842), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5842), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5843), new DateTime(2024, 6, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5846), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5845), new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5846), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5845), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5847), new DateTime(2024, 7, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5850), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5848), new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5849), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5849), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5850), new DateTime(2024, 8, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5853), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5852), new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5853), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5852), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5854), new DateTime(2024, 9, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5857), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5855), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5856), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5856), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5857), new DateTime(2024, 10, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5860), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5859), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5860), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5859), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5861), new DateTime(2024, 11, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5864), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5862), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5863), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5863), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5864), new DateTime(2024, 12, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5868), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5866), new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5867), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5866), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5868), new DateTime(2025, 1, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5871), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5870), new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5871), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5870), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5872), new DateTime(2025, 2, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5874), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5873), new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5874), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5874), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5875), new DateTime(2025, 3, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5878), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5877), new DateTime(2025, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5878), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5877), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5879), new DateTime(2025, 4, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5881), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5880), new DateTime(2025, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5881), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5880), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5882), new DateTime(2025, 5, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5885), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5883), new DateTime(2025, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5884), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5884), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5885), new DateTime(2025, 6, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5888), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5887), new DateTime(2025, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5888), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5887), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5888), new DateTime(2025, 7, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5891), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5890), new DateTime(2025, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5891), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5890), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5892), new DateTime(2025, 8, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5895), new DateTime(2025, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5893), new DateTime(2025, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5894), new DateTime(2025, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5894), new DateTime(2025, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5895), new DateTime(2025, 9, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5898), new DateTime(2025, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5897), new DateTime(2025, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5898), new DateTime(2025, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5897), new DateTime(2025, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5898), new DateTime(2025, 10, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5901), new DateTime(2025, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5900), new DateTime(2025, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5901), new DateTime(2025, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5900), new DateTime(2025, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5902), new DateTime(2025, 11, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5906), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5904), new DateTime(2024, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5905), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5905), new DateTime(2024, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5907), new DateTime(2024, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5970), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5969), new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5970), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5969), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5971), new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5974), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5972), new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5973), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5973), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5974), new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5977), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5976), new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5977), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5976), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5978), new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5981), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5979), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5980), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5980), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5981), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5984), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5983), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5984), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5983), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5984), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5987), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5986), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5987), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5986), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5988), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5991), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5989), new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5990), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5990), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5992), new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5994), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5993), new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5994), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5993), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5995), new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5998), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5996), new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5997), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5997), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5998), new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6001), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6000), new DateTime(2025, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6000), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6000), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6001), new DateTime(2025, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6004), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6003), new DateTime(2025, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6003), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6003), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6004), new DateTime(2025, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6007), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6006), new DateTime(2025, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6007), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6006), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6008), new DateTime(2025, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6011), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6009), new DateTime(2025, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6010), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6010), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6011), new DateTime(2025, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6014), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6013), new DateTime(2025, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6013), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6013), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6014), new DateTime(2025, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6017), new DateTime(2025, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6016), new DateTime(2025, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6017), new DateTime(2025, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6016), new DateTime(2025, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6017), new DateTime(2025, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6022), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6020), new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6021), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6020), new DateTime(2024, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6022), new DateTime(2024, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6026), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6025), new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6026), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6025), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6027), new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6030), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6028), new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6029), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6029), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6030), new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6033), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6032), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6033), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6032), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6034), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6037), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6036), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6036), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6036), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6037), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6040), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6039), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6040), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6039), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6041), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6044), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6042), new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6043), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6043), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6045), new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6047), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6046), new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6047), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6046), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6048), new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6051), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6049), new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6050), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6050), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6051), new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6054), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6053), new DateTime(2025, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6054), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6053), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6054), new DateTime(2025, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6057), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6056), new DateTime(2025, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6057), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6056), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6058), new DateTime(2025, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6060), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6059), new DateTime(2025, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6060), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6060), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6061), new DateTime(2025, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6064), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6063), new DateTime(2025, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6063), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6063), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6064), new DateTime(2025, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6067), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6066), new DateTime(2025, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6067), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6066), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6068), new DateTime(2025, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6071), new DateTime(2025, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6069), new DateTime(2025, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6070), new DateTime(2025, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6070), new DateTime(2025, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6071), new DateTime(2025, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6075), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6073), new DateTime(2024, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6074), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6074), new DateTime(2024, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6076), new DateTime(2024, 8, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6079), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6078), new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6079), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6078), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6080), new DateTime(2024, 9, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6083), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6081), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6082), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6082), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6083), new DateTime(2024, 10, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6086), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6085), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6085), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6085), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6086), new DateTime(2024, 11, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6108), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6107), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6107), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6107), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6108), new DateTime(2024, 12, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6111), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6110), new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6111), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6111), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6112), new DateTime(2025, 1, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6115), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6113), new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6114), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6114), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6115), new DateTime(2025, 2, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6118), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6117), new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6117), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6117), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6118), new DateTime(2025, 3, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6122), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6120), new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6121), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6121), new DateTime(2024, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6123), new DateTime(2024, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6126), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6125), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6126), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6126), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6127), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6130), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6129), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6129), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6129), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6130), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6133), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6132), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6133), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6132), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6134), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6137), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6135), new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6136), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6136), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6138), new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6140), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6139), new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6140), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6139), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6141), new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6147), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6145), new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6146), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6146), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6147), new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6151), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6149), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6151), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6150), new DateTime(2024, 10, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6152), new DateTime(2024, 10, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6156), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6154), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6155), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6155), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6156), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6159), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6158), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6159), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6158), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6159), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6163), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6161), new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6162), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6162), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6163), new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6166), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6165), new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6166), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6165), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6167), new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6169), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6168), new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6169), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6168), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6170), new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6172), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6171), new DateTime(2025, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6172), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6171), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6175), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6174), new DateTime(2025, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6175), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6175), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6176), new DateTime(2025, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6179), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6177), new DateTime(2025, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6178), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6178), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6179), new DateTime(2025, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6182), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6181), new DateTime(2025, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6181), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6181), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6182), new DateTime(2025, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6185), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6184), new DateTime(2025, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6185), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6184), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6186), new DateTime(2025, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6189), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6188), new DateTime(2024, 11, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6189), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6188), new DateTime(2024, 11, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6190), new DateTime(2024, 11, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6194), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6193), new DateTime(2024, 12, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6193), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6193), new DateTime(2024, 12, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6194), new DateTime(2024, 12, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6195) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6243), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6241), new DateTime(2025, 1, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6243), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6242), new DateTime(2025, 1, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6244), new DateTime(2025, 1, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6247), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6246), new DateTime(2025, 2, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6246), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6246), new DateTime(2025, 2, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6247), new DateTime(2025, 2, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6250), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6249), new DateTime(2025, 3, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6250), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6249), new DateTime(2025, 3, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6251), new DateTime(2025, 3, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6253), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6252), new DateTime(2025, 4, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6253), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6253), new DateTime(2025, 4, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6254), new DateTime(2025, 4, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6257), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6255), new DateTime(2025, 5, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6256), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6256), new DateTime(2025, 5, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6257), new DateTime(2025, 5, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6260), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6259), new DateTime(2025, 6, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6260), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6259), new DateTime(2025, 6, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6261), new DateTime(2025, 6, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6263), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6262), new DateTime(2025, 7, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6263), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6263), new DateTime(2025, 7, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6264), new DateTime(2025, 7, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6267), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6265), new DateTime(2025, 8, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6266), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6266), new DateTime(2025, 8, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6267), new DateTime(2025, 8, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6270), new DateTime(2025, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6269), new DateTime(2025, 9, 23, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6269), new DateTime(2025, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6269), new DateTime(2025, 9, 9, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6270), new DateTime(2025, 9, 22, 17, 2, 39, 647, DateTimeKind.Utc).AddTicks(6271) });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "ActualReturnDate", "BorrowerId", "BorrowerNotes", "BorrowerReceivedComic", "ComicId", "DateCreated", "LenderConfirmedReturn", "LenderId", "LenderNotes", "LoanDurationDays", "LoanEndDate", "LoanRequestId", "LoanStartDate", "MeetupDateTime", "MeetupLocation", "ReturnMeetupDateTime", "ReturnMeetupLocation", "Status" },
                values: new object[,]
                {
                    { 153, null, 2, null, true, 1, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, null, 14, new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Central Station", new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Central Station", "Active" },
                    { 154, null, 3, null, true, 2, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, null, 14, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Central Station", new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Central Station", "Active" },
                    { 155, null, 4, null, true, 3, new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, null, 14, new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Triangeln", new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Triangeln", "Overdue" },
                    { 156, null, 1, null, true, 5, new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, null, 14, new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Lund University Library", new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Lund University Library", "Active" },
                    { 157, null, 1, null, true, 9, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, null, 14, new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Helsingborg Central Station", new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Helsingborg Central Station", "Active" },
                    { 158, null, 1, null, true, 14, new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), false, 4, null, 14, new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Västra Hamnen", new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Västra Hamnen", "Overdue" },
                    { 159, null, 1, null, true, 6, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, null, 14, new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Lund University Library", new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Lund University Library", "Active" },
                    { 160, null, 3, null, true, 7, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, null, 14, new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Lund Central", new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Lund Central", "Active" },
                    { 161, null, 2, null, true, 11, new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, null, 14, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Helsingborg Knutpunkten", new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Helsingborg Knutpunkten", "Active" },
                    { 162, null, 2, null, true, 19, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), false, 5, null, 14, new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Lund University", new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Lund University", "Active" },
                    { 163, null, 4, null, true, 10, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, null, 14, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Helsingborg Central Station", new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Helsingborg Central Station", "Active" },
                    { 164, null, 5, null, true, 12, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, null, 14, new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), "Helsingborg Knutpunkten", new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Helsingborg Knutpunkten", "Active" },
                    { 165, null, 6, null, true, 13, new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, null, 14, new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Helsingborg Central Station", new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Helsingborg Central Station", "Overdue" },
                    { 166, null, 3, null, true, 15, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 4, null, 14, new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö City Library", new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö City Library", "Active" },
                    { 167, null, 3, null, true, 24, new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), false, 6, null, 14, new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Möllevången", new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Möllevången", "Active" },
                    { 168, null, 2, null, true, 16, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), false, 4, null, 14, new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Västra Hamnen", new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Västra Hamnen", "Active" },
                    { 169, null, 6, null, true, 17, new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), false, 4, null, 14, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö City Library", new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö City Library", "Active" },
                    { 170, null, 4, null, true, 20, new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), false, 5, null, 14, new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Lund Central", new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Lund Central", "Active" },
                    { 171, null, 4, null, true, 21, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), false, 5, null, 14, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Lund University", new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Lund University", "Active" },
                    { 172, null, 5, null, true, 25, new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), false, 6, null, 14, new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Värnhem", new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Värnhem", "Active" },
                    { 173, null, 1, null, true, 26, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), false, 6, null, 14, new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Möllevången", new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Möllevången", "Active" },
                    { 174, null, 3, null, true, 28, new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Utc), false, 6, null, 14, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Värnhem", new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Värnhem", "Overdue" },
                    { 175, null, 6, null, true, 4, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, null, 14, new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Triangeln", new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Malmö Triangeln", "Active" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateSubmitted",
                value: new DateTime(2024, 1, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateSubmitted",
                value: new DateTime(2023, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateSubmitted",
                value: new DateTime(2024, 1, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateSubmitted",
                value: new DateTime(2025, 4, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 23, 17, 2, 39, 650, DateTimeKind.Utc).AddTicks(7055));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2023, 12, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(4798), new DateTime(2023, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(3907), new DateTime(2023, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(4571), new DateTime(2023, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(4238), new DateTime(2023, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(5372), new DateTime(2023, 12, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6445), new DateTime(2024, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6441), new DateTime(2024, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6443), new DateTime(2024, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6443), new DateTime(2024, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6446), new DateTime(2024, 1, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6450), new DateTime(2024, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6448), new DateTime(2024, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6449), new DateTime(2024, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6449), new DateTime(2024, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6450), new DateTime(2024, 2, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6453), new DateTime(2024, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6452), new DateTime(2024, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6453), new DateTime(2024, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6452), new DateTime(2024, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6454), new DateTime(2024, 3, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6457), new DateTime(2024, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6455), new DateTime(2024, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6456), new DateTime(2024, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6456), new DateTime(2024, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6457), new DateTime(2024, 4, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6463), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6461), new DateTime(2024, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6462), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6462), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6463), new DateTime(2024, 5, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6466), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6465), new DateTime(2024, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6466), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6465), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6467), new DateTime(2024, 6, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6469), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6468), new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6469), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6468), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6470), new DateTime(2024, 7, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6472), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6471), new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6472), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6471), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6473), new DateTime(2024, 8, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6477), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6475), new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6476), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6476), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6477), new DateTime(2024, 9, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6480), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6479), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6480), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6479), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6480), new DateTime(2024, 10, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6483), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6482), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6483), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6482), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6484), new DateTime(2024, 11, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6488), new DateTime(2024, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6486), new DateTime(2024, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6487), new DateTime(2024, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6487), new DateTime(2024, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6489), new DateTime(2024, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6492), new DateTime(2024, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6491), new DateTime(2024, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6492), new DateTime(2024, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6491), new DateTime(2024, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6493), new DateTime(2024, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6496), new DateTime(2024, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6494), new DateTime(2024, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6495), new DateTime(2024, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6495), new DateTime(2024, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6496), new DateTime(2024, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6499), new DateTime(2024, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6498), new DateTime(2024, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6498), new DateTime(2024, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6498), new DateTime(2024, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6499), new DateTime(2024, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6502), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6501), new DateTime(2024, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6502), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6501), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6503), new DateTime(2024, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6506), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6505), new DateTime(2024, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6506), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6505), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6507), new DateTime(2024, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6510), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6509), new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6509), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6509), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6510), new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6513), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6512), new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6513), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6512), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6514), new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6516), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6515), new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6516), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6516), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6517), new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6520), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6519), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6519), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6519), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6520), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6523), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6522), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6523), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6522), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6524), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6526), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6525), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6526), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6526), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6527), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6531), new DateTime(2024, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6529), new DateTime(2024, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6530), new DateTime(2024, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6530), new DateTime(2024, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6532), new DateTime(2024, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6609), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6607), new DateTime(2024, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6608), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6608), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6609), new DateTime(2024, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6612), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6611), new DateTime(2024, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6612), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6612), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6613), new DateTime(2024, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6616), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6614), new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6615), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6615), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6616), new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6619), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6618), new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6619), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6618), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6619), new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6622), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6621), new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6622), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6621), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6623), new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6625), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6624), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6625), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6625), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6626), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6629), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6627), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6628), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6628), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6629), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6632), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6631), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6631), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6631), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6633), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6652), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6650), new DateTime(2024, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6651), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6651), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6653), new DateTime(2024, 5, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6656), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6655), new DateTime(2024, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6656), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6655), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6657), new DateTime(2024, 6, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6660), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6659), new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6659), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6659), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6660), new DateTime(2024, 7, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6663), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6662), new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6663), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6662), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6664), new DateTime(2024, 8, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6666), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6665), new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6666), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6666), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6667), new DateTime(2024, 9, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6670), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6668), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6669), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6669), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6670), new DateTime(2024, 10, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6673), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6672), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6672), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6672), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6673), new DateTime(2024, 11, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6676), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6675), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6676), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6675), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6677), new DateTime(2024, 12, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6680), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6678), new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6679), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6679), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6680), new DateTime(2025, 1, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6684), new DateTime(2024, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6682), new DateTime(2024, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6684), new DateTime(2024, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6683), new DateTime(2024, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6685), new DateTime(2024, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6689), new DateTime(2024, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6687), new DateTime(2024, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6688), new DateTime(2024, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6688), new DateTime(2024, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6689), new DateTime(2024, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6692), new DateTime(2024, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6691), new DateTime(2024, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6692), new DateTime(2024, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6691), new DateTime(2024, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6692), new DateTime(2024, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6695), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6694), new DateTime(2024, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6695), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6694), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6696), new DateTime(2024, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6698), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6697), new DateTime(2024, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6698), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6698), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6699), new DateTime(2024, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6702), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6700), new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6701), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6701), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6702), new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6705), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6704), new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6704), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6704), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6705), new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6708), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6707), new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6708), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6707), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6709), new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6711), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6710), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6711), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6710), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6712), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6714), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6713), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6714), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6713), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6715), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6717), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6716), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6717), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6717), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6718), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6721), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6720), new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6721), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6720), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6722), new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6724), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6723), new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6724), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6724), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6725), new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6728), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6726), new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6727), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6727), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6728), new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6731), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6730), new DateTime(2025, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6730), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6730), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6731), new DateTime(2025, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6769), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6768), new DateTime(2025, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6769), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6769), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6770), new DateTime(2025, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6773), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6771), new DateTime(2025, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6772), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6772), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6773), new DateTime(2025, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6776), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6775), new DateTime(2025, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6775), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6775), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6776), new DateTime(2025, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6779), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6778), new DateTime(2025, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6779), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6778), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6780), new DateTime(2025, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6782), new DateTime(2025, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6781), new DateTime(2025, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6782), new DateTime(2025, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6781), new DateTime(2025, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6783), new DateTime(2025, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6785), new DateTime(2025, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6784), new DateTime(2025, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6785), new DateTime(2025, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6784), new DateTime(2025, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6786), new DateTime(2025, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6790), new DateTime(2024, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6788), new DateTime(2024, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6789), new DateTime(2024, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6789), new DateTime(2024, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6791), new DateTime(2024, 3, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6794), new DateTime(2024, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6793), new DateTime(2024, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6794), new DateTime(2024, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6793), new DateTime(2024, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6795), new DateTime(2024, 4, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6799), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6798), new DateTime(2024, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6798), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6798), new DateTime(2024, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6799), new DateTime(2024, 5, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6802), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6801), new DateTime(2024, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6802), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6802), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6803), new DateTime(2024, 6, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6806), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6805), new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6806), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6805), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6806), new DateTime(2024, 7, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6809), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6808), new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6809), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6808), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6810), new DateTime(2024, 8, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6813), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6811), new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6812), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6812), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6813), new DateTime(2024, 9, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6816), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6815), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6815), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6815), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6816), new DateTime(2024, 10, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6819), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6818), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6819), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6818), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6820), new DateTime(2024, 11, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6823), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6822), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6822), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6822), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6823), new DateTime(2024, 12, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6826), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6825), new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6826), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6825), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6827), new DateTime(2025, 1, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6830), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6829), new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6830), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6829), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6830), new DateTime(2025, 2, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6833), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6832), new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6833), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6832), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6834), new DateTime(2025, 3, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6836), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6835), new DateTime(2025, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6836), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6836), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6837), new DateTime(2025, 4, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6840), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6838), new DateTime(2025, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6839), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6839), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6840), new DateTime(2025, 5, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6843), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6842), new DateTime(2025, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6842), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6842), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6843), new DateTime(2025, 6, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6846), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6845), new DateTime(2025, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6846), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6845), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6847), new DateTime(2025, 7, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6849), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6848), new DateTime(2025, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6849), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6849), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6850), new DateTime(2025, 8, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6853), new DateTime(2025, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6852), new DateTime(2025, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6852), new DateTime(2025, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6852), new DateTime(2025, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6853), new DateTime(2025, 9, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6856), new DateTime(2025, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6855), new DateTime(2025, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6856), new DateTime(2025, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6855), new DateTime(2025, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6857), new DateTime(2025, 10, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6859), new DateTime(2025, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6858), new DateTime(2025, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6859), new DateTime(2025, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6858), new DateTime(2025, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6860), new DateTime(2025, 11, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6875), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6873), new DateTime(2024, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6874), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6874), new DateTime(2024, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6876), new DateTime(2024, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6880), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6878), new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6879), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6879), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6880), new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6883), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6882), new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6883), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6882), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6883), new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6914), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6913), new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6914), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6913), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6915), new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6918), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6916), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6917), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6917), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6918), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6921), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6919), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6920), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6920), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6921), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6924), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6923), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6923), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6923), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6924), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6927), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6926), new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6927), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6926), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6928), new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6931), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6930), new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6930), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6930), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6931), new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6934), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6933), new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6934), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6933), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6935), new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6937), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6936), new DateTime(2025, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6937), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6937), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6938), new DateTime(2025, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6940), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6939), new DateTime(2025, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6940), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6940), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6941), new DateTime(2025, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6944), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6942), new DateTime(2025, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6943), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6943), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6944), new DateTime(2025, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6947), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6946), new DateTime(2025, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6946), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6946), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6947), new DateTime(2025, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6950), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6949), new DateTime(2025, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6950), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6949), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6950), new DateTime(2025, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6953), new DateTime(2025, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6952), new DateTime(2025, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6953), new DateTime(2025, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6952), new DateTime(2025, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6953), new DateTime(2025, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6958), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6956), new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6957), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6956), new DateTime(2024, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6958), new DateTime(2024, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6962), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6961), new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6962), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6961), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6963), new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6965), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6964), new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6965), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6965), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6966), new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6969), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6968), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6969), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6968), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6969), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6972), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6971), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6972), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6972), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6973), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6976), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6975), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6975), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6975), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6976), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6979), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6978), new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6979), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6978), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6980), new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6983), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6982), new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6983), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6982), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6983), new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6986), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6985), new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6986), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6985), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6987), new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6990), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6988), new DateTime(2025, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6989), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6989), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6990), new DateTime(2025, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6993), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6992), new DateTime(2025, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6992), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6992), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6993), new DateTime(2025, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6996), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6995), new DateTime(2025, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6996), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6995), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6996), new DateTime(2025, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6999), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6998), new DateTime(2025, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6999), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(6998), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7000), new DateTime(2025, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7003), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7001), new DateTime(2025, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7002), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7002), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7003), new DateTime(2025, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7006), new DateTime(2025, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7005), new DateTime(2025, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7005), new DateTime(2025, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7005), new DateTime(2025, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7006), new DateTime(2025, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7010), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7008), new DateTime(2024, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7010), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7009), new DateTime(2024, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7011), new DateTime(2024, 8, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7015), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7013), new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7014), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7014), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7015), new DateTime(2024, 9, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7018), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7017), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7017), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7017), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7018), new DateTime(2024, 10, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7021), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7020), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7021), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7020), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7022), new DateTime(2024, 11, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7024), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7023), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7024), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7023), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7025), new DateTime(2024, 12, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7028), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7026), new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7027), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7027), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7028), new DateTime(2025, 1, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7058), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7056), new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7057), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7057), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7058), new DateTime(2025, 2, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7061), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7060), new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7060), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7060), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7061), new DateTime(2025, 3, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7065), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7063), new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7065), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7064), new DateTime(2024, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7066), new DateTime(2024, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7070), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7068), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7069), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7069), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7070), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7073), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7072), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7073), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7072), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7074), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7076), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7075), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7076), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7075), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7077), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7080), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7078), new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7079), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7079), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7081), new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7083), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7082), new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7083), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7083), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7084), new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7088), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7087), new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7088), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7087), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7089), new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7093), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7091), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7092), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7091), new DateTime(2024, 10, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7093), new DateTime(2024, 10, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7097), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7095), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7096), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7096), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7097), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7100), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7099), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7100), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7099), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7101), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7104), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7102), new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7103), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7103), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7104), new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7107), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7107), new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7110), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7109), new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7109), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7109), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7110), new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7113), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7112), new DateTime(2025, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7113), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7112), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7114), new DateTime(2025, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7116), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7115), new DateTime(2025, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7116), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7115), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7119), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7118), new DateTime(2025, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7119), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7118), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7120), new DateTime(2025, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7122), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7121), new DateTime(2025, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7122), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7121), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7123), new DateTime(2025, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7125), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7124), new DateTime(2025, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7125), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7124), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7126), new DateTime(2025, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7130), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7128), new DateTime(2024, 11, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7129), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7129), new DateTime(2024, 11, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7131), new DateTime(2024, 11, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7134), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7133), new DateTime(2024, 12, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7134), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7133), new DateTime(2024, 12, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7135), new DateTime(2024, 12, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7138), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7136), new DateTime(2025, 1, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7137), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7137), new DateTime(2025, 1, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7138), new DateTime(2025, 1, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7141), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7140), new DateTime(2025, 2, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7141), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7141), new DateTime(2025, 2, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7142), new DateTime(2025, 2, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7145), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7143), new DateTime(2025, 3, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7144), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7144), new DateTime(2025, 3, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7145), new DateTime(2025, 3, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7148), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7146), new DateTime(2025, 4, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7147), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7147), new DateTime(2025, 4, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7148), new DateTime(2025, 4, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7171), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7169), new DateTime(2025, 5, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7170), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7170), new DateTime(2025, 5, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7171), new DateTime(2025, 5, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7174), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7173), new DateTime(2025, 6, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7174), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7173), new DateTime(2025, 6, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7175), new DateTime(2025, 6, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7177), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7176), new DateTime(2025, 7, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7177), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7176), new DateTime(2025, 7, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7178), new DateTime(2025, 7, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7180), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7179), new DateTime(2025, 8, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7180), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7180), new DateTime(2025, 8, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7181), new DateTime(2025, 8, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7184), new DateTime(2025, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7183), new DateTime(2025, 9, 23, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7184), new DateTime(2025, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7183), new DateTime(2025, 9, 9, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7184), new DateTime(2025, 9, 22, 16, 11, 46, 374, DateTimeKind.Utc).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateSubmitted",
                value: new DateTime(2024, 1, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateSubmitted",
                value: new DateTime(2023, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateSubmitted",
                value: new DateTime(2024, 1, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateSubmitted",
                value: new DateTime(2025, 4, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 23, 16, 11, 46, 375, DateTimeKind.Utc).AddTicks(9856));
        }
    }
}
