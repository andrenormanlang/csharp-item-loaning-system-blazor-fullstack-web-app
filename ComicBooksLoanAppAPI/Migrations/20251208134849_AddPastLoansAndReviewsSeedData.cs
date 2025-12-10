using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComicBooksLoanAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddPastLoansAndReviewsSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "ActualReturnDate", "BorrowerId", "BorrowerNotes", "BorrowerReceivedComic", "ComicId", "DateCreated", "LenderConfirmedReturn", "LenderId", "LenderNotes", "LoanDurationDays", "LoanEndDate", "LoanRequestId", "LoanStartDate", "MeetupDateTime", "MeetupLocation", "ReturnMeetupDateTime", "ReturnMeetupLocation", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(8049), 2, null, true, 1, new DateTime(2023, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(6940), true, 1, null, 14, new DateTime(2023, 12, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(7801), null, new DateTime(2023, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(7419), new DateTime(2023, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(8670), "Malmö Central Station", new DateTime(2023, 12, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9094), "Malmö Central Station", "Returned" },
                    { 2, new DateTime(2024, 1, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9727), 3, null, true, 2, new DateTime(2024, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9724), true, 1, null, 14, new DateTime(2024, 1, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9726), null, new DateTime(2024, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9725), new DateTime(2024, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9728), "Malmö Central Station", new DateTime(2024, 1, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9729), "Malmö Central Station", "Returned" },
                    { 3, new DateTime(2024, 2, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9733), 4, null, true, 3, new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9732), true, 1, null, 14, new DateTime(2024, 2, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9732), null, new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9732), new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9734), "Malmö Central Station", new DateTime(2024, 2, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9734), "Malmö Central Station", "Returned" },
                    { 4, new DateTime(2024, 3, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9737), 5, null, true, 4, new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9735), true, 1, null, 14, new DateTime(2024, 3, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9736), null, new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9736), new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9738), "Malmö Central Station", new DateTime(2024, 3, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9738), "Malmö Central Station", "Returned" },
                    { 5, new DateTime(2024, 4, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9741), 6, null, true, 1, new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9740), true, 1, null, 14, new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9741), null, new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9740), new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9742), "Malmö Central Station", new DateTime(2024, 4, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9742), "Malmö Central Station", "Returned" },
                    { 6, new DateTime(2024, 5, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9753), 2, null, true, 2, new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9751), true, 1, null, 14, new DateTime(2024, 5, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9752), null, new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9752), new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9753), "Malmö Central Station", new DateTime(2024, 5, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9754), "Malmö Central Station", "Returned" },
                    { 7, new DateTime(2024, 6, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9756), 3, null, true, 3, new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9755), true, 1, null, 14, new DateTime(2024, 6, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9756), null, new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9755), new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9757), "Malmö Central Station", new DateTime(2024, 6, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9757), "Malmö Central Station", "Returned" },
                    { 8, new DateTime(2024, 7, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9760), 4, null, true, 4, new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9758), true, 1, null, 14, new DateTime(2024, 7, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9759), null, new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9759), new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9760), "Malmö Central Station", new DateTime(2024, 7, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9761), "Malmö Central Station", "Returned" },
                    { 9, new DateTime(2024, 8, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9763), 5, null, true, 1, new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9762), true, 1, null, 14, new DateTime(2024, 8, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9762), null, new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9762), new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9763), "Malmö Central Station", new DateTime(2024, 8, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9764), "Malmö Central Station", "Returned" },
                    { 10, new DateTime(2024, 9, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9767), 6, null, true, 2, new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9766), true, 1, null, 14, new DateTime(2024, 9, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9766), null, new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9766), new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9767), "Malmö Central Station", new DateTime(2024, 9, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9768), "Malmö Central Station", "Returned" },
                    { 11, new DateTime(2024, 10, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9770), 2, null, true, 3, new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9769), true, 1, null, 14, new DateTime(2024, 10, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9770), null, new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9769), new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9771), "Malmö Central Station", new DateTime(2024, 10, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9771), "Malmö Central Station", "Returned" },
                    { 12, new DateTime(2024, 11, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9774), 3, null, true, 4, new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9772), true, 1, null, 14, new DateTime(2024, 11, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9773), null, new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9773), new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9774), "Malmö Central Station", new DateTime(2024, 11, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9775), "Malmö Central Station", "Returned" },
                    { 13, new DateTime(2024, 1, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9778), 1, null, true, 5, new DateTime(2024, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9776), true, 2, null, 14, new DateTime(2024, 1, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9778), null, new DateTime(2024, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9777), new DateTime(2024, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9779), "Malmö Triangeln", new DateTime(2024, 1, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9780), "Malmö Triangeln", "Returned" },
                    { 14, new DateTime(2024, 2, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9783), 1, null, true, 10, new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9782), true, 3, null, 14, new DateTime(2024, 2, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9783), null, new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9782), new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9784), "Malmö Triangeln", new DateTime(2024, 2, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9784), "Malmö Triangeln", "Returned" },
                    { 15, new DateTime(2024, 3, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9787), 1, null, true, 16, new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9785), true, 4, null, 14, new DateTime(2024, 3, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9786), null, new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9786), new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9787), "Malmö Triangeln", new DateTime(2024, 3, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9788), "Malmö Triangeln", "Returned" },
                    { 16, new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9790), 1, null, true, 22, new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9789), true, 5, null, 14, new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9790), null, new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9789), new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9791), "Malmö Triangeln", new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9791), "Malmö Triangeln", "Returned" },
                    { 17, new DateTime(2024, 5, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9794), 1, null, true, 28, new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9792), true, 6, null, 14, new DateTime(2024, 5, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9793), null, new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9793), new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9794), "Malmö Triangeln", new DateTime(2024, 5, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9795), "Malmö Triangeln", "Returned" },
                    { 18, new DateTime(2024, 6, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9798), 1, null, true, 6, new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9797), true, 2, null, 14, new DateTime(2024, 6, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9798), null, new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9797), new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9799), "Malmö Triangeln", new DateTime(2024, 6, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9799), "Malmö Triangeln", "Returned" },
                    { 19, new DateTime(2024, 7, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9802), 1, null, true, 10, new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9800), true, 3, null, 14, new DateTime(2024, 7, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9801), null, new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9801), new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9802), "Malmö Triangeln", new DateTime(2024, 7, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9803), "Malmö Triangeln", "Returned" },
                    { 20, new DateTime(2024, 8, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9881), 1, null, true, 16, new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9880), true, 4, null, 14, new DateTime(2024, 8, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9881), null, new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9880), new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9882), "Malmö Triangeln", new DateTime(2024, 8, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9882), "Malmö Triangeln", "Returned" },
                    { 21, new DateTime(2024, 9, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9885), 1, null, true, 22, new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9884), true, 5, null, 14, new DateTime(2024, 9, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9885), null, new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9884), new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9886), "Malmö Triangeln", new DateTime(2024, 9, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9886), "Malmö Triangeln", "Returned" },
                    { 22, new DateTime(2024, 10, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9889), 1, null, true, 26, new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9887), true, 6, null, 14, new DateTime(2024, 10, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9888), null, new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9888), new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9889), "Malmö Triangeln", new DateTime(2024, 10, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9890), "Malmö Triangeln", "Returned" },
                    { 23, new DateTime(2024, 11, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9892), 1, null, true, 7, new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9891), true, 2, null, 14, new DateTime(2024, 11, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9892), null, new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9891), new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9893), "Malmö Triangeln", new DateTime(2024, 11, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9893), "Malmö Triangeln", "Returned" },
                    { 24, new DateTime(2024, 12, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9896), 1, null, true, 10, new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9894), true, 3, null, 14, new DateTime(2024, 12, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9895), null, new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9895), new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9896), "Malmö Triangeln", new DateTime(2024, 12, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9897), "Malmö Triangeln", "Returned" },
                    { 25, new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9900), 1, null, true, 5, new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9898), true, 2, null, 14, new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9900), null, new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9899), new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9901), "Lund University Library", new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9902), "Lund University Library", "Returned" },
                    { 26, new DateTime(2024, 5, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9905), 6, null, true, 6, new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9904), true, 2, null, 14, new DateTime(2024, 5, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9905), null, new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9904), new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9906), "Lund University Library", new DateTime(2024, 5, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9906), "Lund University Library", "Returned" },
                    { 27, new DateTime(2024, 6, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9909), 3, null, true, 7, new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9908), true, 2, null, 14, new DateTime(2024, 6, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9908), null, new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9908), new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9909), "Lund University Library", new DateTime(2024, 6, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9910), "Lund University Library", "Returned" },
                    { 28, new DateTime(2024, 7, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9912), 4, null, true, 8, new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9911), true, 2, null, 14, new DateTime(2024, 7, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9912), null, new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9911), new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9913), "Lund University Library", new DateTime(2024, 7, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9913), "Lund University Library", "Returned" },
                    { 29, new DateTime(2024, 8, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9916), 5, null, true, 5, new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9914), true, 2, null, 14, new DateTime(2024, 8, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9915), null, new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9915), new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9916), "Lund University Library", new DateTime(2024, 8, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9917), "Lund University Library", "Returned" },
                    { 30, new DateTime(2024, 9, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9919), 1, null, true, 6, new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9918), true, 2, null, 14, new DateTime(2024, 9, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9919), null, new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9918), new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9920), "Lund University Library", new DateTime(2024, 9, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9920), "Lund University Library", "Returned" },
                    { 31, new DateTime(2024, 10, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9922), 6, null, true, 7, new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9921), true, 2, null, 14, new DateTime(2024, 10, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9922), null, new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9922), new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9923), "Lund University Library", new DateTime(2024, 10, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9924), "Lund University Library", "Returned" },
                    { 32, new DateTime(2024, 11, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9926), 3, null, true, 8, new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9925), true, 2, null, 14, new DateTime(2024, 11, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9926), null, new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9925), new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9927), "Lund University Library", new DateTime(2024, 11, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9927), "Lund University Library", "Returned" },
                    { 33, new DateTime(2024, 12, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9929), 4, null, true, 5, new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9928), true, 2, null, 14, new DateTime(2024, 12, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9929), null, new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9928), new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9930), "Lund University Library", new DateTime(2024, 12, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9930), "Lund University Library", "Returned" },
                    { 34, new DateTime(2024, 5, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9955), 2, null, true, 9, new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9952), true, 3, null, 14, new DateTime(2024, 5, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9954), null, new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9953), new DateTime(2024, 5, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9956), "Lund Central", new DateTime(2024, 5, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9957), "Lund Central", "Returned" },
                    { 35, new DateTime(2024, 6, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9960), 2, null, true, 15, new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9959), true, 4, null, 14, new DateTime(2024, 6, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9959), null, new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9959), new DateTime(2024, 6, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9960), "Lund Central", new DateTime(2024, 6, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9961), "Lund Central", "Returned" },
                    { 36, new DateTime(2024, 7, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9964), 2, null, true, 21, new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9962), true, 5, null, 14, new DateTime(2024, 7, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9963), null, new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9963), new DateTime(2024, 7, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9964), "Lund Central", new DateTime(2024, 7, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9965), "Lund Central", "Returned" },
                    { 37, new DateTime(2024, 8, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9967), 2, null, true, 27, new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9966), true, 6, null, 14, new DateTime(2024, 8, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9967), null, new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9966), new DateTime(2024, 8, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9967), "Lund Central", new DateTime(2024, 8, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9968), "Lund Central", "Returned" },
                    { 38, new DateTime(2024, 9, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9970), 2, null, true, 13, new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9969), true, 3, null, 14, new DateTime(2024, 9, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9970), null, new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9969), new DateTime(2024, 9, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9971), "Lund Central", new DateTime(2024, 9, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9971), "Lund Central", "Returned" },
                    { 39, new DateTime(2024, 10, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9974), 2, null, true, 14, new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9973), true, 4, null, 14, new DateTime(2024, 10, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9973), null, new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9973), new DateTime(2024, 10, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9974), "Lund Central", new DateTime(2024, 10, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9975), "Lund Central", "Returned" },
                    { 40, new DateTime(2024, 11, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9977), 2, null, true, 20, new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9976), true, 5, null, 14, new DateTime(2024, 11, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9977), null, new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9976), new DateTime(2024, 11, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9978), "Lund Central", new DateTime(2024, 11, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9978), "Lund Central", "Returned" },
                    { 41, new DateTime(2024, 12, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9981), 2, null, true, 24, new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9979), true, 6, null, 14, new DateTime(2024, 12, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9980), null, new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9980), new DateTime(2024, 12, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9981), "Lund Central", new DateTime(2024, 12, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9982), "Lund Central", "Returned" },
                    { 42, new DateTime(2025, 1, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9985), 2, null, true, 12, new DateTime(2025, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9983), true, 3, null, 14, new DateTime(2025, 1, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9985), null, new DateTime(2025, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9984), new DateTime(2025, 1, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9986), "Lund Central", new DateTime(2025, 1, 21, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9986), "Lund Central", "Returned" },
                    { 43, new DateTime(2024, 2, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9990), 1, null, true, 9, new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9988), true, 3, null, 14, new DateTime(2024, 2, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9989), null, new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9989), new DateTime(2024, 2, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9991), "Helsingborg Central Station", new DateTime(2024, 2, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9992), "Helsingborg Central Station", "Returned" },
                    { 44, new DateTime(2024, 3, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9995), 2, null, true, 10, new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9993), true, 3, null, 14, new DateTime(2024, 3, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9994), null, new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9994), new DateTime(2024, 3, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9995), "Helsingborg Central Station", new DateTime(2024, 3, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9996), "Helsingborg Central Station", "Returned" },
                    { 45, new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9998), 6, null, true, 11, new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9997), true, 3, null, 14, new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9998), null, new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9997), new DateTime(2024, 4, 8, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9999), "Helsingborg Central Station", new DateTime(2024, 4, 22, 13, 48, 49, 25, DateTimeKind.Utc).AddTicks(9999), "Helsingborg Central Station", "Returned" },
                    { 46, new DateTime(2024, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(2), 4, null, true, 12, new DateTime(2024, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc), true, 3, null, 14, new DateTime(2024, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(1), null, new DateTime(2024, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(1), new DateTime(2024, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(2), "Helsingborg Central Station", new DateTime(2024, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(2), "Helsingborg Central Station", "Returned" },
                    { 47, new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(5), 5, null, true, 13, new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(4), true, 3, null, 14, new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(4), null, new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(4), new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(5), "Helsingborg Central Station", new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(6), "Helsingborg Central Station", "Returned" },
                    { 48, new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(8), 1, null, true, 9, new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(7), true, 3, null, 14, new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(8), null, new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(7), new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9), "Helsingborg Central Station", new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9), "Helsingborg Central Station", "Returned" },
                    { 49, new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(12), 2, null, true, 10, new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(10), true, 3, null, 14, new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(11), null, new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(11), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(12), "Helsingborg Central Station", new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(13), "Helsingborg Central Station", "Returned" },
                    { 50, new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(15), 6, null, true, 11, new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(14), true, 3, null, 14, new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(15), null, new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(14), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(16), "Helsingborg Central Station", new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(16), "Helsingborg Central Station", "Returned" },
                    { 51, new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(18), 4, null, true, 12, new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(17), true, 3, null, 14, new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(18), null, new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(18), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(19), "Helsingborg Central Station", new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(19), "Helsingborg Central Station", "Returned" },
                    { 52, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(52), 5, null, true, 13, new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(51), true, 3, null, 14, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(52), null, new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(51), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(53), "Helsingborg Central Station", new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(53), "Helsingborg Central Station", "Returned" },
                    { 53, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(56), 1, null, true, 9, new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(54), true, 3, null, 14, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(55), null, new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(55), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(56), "Helsingborg Central Station", new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(57), "Helsingborg Central Station", "Returned" },
                    { 54, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(59), 2, null, true, 10, new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(58), true, 3, null, 14, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(59), null, new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(58), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(60), "Helsingborg Central Station", new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(61), "Helsingborg Central Station", "Returned" },
                    { 55, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(63), 6, null, true, 11, new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(62), true, 3, null, 14, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(63), null, new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(62), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(64), "Helsingborg Central Station", new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(64), "Helsingborg Central Station", "Returned" },
                    { 56, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(66), 4, null, true, 12, new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(65), true, 3, null, 14, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(66), null, new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(66), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(67), "Helsingborg Central Station", new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(68), "Helsingborg Central Station", "Returned" },
                    { 57, new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(70), 5, null, true, 13, new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(69), true, 3, null, 14, new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(69), null, new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(69), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(70), "Helsingborg Central Station", new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(71), "Helsingborg Central Station", "Returned" },
                    { 58, new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(73), 1, null, true, 9, new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(72), true, 3, null, 14, new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(73), null, new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(72), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(74), "Helsingborg Central Station", new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(74), "Helsingborg Central Station", "Returned" },
                    { 59, new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(76), 2, null, true, 10, new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(75), true, 3, null, 14, new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(76), null, new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(76), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(77), "Helsingborg Central Station", new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(77), "Helsingborg Central Station", "Returned" },
                    { 60, new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(80), 6, null, true, 11, new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(78), true, 3, null, 14, new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(79), null, new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(79), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(80), "Helsingborg Central Station", new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(81), "Helsingborg Central Station", "Returned" },
                    { 61, new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(83), 4, null, true, 12, new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(82), true, 3, null, 14, new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(82), null, new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(82), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(83), "Helsingborg Central Station", new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(84), "Helsingborg Central Station", "Returned" },
                    { 62, new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(86), 5, null, true, 13, new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(85), true, 3, null, 14, new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(86), null, new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(85), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(87), "Helsingborg Central Station", new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(87), "Helsingborg Central Station", "Returned" },
                    { 63, new DateTime(2025, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(89), 1, null, true, 9, new DateTime(2025, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(88), true, 3, null, 14, new DateTime(2025, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(89), null, new DateTime(2025, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(89), new DateTime(2025, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(90), "Helsingborg Central Station", new DateTime(2025, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(90), "Helsingborg Central Station", "Returned" },
                    { 64, new DateTime(2024, 3, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(94), 3, null, true, 1, new DateTime(2024, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(92), true, 1, null, 14, new DateTime(2024, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(93), null, new DateTime(2024, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(93), new DateTime(2024, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(95), "Helsingborg Knutpunkten", new DateTime(2024, 3, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(96), "Helsingborg Knutpunkten", "Returned" },
                    { 65, new DateTime(2024, 4, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(99), 3, null, true, 6, new DateTime(2024, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(98), true, 2, null, 14, new DateTime(2024, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(98), null, new DateTime(2024, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(98), new DateTime(2024, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(99), "Helsingborg Knutpunkten", new DateTime(2024, 4, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(100), "Helsingborg Knutpunkten", "Returned" },
                    { 66, new DateTime(2024, 5, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(104), 3, null, true, 26, new DateTime(2024, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(102), true, 6, null, 14, new DateTime(2024, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(103), null, new DateTime(2024, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(103), new DateTime(2024, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(104), "Helsingborg Knutpunkten", new DateTime(2024, 5, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(105), "Helsingborg Knutpunkten", "Returned" },
                    { 67, new DateTime(2024, 6, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(107), 3, null, true, 17, new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(106), true, 4, null, 14, new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(107), null, new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(107), new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(108), "Helsingborg Knutpunkten", new DateTime(2024, 6, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(108), "Helsingborg Knutpunkten", "Returned" },
                    { 68, new DateTime(2024, 7, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(111), 3, null, true, 23, new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(110), true, 5, null, 14, new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(110), null, new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(110), new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(111), "Helsingborg Knutpunkten", new DateTime(2024, 7, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(112), "Helsingborg Knutpunkten", "Returned" },
                    { 69, new DateTime(2024, 8, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(114), 3, null, true, 2, new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(113), true, 1, null, 14, new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(114), null, new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(113), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(115), "Helsingborg Knutpunkten", new DateTime(2024, 8, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(115), "Helsingborg Knutpunkten", "Returned" },
                    { 70, new DateTime(2024, 9, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(118), 3, null, true, 7, new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(117), true, 2, null, 14, new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(117), null, new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(117), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(118), "Helsingborg Knutpunkten", new DateTime(2024, 9, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(119), "Helsingborg Knutpunkten", "Returned" },
                    { 71, new DateTime(2024, 10, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(121), 3, null, true, 24, new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(120), true, 6, null, 14, new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(121), null, new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(122), "Helsingborg Knutpunkten", new DateTime(2024, 10, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(122), "Helsingborg Knutpunkten", "Returned" },
                    { 72, new DateTime(2024, 11, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(125), 3, null, true, 17, new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(124), true, 4, null, 14, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(125), null, new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(124), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(126), "Helsingborg Knutpunkten", new DateTime(2024, 11, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(126), "Helsingborg Knutpunkten", "Returned" },
                    { 73, new DateTime(2024, 12, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(129), 3, null, true, 23, new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(127), true, 5, null, 14, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(128), null, new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(128), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(129), "Helsingborg Knutpunkten", new DateTime(2024, 12, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(130), "Helsingborg Knutpunkten", "Returned" },
                    { 74, new DateTime(2025, 1, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(132), 3, null, true, 3, new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(131), true, 1, null, 14, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(132), null, new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(131), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(133), "Helsingborg Knutpunkten", new DateTime(2025, 1, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(133), "Helsingborg Knutpunkten", "Returned" },
                    { 75, new DateTime(2025, 2, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(136), 3, null, true, 8, new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(135), true, 2, null, 14, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(136), null, new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(135), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(136), "Helsingborg Knutpunkten", new DateTime(2025, 2, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(137), "Helsingborg Knutpunkten", "Returned" },
                    { 76, new DateTime(2025, 3, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(139), 3, null, true, 29, new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(138), true, 6, null, 14, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(139), null, new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(138), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(140), "Helsingborg Knutpunkten", new DateTime(2025, 3, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(140), "Helsingborg Knutpunkten", "Returned" },
                    { 77, new DateTime(2025, 4, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(143), 3, null, true, 17, new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(142), true, 4, null, 14, new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(142), null, new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(142), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(143), "Helsingborg Knutpunkten", new DateTime(2025, 4, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(144), "Helsingborg Knutpunkten", "Returned" },
                    { 78, new DateTime(2025, 5, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(146), 3, null, true, 23, new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(145), true, 5, null, 14, new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(146), null, new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(145), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(147), "Helsingborg Knutpunkten", new DateTime(2025, 5, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(147), "Helsingborg Knutpunkten", "Returned" },
                    { 79, new DateTime(2025, 6, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(150), 3, null, true, 4, new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(148), true, 1, null, 14, new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(149), null, new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(149), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(150), "Helsingborg Knutpunkten", new DateTime(2025, 6, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(151), "Helsingborg Knutpunkten", "Returned" },
                    { 80, new DateTime(2025, 7, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(153), 3, null, true, 5, new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(152), true, 2, null, 14, new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(153), null, new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(152), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(154), "Helsingborg Knutpunkten", new DateTime(2025, 7, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(154), "Helsingborg Knutpunkten", "Returned" },
                    { 81, new DateTime(2025, 8, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(183), 3, null, true, 27, new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(182), true, 6, null, 14, new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(182), null, new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(182), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(183), "Helsingborg Knutpunkten", new DateTime(2025, 8, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(184), "Helsingborg Knutpunkten", "Returned" },
                    { 82, new DateTime(2025, 9, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(186), 3, null, true, 17, new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(185), true, 4, null, 14, new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(186), null, new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(186), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(187), "Helsingborg Knutpunkten", new DateTime(2025, 9, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(187), "Helsingborg Knutpunkten", "Returned" },
                    { 83, new DateTime(2025, 10, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(190), 3, null, true, 23, new DateTime(2025, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(189), true, 5, null, 14, new DateTime(2025, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(189), null, new DateTime(2025, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(189), new DateTime(2025, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(190), "Helsingborg Knutpunkten", new DateTime(2025, 10, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(191), "Helsingborg Knutpunkten", "Returned" },
                    { 84, new DateTime(2025, 11, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(193), 3, null, true, 1, new DateTime(2025, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(192), true, 1, null, 14, new DateTime(2025, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(193), null, new DateTime(2025, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(192), new DateTime(2025, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(194), "Helsingborg Knutpunkten", new DateTime(2025, 11, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(194), "Helsingborg Knutpunkten", "Returned" },
                    { 85, new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(211), 1, null, true, 14, new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(209), true, 4, null, 14, new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(210), null, new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(209), new DateTime(2024, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(212), "Malmö Västra Hamnen", new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(213), "Malmö Västra Hamnen", "Returned" },
                    { 86, new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(216), 2, null, true, 15, new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(214), true, 4, null, 14, new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(215), null, new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(215), new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(216), "Malmö Västra Hamnen", new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(217), "Malmö Västra Hamnen", "Returned" },
                    { 87, new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(219), 3, null, true, 16, new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(218), true, 4, null, 14, new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(219), null, new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(218), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(220), "Malmö Västra Hamnen", new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(220), "Malmö Västra Hamnen", "Returned" },
                    { 88, new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(223), 6, null, true, 17, new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(221), true, 4, null, 14, new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(222), null, new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(222), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(223), "Malmö Västra Hamnen", new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(224), "Malmö Västra Hamnen", "Returned" },
                    { 89, new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(226), 5, null, true, 18, new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(225), true, 4, null, 14, new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(226), null, new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(225), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(227), "Malmö Västra Hamnen", new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(227), "Malmö Västra Hamnen", "Returned" },
                    { 90, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(230), 1, null, true, 14, new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(228), true, 4, null, 14, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(229), null, new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(229), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(230), "Malmö Västra Hamnen", new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(231), "Malmö Västra Hamnen", "Returned" },
                    { 91, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(233), 2, null, true, 15, new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(232), true, 4, null, 14, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(233), null, new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(232), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(233), "Malmö Västra Hamnen", new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(234), "Malmö Västra Hamnen", "Returned" },
                    { 92, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(237), 3, null, true, 16, new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(235), true, 4, null, 14, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(236), null, new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(236), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(237), "Malmö Västra Hamnen", new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(238), "Malmö Västra Hamnen", "Returned" },
                    { 93, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(240), 6, null, true, 17, new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(239), true, 4, null, 14, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(240), null, new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(239), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(241), "Malmö Västra Hamnen", new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(241), "Malmö Västra Hamnen", "Returned" },
                    { 94, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(244), 5, null, true, 18, new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(242), true, 4, null, 14, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(243), null, new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(243), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(244), "Malmö Västra Hamnen", new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(244), "Malmö Västra Hamnen", "Returned" },
                    { 95, new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(247), 1, null, true, 14, new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(246), true, 4, null, 14, new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(247), null, new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(246), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(247), "Malmö Västra Hamnen", new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(248), "Malmö Västra Hamnen", "Returned" },
                    { 96, new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(250), 2, null, true, 15, new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(249), true, 4, null, 14, new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(250), null, new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(249), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(251), "Malmö Västra Hamnen", new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(251), "Malmö Västra Hamnen", "Returned" },
                    { 97, new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(253), 3, null, true, 16, new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(252), true, 4, null, 14, new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(253), null, new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(253), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(254), "Malmö Västra Hamnen", new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(254), "Malmö Västra Hamnen", "Returned" },
                    { 98, new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(257), 6, null, true, 17, new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(256), true, 4, null, 14, new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(256), null, new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(256), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(257), "Malmö Västra Hamnen", new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(258), "Malmö Västra Hamnen", "Returned" },
                    { 99, new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(260), 5, null, true, 18, new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(259), true, 4, null, 14, new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(260), null, new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(259), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(261), "Malmö Västra Hamnen", new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(261), "Malmö Västra Hamnen", "Returned" },
                    { 100, new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(263), 1, null, true, 14, new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(262), true, 4, null, 14, new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(263), null, new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(262), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(264), "Malmö Västra Hamnen", new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(264), "Malmö Västra Hamnen", "Returned" },
                    { 101, new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(268), 4, null, true, 1, new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(266), true, 1, null, 14, new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(267), null, new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(267), new DateTime(2024, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(269), "Malmö City Library", new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(270), "Malmö City Library", "Returned" },
                    { 102, new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(273), 4, null, true, 6, new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(271), true, 2, null, 14, new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(272), null, new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(272), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(273), "Malmö City Library", new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(274), "Malmö City Library", "Returned" },
                    { 103, new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(277), 4, null, true, 11, new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(275), true, 3, null, 14, new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(276), null, new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(276), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(277), "Malmö City Library", new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(278), "Malmö City Library", "Returned" },
                    { 104, new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(280), 4, null, true, 27, new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(279), true, 6, null, 14, new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(280), null, new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(279), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(281), "Malmö City Library", new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(281), "Malmö City Library", "Returned" },
                    { 105, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(284), 4, null, true, 23, new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(283), true, 5, null, 14, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(283), null, new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(283), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(284), "Malmö City Library", new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(285), "Malmö City Library", "Returned" },
                    { 106, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(288), 4, null, true, 2, new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(286), true, 1, null, 14, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(287), null, new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(287), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(288), "Malmö City Library", new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(289), "Malmö City Library", "Returned" },
                    { 107, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(291), 4, null, true, 7, new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(290), true, 2, null, 14, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(291), null, new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(290), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(292), "Malmö City Library", new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(292), "Malmö City Library", "Returned" },
                    { 108, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(295), 4, null, true, 11, new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(294), true, 3, null, 14, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(295), null, new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(294), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(296), "Malmö City Library", new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(296), "Malmö City Library", "Returned" },
                    { 109, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(298), 4, null, true, 25, new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(297), true, 6, null, 14, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(298), null, new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(298), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(299), "Malmö City Library", new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(299), "Malmö City Library", "Returned" },
                    { 110, new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(302), 4, null, true, 23, new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(301), true, 5, null, 14, new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(302), null, new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(301), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(303), "Malmö City Library", new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(303), "Malmö City Library", "Returned" },
                    { 111, new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(306), 4, null, true, 3, new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(304), true, 1, null, 14, new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(305), null, new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(305), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(306), "Malmö City Library", new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(307), "Malmö City Library", "Returned" },
                    { 112, new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(309), 4, null, true, 8, new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(308), true, 2, null, 14, new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(309), null, new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(308), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(310), "Malmö City Library", new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(310), "Malmö City Library", "Returned" },
                    { 113, new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(312), 4, null, true, 11, new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(311), true, 3, null, 14, new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(312), null, new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(312), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(313), "Malmö City Library", new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(313), "Malmö City Library", "Returned" },
                    { 114, new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(316), 4, null, true, 30, new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(315), true, 6, null, 14, new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(315), null, new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(315), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(316), "Malmö City Library", new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(317), "Malmö City Library", "Returned" },
                    { 115, new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(319), 4, null, true, 23, new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(318), true, 5, null, 14, new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(319), null, new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(319), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(320), "Malmö City Library", new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(320), "Malmö City Library", "Returned" },
                    { 116, new DateTime(2024, 8, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(363), 1, null, true, 19, new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(360), true, 5, null, 14, new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(362), null, new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(361), new DateTime(2024, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(363), "Lund University", new DateTime(2024, 8, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(364), "Lund University", "Returned" },
                    { 117, new DateTime(2024, 9, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(367), 2, null, true, 20, new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(366), true, 5, null, 14, new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(367), null, new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(366), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(368), "Lund University", new DateTime(2024, 9, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(368), "Lund University", "Returned" },
                    { 118, new DateTime(2024, 10, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(371), 3, null, true, 21, new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(369), true, 5, null, 14, new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(370), null, new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(370), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(371), "Lund University", new DateTime(2024, 10, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(372), "Lund University", "Returned" },
                    { 119, new DateTime(2024, 11, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(374), 4, null, true, 22, new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(373), true, 5, null, 14, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(373), null, new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(373), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(374), "Lund University", new DateTime(2024, 11, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(375), "Lund University", "Returned" },
                    { 120, new DateTime(2024, 12, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(377), 1, null, true, 23, new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(376), true, 5, null, 14, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(377), null, new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(376), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(378), "Lund University", new DateTime(2024, 12, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(378), "Lund University", "Returned" },
                    { 121, new DateTime(2025, 1, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(381), 2, null, true, 19, new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(379), true, 5, null, 14, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(380), null, new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(380), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(381), "Lund University", new DateTime(2025, 1, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(382), "Lund University", "Returned" },
                    { 122, new DateTime(2025, 2, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(384), 3, null, true, 20, new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(383), true, 5, null, 14, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(384), null, new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(383), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(385), "Lund University", new DateTime(2025, 2, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(385), "Lund University", "Returned" },
                    { 123, new DateTime(2025, 3, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(387), 4, null, true, 21, new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(386), true, 5, null, 14, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(387), null, new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(387), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(388), "Lund University", new DateTime(2025, 3, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(388), "Lund University", "Returned" },
                    { 124, new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(392), 5, null, true, 1, new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(390), true, 1, null, 14, new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(392), null, new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(391), new DateTime(2024, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(393), "Lund Central", new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(394), "Lund Central", "Returned" },
                    { 125, new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(397), 5, null, true, 6, new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(396), true, 2, null, 14, new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(396), null, new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(396), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(397), "Lund Central", new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(398), "Lund Central", "Returned" },
                    { 126, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(400), 5, null, true, 11, new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(399), true, 3, null, 14, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(400), null, new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(399), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(401), "Lund Central", new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(401), "Lund Central", "Returned" },
                    { 127, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(404), 5, null, true, 17, new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(403), true, 4, null, 14, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(403), null, new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(403), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(404), "Lund Central", new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(405), "Lund Central", "Returned" },
                    { 128, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(408), 5, null, true, 1, new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(406), true, 1, null, 14, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(407), null, new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(407), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(408), "Lund Central", new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(409), "Lund Central", "Returned" },
                    { 129, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(411), 5, null, true, 6, new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(410), true, 2, null, 14, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(411), null, new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(410), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(412), "Lund Central", new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(412), "Lund Central", "Returned" },
                    { 130, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(417), 5, null, true, 10, new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(415), true, 3, null, 14, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(416), null, new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(416), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(417), "Lund Central", new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(417), "Lund Central", "Returned" },
                    { 131, new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(421), 1, null, true, 24, new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(419), true, 6, null, 14, new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(420), null, new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(420), new DateTime(2024, 10, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(422), "Malmö Möllevången", new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(423), "Malmö Möllevången", "Returned" },
                    { 132, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(426), 2, null, true, 25, new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(424), true, 6, null, 14, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(425), null, new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(425), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(426), "Malmö Möllevången", new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(427), "Malmö Möllevången", "Returned" },
                    { 133, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(429), 3, null, true, 26, new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(428), true, 6, null, 14, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(429), null, new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(428), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(430), "Malmö Möllevången", new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(430), "Malmö Möllevången", "Returned" },
                    { 134, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(433), 4, null, true, 27, new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(431), true, 6, null, 14, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(432), null, new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(432), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(433), "Malmö Möllevången", new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(434), "Malmö Möllevången", "Returned" },
                    { 135, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(436), 5, null, true, 28, new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(435), true, 6, null, 14, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(436), null, new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(435), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(437), "Malmö Möllevången", new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(437), "Malmö Möllevången", "Returned" },
                    { 136, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(440), 1, null, true, 29, new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(438), true, 6, null, 14, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(439), null, new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(439), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(440), "Malmö Möllevången", new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(441), "Malmö Möllevången", "Returned" },
                    { 137, new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(443), 2, null, true, 30, new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(442), true, 6, null, 14, new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(442), null, new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(442), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(444), "Malmö Möllevången", new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(444), "Malmö Möllevången", "Returned" },
                    { 138, new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(446), 3, null, true, 24, new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(445), true, 6, null, 14, new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(446), null, new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(445), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(447), "Malmö Möllevången", new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(447), "Malmö Möllevången", "Returned" },
                    { 139, new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(449), 4, null, true, 25, new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(448), true, 6, null, 14, new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(449), null, new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(449), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(450), "Malmö Möllevången", new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(450), "Malmö Möllevången", "Returned" },
                    { 140, new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(453), 5, null, true, 26, new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(451), true, 6, null, 14, new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(452), null, new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(453), "Malmö Möllevången", new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(454), "Malmö Möllevången", "Returned" },
                    { 141, new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(481), 1, null, true, 27, new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(480), true, 6, null, 14, new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(481), null, new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(480), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(482), "Malmö Möllevången", new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(482), "Malmö Möllevången", "Returned" },
                    { 142, new DateTime(2024, 11, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(486), 6, null, true, 1, new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(484), true, 1, null, 14, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(486), null, new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(485), new DateTime(2024, 11, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(487), "Malmö Värnhem", new DateTime(2024, 11, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(488), "Malmö Värnhem", "Returned" },
                    { 143, new DateTime(2024, 12, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(491), 6, null, true, 6, new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(490), true, 2, null, 14, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(491), null, new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(490), new DateTime(2024, 12, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(492), "Malmö Värnhem", new DateTime(2024, 12, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(492), "Malmö Värnhem", "Returned" },
                    { 144, new DateTime(2025, 1, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(495), 6, null, true, 11, new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(494), true, 3, null, 14, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(495), null, new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(494), new DateTime(2025, 1, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(496), "Malmö Värnhem", new DateTime(2025, 1, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(496), "Malmö Värnhem", "Returned" },
                    { 145, new DateTime(2025, 2, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(499), 6, null, true, 17, new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(498), true, 4, null, 14, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(499), null, new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(498), new DateTime(2025, 2, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(500), "Malmö Värnhem", new DateTime(2025, 2, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(500), "Malmö Värnhem", "Returned" },
                    { 146, new DateTime(2025, 3, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(503), 6, null, true, 23, new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(501), true, 5, null, 14, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(502), null, new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(502), new DateTime(2025, 3, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(503), "Malmö Värnhem", new DateTime(2025, 3, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(504), "Malmö Värnhem", "Returned" },
                    { 147, new DateTime(2025, 4, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(506), 6, null, true, 2, new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(505), true, 1, null, 14, new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(505), null, new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(505), new DateTime(2025, 4, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(506), "Malmö Värnhem", new DateTime(2025, 4, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(507), "Malmö Värnhem", "Returned" },
                    { 148, new DateTime(2025, 5, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(509), 6, null, true, 7, new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(508), true, 2, null, 14, new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(509), null, new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(509), new DateTime(2025, 5, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(510), "Malmö Värnhem", new DateTime(2025, 5, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(510), "Malmö Värnhem", "Returned" },
                    { 149, new DateTime(2025, 6, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(513), 6, null, true, 11, new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(512), true, 3, null, 14, new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(512), null, new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(512), new DateTime(2025, 6, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(513), "Malmö Värnhem", new DateTime(2025, 6, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(514), "Malmö Värnhem", "Returned" },
                    { 150, new DateTime(2025, 7, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(516), 6, null, true, 17, new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(515), true, 4, null, 14, new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(516), null, new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(515), new DateTime(2025, 7, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(517), "Malmö Värnhem", new DateTime(2025, 7, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(517), "Malmö Värnhem", "Returned" },
                    { 151, new DateTime(2025, 8, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(520), 6, null, true, 23, new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(518), true, 5, null, 14, new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(519), null, new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(519), new DateTime(2025, 8, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(520), "Malmö Värnhem", new DateTime(2025, 8, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(520), "Malmö Värnhem", "Returned" },
                    { 152, new DateTime(2025, 9, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(523), 6, null, true, 3, new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(522), true, 1, null, 14, new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(522), null, new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(522), new DateTime(2025, 9, 8, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(524), "Malmö Värnhem", new DateTime(2025, 9, 21, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(524), "Malmö Värnhem", "Returned" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CommunicationGood", "ConditionAsDescribed", "DateSubmitted", "LoanId", "MeetupExperience", "Rating", "ReviewedUserId", "ReviewerId" },
                values: new object[,]
                {
                    { 1, "Great experience, reliable borrower.", true, true, new DateTime(2023, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9627), 1, true, 4, 1, 2 },
                    { 2, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2024, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9849), 2, true, 5, 1, 3 },
                    { 3, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2024, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9852), 3, true, 5, 1, 4 },
                    { 4, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2024, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9853), 4, true, 5, 1, 5 },
                    { 5, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2024, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9854), 5, true, 5, 1, 6 },
                    { 6, "Great experience, reliable borrower.", true, true, new DateTime(2024, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9858), 6, true, 4, 1, 2 },
                    { 7, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9859), 7, true, 5, 1, 3 },
                    { 8, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9860), 8, true, 5, 1, 4 },
                    { 9, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9861), 9, true, 5, 1, 5 },
                    { 10, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9909), 10, true, 5, 1, 6 },
                    { 11, "Great experience, reliable borrower.", true, true, new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9911), 11, true, 4, 1, 2 },
                    { 12, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9912), 12, true, 5, 1, 3 },
                    { 13, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9913), 13, true, 5, 1, 4 },
                    { 14, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9914), 14, true, 5, 1, 5 },
                    { 15, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9915), 15, true, 5, 1, 6 },
                    { 16, "Great experience, reliable borrower.", true, true, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9916), 16, true, 4, 1, 2 },
                    { 17, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9917), 17, true, 5, 1, 3 },
                    { 18, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9919), 18, true, 5, 1, 4 },
                    { 19, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9920), 19, true, 5, 1, 5 },
                    { 20, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9921), 20, true, 5, 1, 6 },
                    { 21, "Great experience, reliable borrower.", true, true, new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9922), 21, true, 4, 1, 2 },
                    { 22, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9924), 22, true, 5, 1, 3 },
                    { 23, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2025, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9925), 23, true, 5, 1, 4 },
                    { 24, "Excellent lender! Comic in perfect condition.", true, true, new DateTime(2025, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9926), 24, true, 5, 1, 5 },
                    { 25, "Perfect transaction! Highly recommended.", true, true, new DateTime(2024, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9928), 25, true, 5, 2, 1 },
                    { 26, "Perfect transaction! Highly recommended.", true, true, new DateTime(2024, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9930), 26, true, 5, 2, 6 },
                    { 27, "Perfect transaction! Highly recommended.", true, true, new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9931), 27, true, 5, 2, 3 },
                    { 28, "Perfect transaction! Highly recommended.", true, true, new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9932), 28, true, 5, 2, 4 },
                    { 29, "Perfect transaction! Highly recommended.", true, true, new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9933), 29, true, 5, 2, 5 },
                    { 30, "Perfect transaction! Highly recommended.", true, true, new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9934), 30, true, 5, 2, 1 },
                    { 31, "Perfect transaction! Highly recommended.", true, true, new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9935), 31, true, 5, 2, 6 },
                    { 32, "Perfect transaction! Highly recommended.", true, true, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9936), 32, true, 5, 2, 3 },
                    { 33, "Perfect transaction! Highly recommended.", true, true, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9937), 33, true, 5, 2, 4 },
                    { 34, "Perfect transaction! Highly recommended.", true, true, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9939), 34, true, 5, 2, 4 },
                    { 35, "Perfect transaction! Highly recommended.", true, true, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9940), 35, true, 5, 2, 5 },
                    { 36, "Perfect transaction! Highly recommended.", true, true, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9941), 36, true, 5, 2, 6 },
                    { 37, "Perfect transaction! Highly recommended.", true, true, new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9942), 37, true, 5, 2, 3 },
                    { 38, "Perfect transaction! Highly recommended.", true, true, new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9943), 38, true, 5, 2, 4 },
                    { 39, "Perfect transaction! Highly recommended.", true, true, new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9944), 39, true, 5, 2, 5 },
                    { 40, "Perfect transaction! Highly recommended.", true, true, new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9945), 40, true, 5, 2, 6 },
                    { 41, "Perfect transaction! Highly recommended.", true, true, new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9946), 41, true, 5, 2, 3 },
                    { 42, "Perfect transaction! Highly recommended.", true, true, new DateTime(2025, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9947), 42, true, 5, 2, 4 },
                    { 43, "Great lender, minor delay but good communication.", false, true, new DateTime(2024, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9949), 43, true, 4, 3, 1 },
                    { 44, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9950), 44, true, 5, 3, 2 },
                    { 45, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9952), 45, true, 5, 3, 6 },
                    { 46, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9953), 46, true, 5, 3, 4 },
                    { 47, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9954), 47, true, 5, 3, 5 },
                    { 48, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9955), 48, true, 5, 3, 1 },
                    { 49, "Great lender, minor delay but good communication.", false, true, new DateTime(2024, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9957), 49, true, 4, 3, 2 },
                    { 50, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9958), 50, true, 5, 3, 6 },
                    { 51, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9959), 51, true, 5, 3, 4 },
                    { 52, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9960), 52, true, 5, 3, 5 },
                    { 53, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9962), 53, true, 5, 3, 1 },
                    { 54, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9963), 54, true, 5, 3, 2 },
                    { 55, "Great lender, minor delay but good communication.", false, true, new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9964), 55, true, 4, 3, 6 },
                    { 56, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9965), 56, true, 5, 3, 4 },
                    { 57, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9966), 57, true, 5, 3, 5 },
                    { 58, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 9, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9967), 58, true, 5, 3, 1 },
                    { 59, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9968), 59, true, 5, 3, 2 },
                    { 60, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 10, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9969), 60, true, 5, 3, 6 },
                    { 61, "Great lender, minor delay but good communication.", false, true, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9971), 61, true, 4, 3, 4 },
                    { 62, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 11, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9972), 62, true, 5, 3, 5 },
                    { 63, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9973), 63, true, 5, 3, 1 },
                    { 64, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2024, 12, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9974), 64, true, 5, 3, 2 },
                    { 65, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9976), 65, true, 5, 3, 6 },
                    { 66, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 1, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9978), 66, true, 5, 3, 4 },
                    { 67, "Great lender, minor delay but good communication.", false, true, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9979), 67, true, 4, 3, 5 },
                    { 68, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 2, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9980), 68, true, 5, 3, 1 },
                    { 69, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9981), 69, true, 5, 3, 2 },
                    { 70, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 3, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9982), 70, true, 5, 3, 6 },
                    { 71, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9984), 71, true, 5, 3, 4 },
                    { 72, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 4, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9985), 72, true, 5, 3, 5 },
                    { 73, "Great lender, minor delay but good communication.", false, true, new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9986), 73, true, 4, 3, 1 },
                    { 74, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 5, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9987), 74, true, 5, 3, 2 },
                    { 75, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9988), 75, true, 5, 3, 6 },
                    { 76, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 6, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9989), 76, true, 5, 3, 4 },
                    { 77, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9990), 77, true, 5, 3, 5 },
                    { 78, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 7, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9991), 78, true, 5, 3, 1 },
                    { 79, "Great lender, minor delay but good communication.", false, true, new DateTime(2025, 8, 22, 13, 48, 49, 26, DateTimeKind.Utc).AddTicks(9992), 79, true, 4, 3, 2 },
                    { 80, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(20), 80, true, 5, 3, 6 },
                    { 81, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 9, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(21), 81, true, 5, 3, 4 },
                    { 82, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 9, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(22), 82, true, 5, 3, 5 },
                    { 83, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 10, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(23), 83, true, 5, 3, 1 },
                    { 84, "Amazing collection! Very knowledgeable about X-Men.", true, true, new DateTime(2025, 10, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(24), 84, true, 5, 3, 2 },
                    { 85, "Good experience overall.", true, true, new DateTime(2024, 6, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(26), 85, true, 4, 4, 1 },
                    { 86, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2024, 6, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(28), 86, true, 5, 4, 2 },
                    { 87, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2024, 7, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(29), 87, true, 5, 4, 3 },
                    { 88, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2024, 7, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(30), 88, true, 5, 4, 6 },
                    { 89, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2024, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(31), 89, true, 5, 4, 5 },
                    { 90, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2024, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(32), 90, true, 5, 4, 1 },
                    { 91, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2024, 9, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(33), 91, true, 5, 4, 2 },
                    { 92, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2024, 9, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(34), 92, true, 5, 4, 3 },
                    { 93, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2024, 10, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(35), 93, true, 5, 4, 6 },
                    { 94, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2024, 10, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(36), 94, true, 5, 4, 5 },
                    { 95, "Good experience overall.", true, true, new DateTime(2024, 11, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(38), 95, true, 4, 4, 1 },
                    { 96, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2024, 11, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(39), 96, true, 5, 4, 2 },
                    { 97, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2024, 12, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(40), 97, true, 5, 4, 3 },
                    { 98, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2024, 12, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(41), 98, true, 5, 4, 6 },
                    { 99, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2025, 1, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(42), 99, true, 5, 4, 5 },
                    { 100, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2025, 1, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(43), 100, true, 5, 4, 1 },
                    { 101, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2025, 2, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(44), 101, true, 5, 4, 2 },
                    { 102, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2025, 2, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(45), 102, true, 5, 4, 3 },
                    { 103, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2025, 3, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(46), 103, true, 5, 4, 6 },
                    { 104, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2025, 3, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(48), 104, true, 5, 4, 5 },
                    { 105, "Good experience overall.", true, true, new DateTime(2025, 4, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(49), 105, true, 4, 4, 1 },
                    { 106, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2025, 4, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(50), 106, true, 5, 4, 2 },
                    { 107, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2025, 5, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(51), 107, true, 5, 4, 3 },
                    { 108, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2025, 5, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(52), 108, true, 5, 4, 6 },
                    { 109, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2025, 6, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(53), 109, true, 5, 4, 5 },
                    { 110, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2025, 6, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(55), 110, true, 5, 4, 1 },
                    { 111, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2025, 7, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(56), 111, true, 5, 4, 2 },
                    { 112, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2025, 7, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(57), 112, true, 5, 4, 3 },
                    { 113, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2025, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(58), 113, true, 5, 4, 6 },
                    { 114, "Fantastic DC collection! Highly recommend.", true, true, new DateTime(2025, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(59), 114, true, 5, 4, 5 },
                    { 115, "Good experience overall.", true, true, new DateTime(2025, 9, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(60), 115, true, 4, 4, 1 },
                    { 116, "Good lender, comics as described.", true, true, new DateTime(2024, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(62), 116, false, 4, 5, 1 },
                    { 117, "Great indie collection! Love the variety.", true, true, new DateTime(2024, 9, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(64), 117, true, 5, 5, 2 },
                    { 118, "Great indie collection! Love the variety.", true, true, new DateTime(2024, 10, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(65), 118, true, 5, 5, 3 },
                    { 119, "Good lender, comics as described.", true, true, new DateTime(2024, 11, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(66), 119, false, 4, 5, 4 },
                    { 120, "Great indie collection! Love the variety.", true, true, new DateTime(2024, 12, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(67), 120, true, 5, 5, 1 },
                    { 121, "Great indie collection! Love the variety.", true, true, new DateTime(2025, 1, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(69), 121, true, 5, 5, 2 },
                    { 122, "Good lender, comics as described.", true, true, new DateTime(2025, 2, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(70), 122, false, 4, 5, 3 },
                    { 123, "Great indie collection! Love the variety.", true, true, new DateTime(2025, 3, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(71), 123, true, 5, 5, 4 },
                    { 124, "Great indie collection! Love the variety.", true, true, new DateTime(2025, 4, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(72), 124, true, 5, 5, 1 },
                    { 125, "Good lender, comics as described.", true, true, new DateTime(2025, 5, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(73), 125, false, 4, 5, 2 },
                    { 126, "Great indie collection! Love the variety.", true, true, new DateTime(2025, 6, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(75), 126, true, 5, 5, 3 },
                    { 127, "Great indie collection! Love the variety.", true, true, new DateTime(2025, 7, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(76), 127, true, 5, 5, 4 },
                    { 128, "Good lender, comics as described.", true, true, new DateTime(2025, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(77), 128, false, 4, 5, 1 },
                    { 129, "Great indie collection! Love the variety.", true, true, new DateTime(2025, 9, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(78), 129, true, 5, 5, 2 },
                    { 130, "Great indie collection! Love the variety.", true, true, new DateTime(2025, 10, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(80), 130, true, 5, 5, 3 },
                    { 131, "Great experience, would borrow again.", true, true, new DateTime(2024, 10, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(82), 131, true, 4, 6, 1 },
                    { 132, "Excellent horror collection! Very punctual.", true, true, new DateTime(2024, 10, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(84), 132, true, 5, 6, 2 },
                    { 133, "Excellent horror collection! Very punctual.", true, true, new DateTime(2024, 11, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(85), 133, true, 5, 6, 3 },
                    { 134, "Excellent horror collection! Very punctual.", true, true, new DateTime(2024, 11, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(86), 134, true, 5, 6, 4 },
                    { 135, "Excellent horror collection! Very punctual.", true, true, new DateTime(2024, 12, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(87), 135, true, 5, 6, 5 },
                    { 136, "Excellent horror collection! Very punctual.", true, true, new DateTime(2024, 12, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(88), 136, true, 5, 6, 1 },
                    { 137, "Great experience, would borrow again.", true, true, new DateTime(2025, 1, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(90), 137, true, 4, 6, 2 },
                    { 138, "Excellent horror collection! Very punctual.", true, true, new DateTime(2025, 1, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(91), 138, true, 5, 6, 3 },
                    { 139, "Excellent horror collection! Very punctual.", true, true, new DateTime(2025, 2, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(92), 139, true, 5, 6, 4 },
                    { 140, "Excellent horror collection! Very punctual.", true, true, new DateTime(2025, 2, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(93), 140, true, 5, 6, 5 },
                    { 141, "Excellent horror collection! Very punctual.", true, true, new DateTime(2025, 3, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(94), 141, true, 5, 6, 1 },
                    { 142, "Excellent horror collection! Very punctual.", true, true, new DateTime(2025, 3, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(95), 142, true, 5, 6, 2 },
                    { 143, "Great experience, would borrow again.", true, true, new DateTime(2025, 4, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(96), 143, true, 4, 6, 3 },
                    { 144, "Excellent horror collection! Very punctual.", true, true, new DateTime(2025, 4, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(98), 144, true, 5, 6, 4 },
                    { 145, "Excellent horror collection! Very punctual.", true, true, new DateTime(2025, 5, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(99), 145, true, 5, 6, 5 },
                    { 146, "Excellent horror collection! Very punctual.", true, true, new DateTime(2025, 5, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(99), 146, true, 5, 6, 1 },
                    { 147, "Excellent horror collection! Very punctual.", true, true, new DateTime(2025, 6, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(100), 147, true, 5, 6, 2 },
                    { 148, "Excellent horror collection! Very punctual.", true, true, new DateTime(2025, 6, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(102), 148, true, 5, 6, 3 },
                    { 149, "Great experience, would borrow again.", true, true, new DateTime(2025, 7, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(103), 149, true, 4, 6, 4 },
                    { 150, "Excellent horror collection! Very punctual.", true, true, new DateTime(2025, 7, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(123), 150, true, 5, 6, 5 },
                    { 151, "Excellent horror collection! Very punctual.", true, true, new DateTime(2025, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(124), 151, true, 5, 6, 1 },
                    { 152, "Excellent horror collection! Very punctual.", true, true, new DateTime(2025, 8, 22, 13, 48, 49, 27, DateTimeKind.Utc).AddTicks(125), 152, true, 5, 6, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 152);
        }
    }
}
