using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicBooksLoanAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLoanRequestForMeetups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WithInsurance",
                table: "LoanRequests");

            migrationBuilder.RenameColumn(
                name: "ShippingMethod",
                table: "LoanRequests",
                newName: "PreferredMeetupMethod");

            migrationBuilder.AddColumn<string>(
                name: "SuggestedMeetupLocation",
                table: "LoanRequests",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SuggestedMeetupLocation",
                table: "LoanRequests");

            migrationBuilder.RenameColumn(
                name: "PreferredMeetupMethod",
                table: "LoanRequests",
                newName: "ShippingMethod");

            migrationBuilder.AddColumn<bool>(
                name: "WithInsurance",
                table: "LoanRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
