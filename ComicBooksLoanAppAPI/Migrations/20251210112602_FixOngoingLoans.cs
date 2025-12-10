using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicBooksLoanAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixOngoingLoans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 153, false, true, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 154, false, true, new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 155, false, true, new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 175, false, true, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 156, false, true, new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 159, false, true, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 160, false, true, new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 157, false, true, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 163, false, true, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 161, false, true, new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 164, false, true, new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 165, false, true, new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 158, false, true, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 166, false, true, new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 168, false, true, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 169, false, true, new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 162, false, true, new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 170, false, true, new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 171, false, true, new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 167, false, true, new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 172, false, true, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 173, false, true, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { 174, false, true, new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 25, 59, 960, DateTimeKind.Utc).AddTicks(9532), new DateTime(2023, 12, 10, 11, 25, 59, 960, DateTimeKind.Utc).AddTicks(8562), new DateTime(2023, 12, 24, 11, 25, 59, 960, DateTimeKind.Utc).AddTicks(9218), new DateTime(2023, 12, 10, 11, 25, 59, 960, DateTimeKind.Utc).AddTicks(8888), new DateTime(2023, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(147), new DateTime(2023, 12, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1134), new DateTime(2024, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1131), new DateTime(2024, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1133), new DateTime(2024, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1132), new DateTime(2024, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1135), new DateTime(2024, 1, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1139), new DateTime(2024, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1138), new DateTime(2024, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1139), new DateTime(2024, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1138), new DateTime(2024, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1140), new DateTime(2024, 2, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1143), new DateTime(2024, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1141), new DateTime(2024, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1142), new DateTime(2024, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1142), new DateTime(2024, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1143), new DateTime(2024, 3, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1146), new DateTime(2024, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1145), new DateTime(2024, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1146), new DateTime(2024, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1145), new DateTime(2024, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1147), new DateTime(2024, 4, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1153), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1152), new DateTime(2024, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1153), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1152), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1154), new DateTime(2024, 5, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1157), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1156), new DateTime(2024, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1156), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1156), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1157), new DateTime(2024, 6, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1161), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1160), new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1160), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1160), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1161), new DateTime(2024, 7, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1164), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1163), new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1164), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1163), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1164), new DateTime(2024, 8, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1168), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1167), new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1168), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1167), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1169), new DateTime(2024, 9, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1171), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1170), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1171), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1170), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1172), new DateTime(2024, 10, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1172) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1174), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1173), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1174), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1174), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1175), new DateTime(2024, 11, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1179), new DateTime(2024, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1177), new DateTime(2024, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1179), new DateTime(2024, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1178), new DateTime(2024, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1180), new DateTime(2024, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1181) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1184), new DateTime(2024, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1183), new DateTime(2024, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1183), new DateTime(2024, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1183), new DateTime(2024, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1184), new DateTime(2024, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1187), new DateTime(2024, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1186), new DateTime(2024, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1187), new DateTime(2024, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1187), new DateTime(2024, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1188), new DateTime(2024, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1191), new DateTime(2024, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1190), new DateTime(2024, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1190), new DateTime(2024, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1190), new DateTime(2024, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1191), new DateTime(2024, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1194), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1193), new DateTime(2024, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1194), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1193), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1195), new DateTime(2024, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1199), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1197), new DateTime(2024, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1198), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1198), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1199), new DateTime(2024, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1202), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1201), new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1202), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1201), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1203), new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1206), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1206), new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1209), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1208), new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1209), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1209), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1210), new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1213), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1211), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1212), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1212), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1213), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1216), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1215), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1216), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1215), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1217), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1217) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1256), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1255), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1256), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1255), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1257), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1277), new DateTime(2024, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1275), new DateTime(2024, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1276), new DateTime(2024, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1276), new DateTime(2024, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1278), new DateTime(2024, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1282), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1280), new DateTime(2024, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1281), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1281), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1282), new DateTime(2024, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1285), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1284), new DateTime(2024, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1285), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1284), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1286), new DateTime(2024, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1288), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1287), new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1288), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1287), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1289), new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1292), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1290), new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1291), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1291), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1292), new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1295), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1294), new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1294), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1294), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1295), new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1298), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1297), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1298), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1297), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1299), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1301), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1300), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1301), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1301), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1302), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1305), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1303), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1304), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1304), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1305), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1310), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1309), new DateTime(2024, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1310), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1309), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1311), new DateTime(2024, 5, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1315), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1314), new DateTime(2024, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1315), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1314), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1315), new DateTime(2024, 6, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1318), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1317), new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1318), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1317), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1319), new DateTime(2024, 7, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1322), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1321), new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1321), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1321), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1322), new DateTime(2024, 8, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1325), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1324), new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1325), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1324), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1326), new DateTime(2024, 9, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1328), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1327), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1328), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1328), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1329), new DateTime(2024, 10, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1332), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1331), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1332), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1331), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1333), new DateTime(2024, 11, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1335), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1334), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1335), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1335), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1336), new DateTime(2024, 12, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1339), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1338), new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1339), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1338), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1340), new DateTime(2025, 1, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1344), new DateTime(2024, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1342), new DateTime(2024, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1343), new DateTime(2024, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1343), new DateTime(2024, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1345), new DateTime(2024, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1348), new DateTime(2024, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1347), new DateTime(2024, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1348), new DateTime(2024, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1348), new DateTime(2024, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1349), new DateTime(2024, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1352), new DateTime(2024, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1351), new DateTime(2024, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1351), new DateTime(2024, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1351), new DateTime(2024, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1352), new DateTime(2024, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1355), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1354), new DateTime(2024, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1355), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1354), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1356), new DateTime(2024, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1358), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1357), new DateTime(2024, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1358), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1358), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1359), new DateTime(2024, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1362), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1360), new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1361), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1361), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1362), new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1365), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1364), new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1364), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1364), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1365), new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1368), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1367), new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1368), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1367), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1369), new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1371), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1370), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1371), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1371), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1372), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1375), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1373), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1374), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1374), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1375), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1378), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1377), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1378), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1377), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1379), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1382), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1380), new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1381), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1381), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1382), new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1451), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1449), new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1450), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1450), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1451), new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1454), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1453), new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1454), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1453), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1455), new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1457), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1456), new DateTime(2025, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1457), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1457), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1458), new DateTime(2025, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1461), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1459), new DateTime(2025, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1460), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1460), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1461), new DateTime(2025, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1464), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1463), new DateTime(2025, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1464), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1463), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1464), new DateTime(2025, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1467), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1466), new DateTime(2025, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1467), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1466), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1468), new DateTime(2025, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1471), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1469), new DateTime(2025, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1470), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1470), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1471), new DateTime(2025, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1474), new DateTime(2025, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1473), new DateTime(2025, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1473), new DateTime(2025, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1473), new DateTime(2025, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1474), new DateTime(2025, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1477), new DateTime(2025, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1476), new DateTime(2025, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1477), new DateTime(2025, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1476), new DateTime(2025, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1477), new DateTime(2025, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 3, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1495), new DateTime(2024, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1492), new DateTime(2024, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1494), new DateTime(2024, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1493), new DateTime(2024, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1495), new DateTime(2024, 3, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1499), new DateTime(2024, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1498), new DateTime(2024, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1499), new DateTime(2024, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1498), new DateTime(2024, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1500), new DateTime(2024, 4, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1504), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1503), new DateTime(2024, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1504), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1504), new DateTime(2024, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1505), new DateTime(2024, 5, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1508), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1507), new DateTime(2024, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1508), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1507), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1509), new DateTime(2024, 6, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1512), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1510), new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1511), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1511), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1512), new DateTime(2024, 7, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1515), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1514), new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1515), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1514), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1516), new DateTime(2024, 8, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1518), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1517), new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1518), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1518), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1519), new DateTime(2024, 9, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1522), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1521), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1521), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1521), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1522), new DateTime(2024, 10, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1525), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1524), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1525), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1524), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1526), new DateTime(2024, 11, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1529), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1527), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1528), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1528), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1529), new DateTime(2024, 12, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1532), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1531), new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1532), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1531), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1533), new DateTime(2025, 1, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1536), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1534), new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1535), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1535), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1537), new DateTime(2025, 2, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1539), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1538), new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1539), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1538), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1540), new DateTime(2025, 3, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1543), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1541), new DateTime(2025, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1542), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1542), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1543), new DateTime(2025, 4, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1546), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1545), new DateTime(2025, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1546), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1545), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1547), new DateTime(2025, 5, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1549), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1548), new DateTime(2025, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1549), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1549), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1550), new DateTime(2025, 6, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1553), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1552), new DateTime(2025, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1552), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1552), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1553), new DateTime(2025, 7, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1556), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1555), new DateTime(2025, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1556), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1555), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1557), new DateTime(2025, 8, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1559), new DateTime(2025, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1558), new DateTime(2025, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1559), new DateTime(2025, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1559), new DateTime(2025, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1560), new DateTime(2025, 9, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 10, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1563), new DateTime(2025, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1562), new DateTime(2025, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1562), new DateTime(2025, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1562), new DateTime(2025, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1563), new DateTime(2025, 10, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1606), new DateTime(2025, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1604), new DateTime(2025, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1605), new DateTime(2025, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1605), new DateTime(2025, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1606), new DateTime(2025, 11, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1611), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1609), new DateTime(2024, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1610), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1609), new DateTime(2024, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1612), new DateTime(2024, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1615), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1614), new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1615), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1614), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1616), new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1619), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1617), new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1618), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1618), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1619), new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1622), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1621), new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1622), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1621), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1622), new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1625), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1624), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1625), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1625), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1626), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1629), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1628), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1628), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1628), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1629), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1632), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1631), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1632), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1631), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1633), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1636), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1634), new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1635), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1635), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1636), new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1639), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1638), new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1639), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1638), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1640), new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1642), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1641), new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1642), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1642), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1643), new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1646), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1644), new DateTime(2025, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1645), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1645), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1646), new DateTime(2025, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1649), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1648), new DateTime(2025, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1648), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1648), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1649), new DateTime(2025, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1652), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1651), new DateTime(2025, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1652), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1651), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1653), new DateTime(2025, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1655), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1654), new DateTime(2025, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1655), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1654), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1656), new DateTime(2025, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1659), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1657), new DateTime(2025, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1658), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1658), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1659), new DateTime(2025, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1662), new DateTime(2025, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1661), new DateTime(2025, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1661), new DateTime(2025, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1661), new DateTime(2025, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1662), new DateTime(2025, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1667), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1665), new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1666), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1665), new DateTime(2024, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1667), new DateTime(2024, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1671), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1670), new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1671), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1670), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1672), new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1675), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1673), new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1674), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1674), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1675), new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1678), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1677), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1678), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1677), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1679), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1682), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1681), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1682), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1681), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1683), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1686), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1684), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1685), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1685), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1686), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1689), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1688), new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1689), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1688), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1690), new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1693), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1692), new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1692), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1692), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1693), new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1696), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1695), new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1696), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1695), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1697), new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1700), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1698), new DateTime(2025, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1699), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1699), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1700), new DateTime(2025, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1703), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1702), new DateTime(2025, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1702), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1702), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1703), new DateTime(2025, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1706), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1705), new DateTime(2025, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1706), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1705), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1707), new DateTime(2025, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1710), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1708), new DateTime(2025, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1709), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1709), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1710), new DateTime(2025, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1713), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1712), new DateTime(2025, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1713), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1712), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1714), new DateTime(2025, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1716), new DateTime(2025, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1715), new DateTime(2025, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1716), new DateTime(2025, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1716), new DateTime(2025, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1717), new DateTime(2025, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1733), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1730), new DateTime(2024, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1732), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1731), new DateTime(2024, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1733), new DateTime(2024, 8, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1737), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1736), new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1737), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1736), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1738), new DateTime(2024, 9, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1741), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1739), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1740), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1740), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1741), new DateTime(2024, 10, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1772), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1770), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1771), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1771), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1772), new DateTime(2024, 11, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1775), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1774), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1775), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1774), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1776), new DateTime(2024, 12, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1779), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1777), new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1778), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1778), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1779), new DateTime(2025, 1, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1782), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1781), new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1782), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1781), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1783), new DateTime(2025, 2, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1785), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1784), new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1785), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1784), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1786), new DateTime(2025, 3, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1790), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1788), new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1789), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1788), new DateTime(2024, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1791), new DateTime(2024, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1794), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1793), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1794), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1793), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1795), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1798), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1796), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1797), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1797), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1798), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1801), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1800), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1801), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1800), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1801), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1805), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1803), new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1804), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1804), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1805), new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1808), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1807), new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1808), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1807), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1809), new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1813), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1812), new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1812), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1812), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1813), new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1818), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1816), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1817), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1816), new DateTime(2024, 10, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1819), new DateTime(2024, 10, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1822), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1822), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1823), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1825), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1824), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1825), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1824), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1826), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1829), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1827), new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1828), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1828), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1829), new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1832), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1831), new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1832), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1831), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1833), new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1835), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1834), new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1835), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1834), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1836), new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1839), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1837), new DateTime(2025, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1838), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1838), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1839), new DateTime(2025, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1842), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1841), new DateTime(2025, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1841), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1841), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1842), new DateTime(2025, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1845), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1844), new DateTime(2025, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1844), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1844), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1845), new DateTime(2025, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1848), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1847), new DateTime(2025, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1848), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1847), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1849), new DateTime(2025, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1851), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1850), new DateTime(2025, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1851), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1850), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1852), new DateTime(2025, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 11, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1856), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1854), new DateTime(2024, 11, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1855), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1855), new DateTime(2024, 11, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1857), new DateTime(2024, 11, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2024, 12, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1861), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1859), new DateTime(2024, 12, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1860), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1860), new DateTime(2024, 12, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1861), new DateTime(2024, 12, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1892), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1890), new DateTime(2025, 1, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1891), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1891), new DateTime(2025, 1, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1892), new DateTime(2025, 1, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 2, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1896), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1894), new DateTime(2025, 2, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1895), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1895), new DateTime(2025, 2, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1896), new DateTime(2025, 2, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 3, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1899), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1898), new DateTime(2025, 3, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1899), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1898), new DateTime(2025, 3, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1900), new DateTime(2025, 3, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1902), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1901), new DateTime(2025, 4, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1902), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1901), new DateTime(2025, 4, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1903), new DateTime(2025, 4, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 5, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1906), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1904), new DateTime(2025, 5, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1905), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1905), new DateTime(2025, 5, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1906), new DateTime(2025, 5, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 6, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1909), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1908), new DateTime(2025, 6, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1909), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1908), new DateTime(2025, 6, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1909), new DateTime(2025, 6, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 7, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1912), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1911), new DateTime(2025, 7, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1912), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1911), new DateTime(2025, 7, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1913), new DateTime(2025, 7, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1916), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1914), new DateTime(2025, 8, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1915), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1915), new DateTime(2025, 8, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1916), new DateTime(2025, 8, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ActualReturnDate", "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 9, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1919), new DateTime(2025, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1918), new DateTime(2025, 9, 24, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1919), new DateTime(2025, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1918), new DateTime(2025, 9, 10, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1920), new DateTime(2025, 9, 23, 11, 25, 59, 961, DateTimeKind.Utc).AddTicks(1920) });

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
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateSubmitted",
                value: new DateTime(2024, 1, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateSubmitted",
                value: new DateTime(2023, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateSubmitted",
                value: new DateTime(2024, 1, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateSubmitted",
                value: new DateTime(2024, 2, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateSubmitted",
                value: new DateTime(2024, 3, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateSubmitted",
                value: new DateTime(2024, 4, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateSubmitted",
                value: new DateTime(2024, 5, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateSubmitted",
                value: new DateTime(2024, 6, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateSubmitted",
                value: new DateTime(2024, 7, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateSubmitted",
                value: new DateTime(2024, 8, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateSubmitted",
                value: new DateTime(2024, 9, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateSubmitted",
                value: new DateTime(2025, 4, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateSubmitted",
                value: new DateTime(2024, 10, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateSubmitted",
                value: new DateTime(2024, 11, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateSubmitted",
                value: new DateTime(2024, 12, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateSubmitted",
                value: new DateTime(2025, 1, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateSubmitted",
                value: new DateTime(2025, 2, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateSubmitted",
                value: new DateTime(2025, 3, 24, 11, 25, 59, 964, DateTimeKind.Utc).AddTicks(4655));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

            migrationBuilder.UpdateData(
                table: "Comics",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CurrentLoanId", "IsAvailable", "IsOnLoan", "LoanReturnDate" },
                values: new object[] { null, true, false, null });

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

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "LoanEndDate", "LoanStartDate", "MeetupDateTime", "ReturnMeetupDateTime" },
                values: new object[] { new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc) });

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
    }
}
