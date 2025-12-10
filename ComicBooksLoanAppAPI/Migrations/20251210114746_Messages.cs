using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComicBooksLoanAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class Messages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "SentDate" },
                values: new object[] { "Hi Henry, I saw your horror collection and wondered if you'd be open to a trade sometime. Also, I noticed you might enjoy 'Preacher #1'—happy to lend if interested.", new DateTime(2025, 11, 26, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "IsRead", "SentDate" },
                values: new object[] { "Thanks, Diana! I'd love to borrow it for two weeks. We can meet in Malmö or Lund—whatever suits you. I've been wanting to read Preacher for years!", true, new DateTime(2025, 11, 27, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[] { "Perfect! How about we meet at Malmö C on Saturday around 2pm? I can bring the first arc (issues 1-7). In return, could I borrow some of your Tomb of Dracula run?", true, 6, 2, new DateTime(2025, 11, 28, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: Borrow request: Preacher #1" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "IsRead", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[,]
                {
                    { 4, "Saturday at 2pm works great! I'll bring Tomb of Dracula #1-10. The Gene Colan artwork is phenomenal. See you at the station entrance!", true, 2, 6, new DateTime(2025, 11, 29, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: Borrow request: Preacher #1" },
                    { 5, "Marcus, would you be up for swapping 'ASM #129' for a short read of 'Uncanny X-Men #129'? Both first appearances - Punisher vs Kitty Pryde!", true, 3, 1, new DateTime(2025, 11, 30, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Trade idea: Spider-Man for X-Men" },
                    { 6, "Robert! That's a great matchup. I'd love to read the first Punisher appearance. X-Men #129 is in great condition - the Dark Phoenix Saga is heating up at that point. Two week loan work for you?", true, 1, 3, new DateTime(2025, 12, 1, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: Trade idea: Spider-Man for X-Men" },
                    { 7, "Two weeks is perfect! I'm in central Malmö most weekdays. Could we meet at Triangeln shopping center? Maybe Tuesday evening?", true, 3, 1, new DateTime(2025, 12, 2, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: Trade idea: Spider-Man for X-Men" },
                    { 8, "Hey Robert! Saw you're into Bronze Age Marvel. Ever venture into the DC side? I have the complete O'Neil/Adams Batman run and it's incredible. The art alone is worth the read.", true, 1, 4, new DateTime(2025, 12, 3, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "O'Neil/Adams Batman - interested?" },
                    { 9, "Daniel! I've heard so much about those issues. I'd absolutely love to borrow them. I'm mostly Marvel but those Batman stories are legendary. What would you want in return?", true, 4, 1, new DateTime(2025, 12, 4, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: O'Neil/Adams Batman - interested?" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[] { 10, "No trade needed! Just happy to share them. I have Batman #227, 234, 251 and the Detective Comics run. How about you start with the Joker's Five-Way Revenge (Batman #251)? We're both in Malmö so meeting up is easy.", 1, 4, new DateTime(2025, 12, 5, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: O'Neil/Adams Batman - interested?" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "IsRead", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[,]
                {
                    { 11, "Diana, as a fellow Lund resident and Vertigo fan, I thought you might be interested in some of the indie books that influenced the Vertigo line. I have early Swamp Thing (pre-Moore) and some American Flagg that shows the mature comics evolution.", true, 2, 5, new DateTime(2025, 12, 5, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Vertigo roots in indie comics" },
                    { 12, "Sarah! I'd LOVE to read those. I've mostly focused on the mature Vertigo era but understanding the roots would be fascinating. American Flagg is on my wish list. Can I borrow a few issues?", true, 5, 2, new DateTime(2025, 12, 6, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: Vertigo roots in indie comics" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[] { 13, "Absolutely! I'll bring American Flagg #1-4 and Swamp Thing #1-10 (Len Wein era). You'll see Moore's blueprint was already there. Coffee at Lund C this week?", 2, 5, new DateTime(2025, 12, 7, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: Vertigo roots in indie comics" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "IsRead", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[,]
                {
                    { 14, "Daniel, I noticed you're heavily into Bronze Age DC. I'm purely Marvel (X-Men obsessed!). What DC titles from that era would you recommend to a Marvel zombie like me?", true, 4, 3, new DateTime(2025, 12, 2, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Marvel vs DC Bronze Age question" },
                    { 15, "Marcus! Great question. If you love Claremont's character development, you'll love the O'Neil/Adams Green Lantern/Green Arrow run. Social issues + superhero action. Also New Teen Titans by Wolfman/Pérez - it's DC's X-Men basically!", true, 3, 4, new DateTime(2025, 12, 3, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: Marvel vs DC Bronze Age question" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[] { 16, "I've heard amazing things about New Teen Titans! Would you be willing to lend some issues? I can trade some X-Men in return - maybe the first Rogue appearance or Days of Future Past?", 4, 3, new DateTime(2025, 12, 4, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: Marvel vs DC Bronze Age question" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "IsRead", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[,]
                {
                    { 17, "Hey Robert! Saw you're into Bronze Age Marvel. Did you collect any of the horror titles? Tomb of Dracula, Werewolf by Night, Man-Thing? They're amazing Bronze Age stories but often overlooked.", true, 1, 6, new DateTime(2025, 12, 6, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Marvel's horror line - Bronze Age crossover" },
                    { 18, "Henry! I've been curious about Tomb of Dracula but never jumped in. I know Blade first appeared there. Would love to borrow some issues if you're willing to share!", true, 6, 1, new DateTime(2025, 12, 7, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: Marvel's horror line - Bronze Age crossover" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[] { 19, "Perfect timing! Tomb of Dracula #10 (first Blade) and #1-5 to get the full story. Gene Colan's art is stunning. We're both in Malmö - Möllevången for coffee exchange this weekend?", 1, 6, new DateTime(2025, 12, 8, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: Marvel's horror line - Bronze Age crossover" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "IsRead", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[,]
                {
                    { 20, "Marcus! You collect X-Men, so you might find this interesting - the original TMNT comics are a parody of X-Men and Daredevil. The ooze that creates them is from the same accident that created Daredevil. I have the original Mirage issues if you want to see where it started!", true, 3, 5, new DateTime(2025, 12, 4, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "TMNT origin - X-Men connection" },
                    { 21, "Sarah, I had NO idea about the X-Men parody angle! I only know TMNT from the cartoon. Would love to read the original black and white comics. The gritty original must be so different from the kids' version.", true, 5, 3, new DateTime(2025, 12, 5, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: TMNT origin - X-Men connection" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[] { 22, "It's night and day! The original is dark, violent, and brilliant. I'll bring TMNT #1-4 (first printings). The Shredder story is brutal. Can we meet halfway between Lund and Helsingborg? Maybe Landskrona?", 3, 5, new DateTime(2025, 12, 6, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: TMNT origin - X-Men connection" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "IsRead", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[,]
                {
                    { 23, "Daniel, I'm a huge Alan Moore Swamp Thing fan. Do you have any of the pre-Moore issues? I'd love to see how Wein originally handled the character before Moore revolutionized it.", true, 4, 2, new DateTime(2025, 12, 7, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Swamp Thing pre-Moore issues" },
                    { 24, "Diana! I have the Wein/Wrightson run - the original 10 issues are gorgeous. Wrightson's art is incredible. You'll see Moore built on a strong foundation. The 'Anatomy Lesson' wouldn't hit as hard without Wein's setup.", true, 2, 4, new DateTime(2025, 12, 8, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: Swamp Thing pre-Moore issues" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[] { 25, "Yes! I need to read those. The Wrightson art alone is worth it. Could we arrange a trade? I have some later Vertigo titles you might not have read - Hellblazer, Sandman Mystery Theatre?", 4, 2, new DateTime(2025, 12, 9, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: Swamp Thing pre-Moore issues" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "IsRead", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[,]
                {
                    { 26, "Sarah, I'm purely superhero Marvel but I keep hearing about how underground and indie comics influenced the mainstream. What should I read to understand that evolution?", true, 5, 1, new DateTime(2025, 12, 5, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Bronze Age indie crossover?" },
                    { 27, "Robert! Start with Cerebus - it begins as Conan parody but becomes something much deeper. Also American Flagg and the early TMNT. These showed creators they could own their work and tell mature stories. Happy to lend!", true, 1, 5, new DateTime(2025, 12, 6, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: Bronze Age indie crossover?" },
                    { 28, "Marcus! Did you collect any of the X-Men/Dracula crossovers? Uncanny X-Men #159 with Dracula is one of my favorite issues. The horror/superhero mix works so well!", true, 3, 6, new DateTime(2025, 12, 8, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "X-Men horror crossovers" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[] { 29, "Henry! I have that issue - it's brilliant! Storm vs Dracula is epic. Have you read the earlier X-Men #30s where they fight vampires? I could lend those if you want to see the first vampire encounters.", 6, 3, new DateTime(2025, 12, 9, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: X-Men horror crossovers" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "IsRead", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[] { 30, "Sarah, I focus on the O'Neil/Adams social commentary era of DC. I know indie comics tackled even more controversial topics. What should I read to see how far underground comics pushed boundaries?", true, 5, 4, new DateTime(2025, 12, 7, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Socially conscious comics" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[] { 31, "Daniel! You'd appreciate Howard Chaykin's American Flagg - it's political satire with gorgeous art. Also some of the underground comix dealt with topics DC couldn't touch in the 70s. I can create a curated reading list for you!", 4, 5, new DateTime(2025, 12, 8, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: Socially conscious comics" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "IsRead", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[] { 32, "Diana, when did comics really 'grow up'? I know X-Men got darker with Claremont, but Vertigo seems like a different level. What's the connection between 80s Marvel and mature Vertigo?", true, 2, 3, new DateTime(2025, 12, 6, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Question about mature comics evolution" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[,]
                {
                    { 33, "Marcus! Great question. Moore's Swamp Thing and Watchmen in the mid-80s opened the door. X-Men was getting mature but still had Comics Code restrictions. Vertigo let creators tell truly adult stories. I'd recommend reading Dark Knight Returns and Watchmen to see the shift!", 3, 2, new DateTime(2025, 12, 7, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Re: Question about mature comics evolution" },
                    { 34, "Diana, I've been trading with several people in the group. Think we should organize a Malmö/Lund comic swap meetup? Could be fun to all meet in person and swap recommendations!", 2, 1, new DateTime(2025, 12, 9, 11, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Lending library meetup idea?" },
                    { 35, "Henry! Just realized we're both in Malmö and never connected. I have some Batman horror stories (Man-Bat, early Scarecrow) that might interest you. Want to trade for some of your horror collection?", 6, 4, new DateTime(2025, 12, 9, 23, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Batman/horror crossover" },
                    { 36, "Henry, Swamp Thing is fascinating because it bridges indie sensibilities with mainstream DC. I have some of the Wein issues and would love to compare notes with your collection. Trade?", 6, 5, new DateTime(2025, 12, 10, 5, 47, 45, 626, DateTimeKind.Utc).AddTicks(9553), "Swamp Thing - indie to mainstream" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(5654), new DateTime(2023, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(4770), new DateTime(2023, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(5424), new DateTime(2023, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(5099), new DateTime(2023, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(6233), new DateTime(2023, 12, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7274), new DateTime(2024, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7271), new DateTime(2024, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7273), new DateTime(2024, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7273), new DateTime(2024, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7276), new DateTime(2024, 1, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7280), new DateTime(2024, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7279), new DateTime(2024, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7279), new DateTime(2024, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7279), new DateTime(2024, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7280), new DateTime(2024, 2, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7283), new DateTime(2024, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7282), new DateTime(2024, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7283), new DateTime(2024, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7282), new DateTime(2024, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7284), new DateTime(2024, 3, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7287), new DateTime(2024, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7286), new DateTime(2024, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7286), new DateTime(2024, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7286), new DateTime(2024, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7287), new DateTime(2024, 4, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7293), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7292), new DateTime(2024, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7293), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7292), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7294), new DateTime(2024, 5, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7297), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7296), new DateTime(2024, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7296), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7296), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7297), new DateTime(2024, 6, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7300), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7299), new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7300), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7299), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7301), new DateTime(2024, 7, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7426), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7424), new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7425), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7425), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7426), new DateTime(2024, 8, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7431), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7430), new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7431), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7430), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7432), new DateTime(2024, 9, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7434), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7433), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7434), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7434), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7435), new DateTime(2024, 10, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7438), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7436), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7437), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7437), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7438), new DateTime(2024, 11, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7443), new DateTime(2024, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7441), new DateTime(2024, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7442), new DateTime(2024, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7441), new DateTime(2024, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7444), new DateTime(2024, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7448), new DateTime(2024, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7446), new DateTime(2024, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7447), new DateTime(2024, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7447), new DateTime(2024, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7448), new DateTime(2024, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7451), new DateTime(2024, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7450), new DateTime(2024, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7451), new DateTime(2024, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7450), new DateTime(2024, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7452), new DateTime(2024, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7455), new DateTime(2024, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7454), new DateTime(2024, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7454), new DateTime(2024, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7454), new DateTime(2024, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7455), new DateTime(2024, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7458), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7457), new DateTime(2024, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7458), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7458), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7459), new DateTime(2024, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7463), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7462), new DateTime(2024, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7463), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7462), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7464), new DateTime(2024, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7467), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7465), new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7466), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7466), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7467), new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7470), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7469), new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7470), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7469), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7471), new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7474), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7472), new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7473), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7473), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7474), new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7477), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7476), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7477), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7476), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7478), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7481), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7479), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7480), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7480), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7481), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7484), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7483), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7484), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7483), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7485), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7505), new DateTime(2024, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7503), new DateTime(2024, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7504), new DateTime(2024, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7504), new DateTime(2024, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7506), new DateTime(2024, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7510), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7509), new DateTime(2024, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7509), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7509), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7510), new DateTime(2024, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7513), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7512), new DateTime(2024, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7513), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7512), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7514), new DateTime(2024, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7517), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7515), new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7516), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7516), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7517), new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7520), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7519), new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7520), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7519), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7521), new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7524), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7522), new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7523), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7523), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7524), new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7527), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7526), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7527), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7526), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7528), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7531), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7529), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7530), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7530), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7531), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7534), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7533), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7533), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7533), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7534), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7540), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7538), new DateTime(2024, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7539), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7538), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7540), new DateTime(2024, 5, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7544), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7543), new DateTime(2024, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7543), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7543), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7544), new DateTime(2024, 6, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7548), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7546), new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7547), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7547), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7548), new DateTime(2024, 7, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7551), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7550), new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7551), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7550), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7551), new DateTime(2024, 8, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7554), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7553), new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7554), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7553), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7555), new DateTime(2024, 9, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7623), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7622), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7623), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7622), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7624), new DateTime(2024, 10, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7626), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7625), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7626), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7626), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7627), new DateTime(2024, 11, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7630), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7628), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7629), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7629), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7630), new DateTime(2024, 12, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7633), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7632), new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7633), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7633), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7634), new DateTime(2025, 1, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7638), new DateTime(2024, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7636), new DateTime(2024, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7637), new DateTime(2024, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7637), new DateTime(2024, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7639), new DateTime(2024, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7642), new DateTime(2024, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7641), new DateTime(2024, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7642), new DateTime(2024, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7641), new DateTime(2024, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7643), new DateTime(2024, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7646), new DateTime(2024, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7645), new DateTime(2024, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7645), new DateTime(2024, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7645), new DateTime(2024, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7646), new DateTime(2024, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7650), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7648), new DateTime(2024, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7649), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7649), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7650), new DateTime(2024, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7653), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7652), new DateTime(2024, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7653), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7652), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7654), new DateTime(2024, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7656), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7655), new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7656), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7656), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7657), new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7660), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7659), new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7659), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7659), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7660), new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7663), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7662), new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7663), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7662), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7664), new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7667), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7665), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7666), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7666), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7667), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7670), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7669), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7670), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7669), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7671), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7674), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7672), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7673), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7673), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7674), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7677), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7676), new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7677), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7676), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7678), new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7681), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7680), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7680), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7681), new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7684), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7683), new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7683), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7683), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7684), new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7687), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7686), new DateTime(2025, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7687), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7686), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7688), new DateTime(2025, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7691), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7689), new DateTime(2025, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7690), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7690), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7691), new DateTime(2025, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7694), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7693), new DateTime(2025, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7694), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7693), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7695), new DateTime(2025, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7697), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7696), new DateTime(2025, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7697), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7696), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7698), new DateTime(2025, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7701), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7699), new DateTime(2025, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7700), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7700), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7701), new DateTime(2025, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7704), new DateTime(2025, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7702), new DateTime(2025, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7703), new DateTime(2025, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7703), new DateTime(2025, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7704), new DateTime(2025, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7707), new DateTime(2025, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7706), new DateTime(2025, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7707), new DateTime(2025, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7706), new DateTime(2025, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7707), new DateTime(2025, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7725), new DateTime(2024, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7723), new DateTime(2024, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7724), new DateTime(2024, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7723), new DateTime(2024, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7726), new DateTime(2024, 3, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7729), new DateTime(2024, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7728), new DateTime(2024, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7729), new DateTime(2024, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7729), new DateTime(2024, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7730), new DateTime(2024, 4, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7735), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7733), new DateTime(2024, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7734), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7734), new DateTime(2024, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7735), new DateTime(2024, 5, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7738), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7737), new DateTime(2024, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7738), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7737), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7739), new DateTime(2024, 6, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7742), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7741), new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7742), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7741), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7743), new DateTime(2024, 7, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7776), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7775), new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7775), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7775), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7776), new DateTime(2024, 8, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7779), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7778), new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7779), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7779), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7780), new DateTime(2024, 9, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7783), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7782), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7782), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7782), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7783), new DateTime(2024, 10, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7787), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7785), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7786), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7786), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7787), new DateTime(2024, 11, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7790), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7789), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7790), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7789), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7791), new DateTime(2024, 12, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7794), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7792), new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7794), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7793), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7795), new DateTime(2025, 1, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7797), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7796), new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7797), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7797), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7798), new DateTime(2025, 2, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7801), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7800), new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7800), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7800), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7801), new DateTime(2025, 3, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7804), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7803), new DateTime(2025, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7804), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7803), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7805), new DateTime(2025, 4, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7808), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7806), new DateTime(2025, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7807), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7807), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7808), new DateTime(2025, 5, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7811), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7810), new DateTime(2025, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7811), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7810), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7811), new DateTime(2025, 6, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7814), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7813), new DateTime(2025, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7814), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7814), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7815), new DateTime(2025, 7, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7818), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7817), new DateTime(2025, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7817), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7817), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7818), new DateTime(2025, 8, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7821), new DateTime(2025, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7820), new DateTime(2025, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7821), new DateTime(2025, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7820), new DateTime(2025, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7822), new DateTime(2025, 9, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7825), new DateTime(2025, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7824), new DateTime(2025, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7824), new DateTime(2025, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7825), new DateTime(2025, 10, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7828), new DateTime(2025, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7827), new DateTime(2025, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7828), new DateTime(2025, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7827), new DateTime(2025, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7829), new DateTime(2025, 11, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7833), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7831), new DateTime(2024, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7832), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7832), new DateTime(2024, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7834), new DateTime(2024, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7837), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7836), new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7837), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7836), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7838), new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7841), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7840), new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7840), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7840), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7841), new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7844), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7843), new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7844), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7843), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7845), new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7848), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7846), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7847), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7847), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7848), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7851), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7850), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7851), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7850), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7852), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7855), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7854), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7854), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7854), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7855), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7858), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7857), new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7858), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7857), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7859), new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7862), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7861), new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7862), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7861), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7862), new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7865), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7864), new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7865), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7865), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7866), new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7869), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7867), new DateTime(2025, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7868), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7868), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7869), new DateTime(2025, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7872), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7871), new DateTime(2025, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7871), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7871), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7872), new DateTime(2025, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7875), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7874), new DateTime(2025, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7875), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7874), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7876), new DateTime(2025, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7878), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7877), new DateTime(2025, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7878), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7878), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7879), new DateTime(2025, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7882), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7880), new DateTime(2025, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7881), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7881), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7882), new DateTime(2025, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7885), new DateTime(2025, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7884), new DateTime(2025, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7884), new DateTime(2025, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7884), new DateTime(2025, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7885), new DateTime(2025, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7890), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7888), new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7889), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7888), new DateTime(2024, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7891), new DateTime(2024, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7894), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7893), new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7894), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7893), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7895), new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7944), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7942), new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7943), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7943), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7944), new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7947), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7946), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7947), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7946), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7948), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7951), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7949), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7950), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7950), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7951), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7954), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7953), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7954), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7954), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7955), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7958), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7957), new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7958), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7957), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7959), new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7962), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7961), new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7962), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7961), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7963), new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7965), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7964), new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7965), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7965), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7966), new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7969), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7968), new DateTime(2025, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7968), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7968), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7969), new DateTime(2025, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7972), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7971), new DateTime(2025, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7972), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7971), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7973), new DateTime(2025, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7975), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7974), new DateTime(2025, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7975), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7975), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7976), new DateTime(2025, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7979), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7978), new DateTime(2025, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7978), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7978), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7979), new DateTime(2025, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7982), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7981), new DateTime(2025, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7982), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7981), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7983), new DateTime(2025, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7985), new DateTime(2025, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7984), new DateTime(2025, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7985), new DateTime(2025, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7985), new DateTime(2025, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7986), new DateTime(2025, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8002), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8000), new DateTime(2024, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8001), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8001), new DateTime(2024, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8003), new DateTime(2024, 8, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8007), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8005), new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8006), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8006), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8007), new DateTime(2024, 9, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8010), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8009), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8009), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8009), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8010), new DateTime(2024, 10, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8013), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8012), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8013), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8012), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8014), new DateTime(2024, 11, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8016), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8015), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8016), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8015), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8017), new DateTime(2024, 12, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8020), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8018), new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8019), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8019), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8021), new DateTime(2025, 1, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8023), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8022), new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8023), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8023), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8024), new DateTime(2025, 2, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8027), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8025), new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8026), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8026), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8027), new DateTime(2025, 3, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8031), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8029), new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8031), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8030), new DateTime(2024, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8032), new DateTime(2024, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8036), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8034), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8035), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8035), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8036), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8039), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8038), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8038), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8038), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8040), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8042), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8041), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8042), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8042), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8043), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8046), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8045), new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8046), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8045), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8047), new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8050), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8048), new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8049), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8049), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8050), new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8102), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8100), new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8101), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8101), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8102), new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8106), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8104), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8106), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 10, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8107), new DateTime(2024, 10, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8111), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8109), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8110), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8110), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8111), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8114), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8113), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8114), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8113), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8115), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8118), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8116), new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8117), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8117), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8118), new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8121), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8120), new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8121), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8120), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8122), new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8125), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8123), new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8124), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8124), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8125), new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8128), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8127), new DateTime(2025, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8127), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8127), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8128), new DateTime(2025, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8131), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8130), new DateTime(2025, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8131), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8130), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8132), new DateTime(2025, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8134), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8133), new DateTime(2025, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8134), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8133), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8135), new DateTime(2025, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8137), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8136), new DateTime(2025, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8137), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8137), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8138), new DateTime(2025, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8141), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8139), new DateTime(2025, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8140), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8140), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8141), new DateTime(2025, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8145), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8143), new DateTime(2024, 11, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8145), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8144), new DateTime(2024, 11, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8146), new DateTime(2024, 11, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8150), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8148), new DateTime(2024, 12, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8149), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8149), new DateTime(2024, 12, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8150), new DateTime(2024, 12, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8154), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8152), new DateTime(2025, 1, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8153), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8153), new DateTime(2025, 1, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8154), new DateTime(2025, 1, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8157), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8156), new DateTime(2025, 2, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8157), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8156), new DateTime(2025, 2, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8158), new DateTime(2025, 2, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8161), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8159), new DateTime(2025, 3, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8160), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8160), new DateTime(2025, 3, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8161), new DateTime(2025, 3, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8164), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8163), new DateTime(2025, 4, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8163), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8163), new DateTime(2025, 4, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8164), new DateTime(2025, 4, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8167), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8166), new DateTime(2025, 5, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8167), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8166), new DateTime(2025, 5, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8168), new DateTime(2025, 5, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8170), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8169), new DateTime(2025, 6, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8170), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8170), new DateTime(2025, 6, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8171), new DateTime(2025, 6, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8174), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8173), new DateTime(2025, 7, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8173), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8173), new DateTime(2025, 7, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8174), new DateTime(2025, 7, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8177), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8176), new DateTime(2025, 8, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8177), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8176), new DateTime(2025, 8, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8178), new DateTime(2025, 8, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8181), new DateTime(2025, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8179), new DateTime(2025, 9, 24, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8180), new DateTime(2025, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8180), new DateTime(2025, 9, 10, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8181), new DateTime(2025, 9, 23, 11, 44, 55, 80, DateTimeKind.Utc).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "SentDate" },
                values: new object[] { "Hi Henry, I saw your horror collection and wondered if you'd be open to a trade sometime. Also, I\nnoticed you might enjoy 'Preacher #1'—happy to lend if interested.", new DateTime(2025, 12, 7, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "IsRead", "SentDate" },
                values: new object[] { "Thanks, Diana! I'd love to borrow it for two weeks. We can meet in Malmö or Lund—whatever suits you.", false, new DateTime(2025, 12, 8, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId", "SentDate", "Subject" },
                values: new object[] { "Marcus, would you be up for swapping 'ASM #129' for a short read of 'Uncanny X-Men #129'?", false, 3, 1, new DateTime(2025, 12, 9, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(2973), "Trade idea" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateSubmitted",
                value: new DateTime(2024, 1, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateSubmitted",
                value: new DateTime(2023, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateSubmitted",
                value: new DateTime(2024, 1, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateSubmitted",
                value: new DateTime(2025, 4, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 24, 11, 44, 55, 84, DateTimeKind.Utc).AddTicks(1016));
        }
    }
}
