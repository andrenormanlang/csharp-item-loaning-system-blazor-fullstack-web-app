using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicBooksLoanAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApprovalStatus",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ApprovalStatus",
                table: "Comics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 8,
                column: "ApprovalStatus",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 18,
                column: "ApprovalStatus",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 22,
                column: "ApprovalStatus",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 23,
                column: "ApprovalStatus",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 27,
                column: "ApprovalStatus",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ApprovalStatus", "LoanReturnDate" },
                values: new object[] { 1, new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 29,
                column: "ApprovalStatus",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 30,
                column: "ApprovalStatus",
                value: 1);

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApprovalStatus", "Role" },
                values: new object[] { 1, "User" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApprovalStatus", "Role" },
                values: new object[] { 1, "User" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApprovalStatus", "Role" },
                values: new object[] { 1, "User" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ApprovalStatus", "Role" },
                values: new object[] { 1, "User" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApprovalStatus", "Role" },
                values: new object[] { 1, "User" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ApprovalStatus", "Role" },
                values: new object[] { 1, "User" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ApprovalStatus", "AverageRating", "Biography", "City", "Description", "Email", "FavoriteCharacters", "FullName", "ImageUrl", "IsVerified", "MemberSince", "PasswordHash", "ReadingFocus", "Role", "SuccessfulLoans", "Username", "ZipCode" },
                values: new object[] { 1000, 1, 0m, "", "Malmö", "Administrator account for approving users and comics", "admin@example.com", "", "Admin Moderator", null, true, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Q29taWNCb29rc1NlZWRTYWx0MjC82plhx/mDiwvJ+IO0adv1xzcRdg==", "Moderation", "Admin", 0, "admin", "211 20" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DropColumn(
                name: "ApprovalStatus",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ApprovalStatus",
                table: "Comics");

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 1,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 2,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 3,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 4,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 5,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 6,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 7,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 9,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 10,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 11,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 12,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 13,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 14,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 15,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 16,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 17,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 19,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 20,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 21,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 24,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 25,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 26,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 28,
                column: "LoanReturnDate",
                value: new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(2554), new DateTime(2023, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(1684), new DateTime(2023, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(2331), new DateTime(2023, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(2005), new DateTime(2023, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(3127), new DateTime(2023, 12, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4071), new DateTime(2024, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4068), new DateTime(2024, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4070), new DateTime(2024, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4070), new DateTime(2024, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4073), new DateTime(2024, 1, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4077), new DateTime(2024, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4076), new DateTime(2024, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4077), new DateTime(2024, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4076), new DateTime(2024, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4078), new DateTime(2024, 2, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4080), new DateTime(2024, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4079), new DateTime(2024, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4080), new DateTime(2024, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4079), new DateTime(2024, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4081), new DateTime(2024, 3, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4084), new DateTime(2024, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4082), new DateTime(2024, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4083), new DateTime(2024, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4083), new DateTime(2024, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4084), new DateTime(2024, 4, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4090), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4089), new DateTime(2024, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4089), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4089), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4090), new DateTime(2024, 5, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4093), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4092), new DateTime(2024, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4093), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4092), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4094), new DateTime(2024, 6, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4096), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4095), new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4096), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4095), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4097), new DateTime(2024, 7, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4100), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4098), new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4099), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4099), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4100), new DateTime(2024, 8, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4103), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4102), new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4103), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4103), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4104), new DateTime(2024, 9, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4107), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4105), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4106), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4106), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4107), new DateTime(2024, 10, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4110), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4109), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4109), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4109), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4110), new DateTime(2024, 11, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4114), new DateTime(2024, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4113), new DateTime(2024, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4114), new DateTime(2024, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4113), new DateTime(2024, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4115), new DateTime(2024, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4120), new DateTime(2024, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4118), new DateTime(2024, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4119), new DateTime(2024, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4119), new DateTime(2024, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4120), new DateTime(2024, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4123), new DateTime(2024, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4122), new DateTime(2024, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4123), new DateTime(2024, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4122), new DateTime(2024, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4124), new DateTime(2024, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4127), new DateTime(2024, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4125), new DateTime(2024, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4126), new DateTime(2024, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4126), new DateTime(2024, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4127), new DateTime(2024, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4130), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4129), new DateTime(2024, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4129), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4129), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4130), new DateTime(2024, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4131) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4134), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4133), new DateTime(2024, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4134), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4133), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4135), new DateTime(2024, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4138), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4136), new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4137), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4137), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4138), new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4140), new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4140), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4142), new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4145), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4143), new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4144), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4144), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4145), new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4148), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4147), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4147), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4147), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4148), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4151), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4150), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4151), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4150), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4152), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4155), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4153), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4154), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4154), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4155), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4181), new DateTime(2024, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4179), new DateTime(2024, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4180), new DateTime(2024, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4180), new DateTime(2024, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4182), new DateTime(2024, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4186), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4185), new DateTime(2024, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4185), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4185), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4186), new DateTime(2024, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4189), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4188), new DateTime(2024, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4189), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4188), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4190), new DateTime(2024, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4192), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4191), new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4192), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4192), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4193), new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4196), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4195), new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4196), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4195), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4196), new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4240), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4239), new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4239), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4239), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4240), new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4243), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4242), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4243), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4243), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4244), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4247), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4245), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4246), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4246), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4247), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4250), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4249), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4250), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4249), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4250), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4256), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4254), new DateTime(2024, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4255), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4254), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4256), new DateTime(2024, 5, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4260), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4259), new DateTime(2024, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4260), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4259), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4261), new DateTime(2024, 6, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4263), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4262), new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4263), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4263), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4264), new DateTime(2024, 7, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4267), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4265), new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4266), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4266), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4267), new DateTime(2024, 8, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4270), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4269), new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4269), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4269), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4271), new DateTime(2024, 9, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4273), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4272), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4273), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4273), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4274), new DateTime(2024, 10, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4277), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4275), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4276), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4276), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4277), new DateTime(2024, 11, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4280), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4279), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4280), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4279), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4280), new DateTime(2024, 12, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4284), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4282), new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4283), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4283), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4284), new DateTime(2025, 1, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4288), new DateTime(2024, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4286), new DateTime(2024, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4288), new DateTime(2024, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4287), new DateTime(2024, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4289), new DateTime(2024, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4292), new DateTime(2024, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4291), new DateTime(2024, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4292), new DateTime(2024, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4292), new DateTime(2024, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4293), new DateTime(2024, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4296), new DateTime(2024, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4294), new DateTime(2024, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4295), new DateTime(2024, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4295), new DateTime(2024, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4296), new DateTime(2024, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4299), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4298), new DateTime(2024, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4298), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4298), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4299), new DateTime(2024, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4302), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4301), new DateTime(2024, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4302), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4301), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4303), new DateTime(2024, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4305), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4304), new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4305), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4304), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4306), new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4309), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4307), new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4308), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4308), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4309), new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4312), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4311), new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4311), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4311), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4312), new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4315), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4314), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4315), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4314), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4316), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4318), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4317), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4318), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4317), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4319), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4322), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4320), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4321), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4321), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4322), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4325), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4324), new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4325), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4324), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4326), new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4329), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4328), new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4328), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4328), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4329), new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4332), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4331), new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4332), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4331), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4333), new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4333) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4335), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4334), new DateTime(2025, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4335), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4334), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4338), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4337), new DateTime(2025, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4338), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4337), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4339), new DateTime(2025, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4341), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4340), new DateTime(2025, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4341), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4341), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4342), new DateTime(2025, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4345), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4343), new DateTime(2025, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4344), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4344), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4345), new DateTime(2025, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4348), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4347), new DateTime(2025, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4348), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4347), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4349), new DateTime(2025, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4398), new DateTime(2025, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4397), new DateTime(2025, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4397), new DateTime(2025, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4397), new DateTime(2025, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4398), new DateTime(2025, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4401), new DateTime(2025, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4400), new DateTime(2025, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4401), new DateTime(2025, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4400), new DateTime(2025, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4402), new DateTime(2025, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4418), new DateTime(2024, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4416), new DateTime(2024, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4417), new DateTime(2024, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4417), new DateTime(2024, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4419), new DateTime(2024, 3, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4423), new DateTime(2024, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4421), new DateTime(2024, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4422), new DateTime(2024, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4422), new DateTime(2024, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4423), new DateTime(2024, 4, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4429), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4427), new DateTime(2024, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4428), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4428), new DateTime(2024, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4429), new DateTime(2024, 5, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4432), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4431), new DateTime(2024, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4432), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4431), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4433), new DateTime(2024, 6, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4435), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4434), new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4435), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4435), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4436), new DateTime(2024, 7, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4439), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4438), new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4438), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4438), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4439), new DateTime(2024, 8, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4442), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4441), new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4442), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4441), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4443), new DateTime(2024, 9, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4446), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4444), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4445), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4445), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4446), new DateTime(2024, 10, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4449), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4448), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4449), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4448), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4450), new DateTime(2024, 11, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4453), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4451), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4452), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4452), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4453), new DateTime(2024, 12, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4456), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4455), new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4456), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4455), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4457), new DateTime(2025, 1, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4459), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4458), new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4459), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4459), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4460), new DateTime(2025, 2, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4463), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4461), new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4462), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4462), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4463), new DateTime(2025, 3, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4464) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4466), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4465), new DateTime(2025, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4466), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4465), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4467), new DateTime(2025, 4, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4469), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4468), new DateTime(2025, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4469), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4469), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4470), new DateTime(2025, 5, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4473), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4471), new DateTime(2025, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4473), new DateTime(2025, 6, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4476), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4475), new DateTime(2025, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4476), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4475), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4476), new DateTime(2025, 7, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4480), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4478), new DateTime(2025, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4479), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4479), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4480), new DateTime(2025, 8, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4483), new DateTime(2025, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4482), new DateTime(2025, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4482), new DateTime(2025, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4482), new DateTime(2025, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4483), new DateTime(2025, 9, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4486), new DateTime(2025, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4485), new DateTime(2025, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4486), new DateTime(2025, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4485), new DateTime(2025, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4487), new DateTime(2025, 10, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4487) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4489), new DateTime(2025, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4488), new DateTime(2025, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4489), new DateTime(2025, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4489), new DateTime(2025, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4490), new DateTime(2025, 11, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4494), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4492), new DateTime(2024, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4493), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4493), new DateTime(2024, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4495), new DateTime(2024, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4498), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4497), new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4498), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4498), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4499), new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4502), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4501), new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4501), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4501), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4502), new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4505), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4504), new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4505), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4504), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4506), new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4508), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4507), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4508), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4508), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4509), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4512), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4510), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4511), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4511), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4512), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4543), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4541), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4542), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4542), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4543), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4546), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4545), new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4546), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4545), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4547), new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4550), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4548), new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4549), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4549), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4550), new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4553), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4552), new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4552), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4552), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4553), new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4555), new DateTime(2025, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4555), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4555), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4559), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4558), new DateTime(2025, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4559), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4558), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4559), new DateTime(2025, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4562), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4561), new DateTime(2025, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4562), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4561), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4563), new DateTime(2025, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4566), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4564), new DateTime(2025, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4565), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4565), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4566), new DateTime(2025, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4569), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4568), new DateTime(2025, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4568), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4568), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4569), new DateTime(2025, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4572), new DateTime(2025, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4571), new DateTime(2025, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4571), new DateTime(2025, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4571), new DateTime(2025, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4572), new DateTime(2025, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4577), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4575), new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4576), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4575), new DateTime(2024, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4577), new DateTime(2024, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4581), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4580), new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4581), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4580), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4582), new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4585), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4583), new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4584), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4584), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4585), new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4588), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4587), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4587), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4587), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4588), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4591), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4590), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4591), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4591), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4592), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4595), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4593), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4594), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4594), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4595), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4598), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4597), new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4598), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4597), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4599), new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4602), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4601), new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4601), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4601), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4602), new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4605), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4604), new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4605), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4604), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4606), new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4609), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4608), new DateTime(2025, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4608), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4608), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4609), new DateTime(2025, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4612), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4611), new DateTime(2025, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4612), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4611), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4613), new DateTime(2025, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4615), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4614), new DateTime(2025, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4615), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4615), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4616), new DateTime(2025, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4619), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4617), new DateTime(2025, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4618), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4618), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4619), new DateTime(2025, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4622), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4621), new DateTime(2025, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4621), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4621), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4622), new DateTime(2025, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4625), new DateTime(2025, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4624), new DateTime(2025, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4625), new DateTime(2025, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4624), new DateTime(2025, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4626), new DateTime(2025, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4642), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4640), new DateTime(2024, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4641), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4640), new DateTime(2024, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4643), new DateTime(2024, 8, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4646), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4645), new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4646), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4645), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4647), new DateTime(2024, 9, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4650), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4648), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4649), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4649), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4650), new DateTime(2024, 10, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4653), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4652), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4652), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4652), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4653), new DateTime(2024, 11, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4656), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4655), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4656), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4655), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4657), new DateTime(2024, 12, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4660), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4658), new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4659), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4658), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4660), new DateTime(2025, 1, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4663), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4662), new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4662), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4662), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4663), new DateTime(2025, 2, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4666), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4665), new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4665), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4665), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4666), new DateTime(2025, 3, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4671), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4668), new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4670), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4669), new DateTime(2024, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4671), new DateTime(2024, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4703), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4702), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4702), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4702), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4703), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4706), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4705), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4706), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4706), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4707), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4710), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4709), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4709), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4709), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4710), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4713), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4712), new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4713), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4712), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4714), new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4717), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4715), new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4716), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4716), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4717), new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4721), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4720), new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4720), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4720), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4721), new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4725), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4724), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4725), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4724), new DateTime(2024, 10, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4726), new DateTime(2024, 10, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4730), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4729), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4729), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4729), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4730), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4733), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4732), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4733), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4732), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4733), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4737), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4735), new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4736), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4736), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4737), new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4738) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4740), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4739), new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4740), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4740), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4741), new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4743), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4742), new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4743), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4743), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4744), new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4747), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4745), new DateTime(2025, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4746), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4746), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4747), new DateTime(2025, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4750), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4748), new DateTime(2025, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4749), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4749), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4750), new DateTime(2025, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4753), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4751), new DateTime(2025, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4752), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4752), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4753), new DateTime(2025, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4756), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4754), new DateTime(2025, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4755), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4755), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4756), new DateTime(2025, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4759), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4758), new DateTime(2025, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4758), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4758), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4759), new DateTime(2025, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4764), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4762), new DateTime(2024, 11, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4763), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4762), new DateTime(2024, 11, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4765), new DateTime(2024, 11, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4768), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4767), new DateTime(2024, 12, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4768), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4767), new DateTime(2024, 12, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4769), new DateTime(2024, 12, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4772), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4771), new DateTime(2025, 1, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4772), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4771), new DateTime(2025, 1, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4773), new DateTime(2025, 1, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4775), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4774), new DateTime(2025, 2, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4775), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4775), new DateTime(2025, 2, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4776), new DateTime(2025, 2, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4779), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4778), new DateTime(2025, 3, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4778), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4778), new DateTime(2025, 3, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4779), new DateTime(2025, 3, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4782), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4781), new DateTime(2025, 4, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4782), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4781), new DateTime(2025, 4, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4783), new DateTime(2025, 4, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4785), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4784), new DateTime(2025, 5, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4785), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4785), new DateTime(2025, 5, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4786), new DateTime(2025, 5, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4789), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4788), new DateTime(2025, 6, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4788), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4788), new DateTime(2025, 6, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4789), new DateTime(2025, 6, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4792), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4791), new DateTime(2025, 7, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4792), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4791), new DateTime(2025, 7, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4792), new DateTime(2025, 7, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4822), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4821), new DateTime(2025, 8, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4821), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4821), new DateTime(2025, 8, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4822), new DateTime(2025, 8, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4825), new DateTime(2025, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4824), new DateTime(2025, 9, 24, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4825), new DateTime(2025, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4824), new DateTime(2025, 9, 10, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4826), new DateTime(2025, 9, 23, 11, 47, 45, 622, DateTimeKind.Utc).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentDate",
                value: new DateTime(2025, 11, 26, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentDate",
                value: new DateTime(2025, 11, 27, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SentDate",
                value: new DateTime(2025, 11, 28, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SentDate",
                value: new DateTime(2025, 11, 29, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SentDate",
                value: new DateTime(2025, 11, 30, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SentDate",
                value: new DateTime(2025, 12, 1, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SentDate",
                value: new DateTime(2025, 12, 2, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SentDate",
                value: new DateTime(2025, 12, 3, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SentDate",
                value: new DateTime(2025, 12, 4, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SentDate",
                value: new DateTime(2025, 12, 5, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SentDate",
                value: new DateTime(2025, 12, 5, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SentDate",
                value: new DateTime(2025, 12, 6, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SentDate",
                value: new DateTime(2025, 12, 7, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SentDate",
                value: new DateTime(2025, 12, 2, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SentDate",
                value: new DateTime(2025, 12, 3, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SentDate",
                value: new DateTime(2025, 12, 4, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SentDate",
                value: new DateTime(2025, 12, 6, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SentDate",
                value: new DateTime(2025, 12, 7, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SentDate",
                value: new DateTime(2025, 12, 8, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SentDate",
                value: new DateTime(2025, 12, 4, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SentDate",
                value: new DateTime(2025, 12, 5, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SentDate",
                value: new DateTime(2025, 12, 6, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SentDate",
                value: new DateTime(2025, 12, 7, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SentDate",
                value: new DateTime(2025, 12, 8, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SentDate",
                value: new DateTime(2025, 12, 9, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SentDate",
                value: new DateTime(2025, 12, 5, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SentDate",
                value: new DateTime(2025, 12, 6, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SentDate",
                value: new DateTime(2025, 12, 8, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SentDate",
                value: new DateTime(2025, 12, 9, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SentDate",
                value: new DateTime(2025, 12, 7, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SentDate",
                value: new DateTime(2025, 12, 8, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SentDate",
                value: new DateTime(2025, 12, 6, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SentDate",
                value: new DateTime(2025, 12, 7, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SentDate",
                value: new DateTime(2025, 12, 9, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SentDate",
                value: new DateTime(2025, 12, 9, 23, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SentDate",
                value: new DateTime(2025, 12, 10, 5, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateSubmitted",
                value: new DateTime(2024, 1, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateSubmitted",
                value: new DateTime(2023, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateSubmitted",
                value: new DateTime(2024, 1, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateSubmitted",
                value: new DateTime(2025, 4, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 24, 11, 47, 45, 625, DateTimeKind.Utc).AddTicks(9416));
        }
    }
}
