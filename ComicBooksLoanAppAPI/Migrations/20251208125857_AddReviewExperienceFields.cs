using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicBooksLoanAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddReviewExperienceFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShippingPackagingRating",
                table: "Reviews",
                newName: "MeetupExperience");

            migrationBuilder.RenameColumn(
                name: "CommunicationRating",
                table: "Reviews",
                newName: "CommunicationGood");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MeetupExperience",
                table: "Reviews",
                newName: "ShippingPackagingRating");

            migrationBuilder.RenameColumn(
                name: "CommunicationGood",
                table: "Reviews",
                newName: "CommunicationRating");
        }
    }
}
