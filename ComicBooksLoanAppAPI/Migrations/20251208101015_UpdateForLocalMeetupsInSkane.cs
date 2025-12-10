using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicBooksLoanAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForLocalMeetupsInSkane : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LendingPreferences",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PreferredDeliveryMethod",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OutboundTrackingNumber",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "ReturnTrackingNumber",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "ShippingMethod",
                table: "Loans");

            migrationBuilder.AlterColumn<string>(
                name: "ReadingFocus",
                table: "Users",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "MeetupDateTime",
                table: "Loans",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MeetupLocation",
                table: "Loans",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnMeetupDateTime",
                table: "Loans",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReturnMeetupLocation",
                table: "Loans",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Biography", "City", "ReadingFocus", "ZipCode" },
                values: new object[] { "British expat living in Malmö since 2018. Started reading comics in 1975. Took a break in the 90s and just getting back into it. Love sharing the classics I grew up with through this lending library. Happy to meet up anywhere in central Malmö!", "Malmö", "Bronze Age Marvel, Classic Superhero Comics", "211 20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Biography", "City", "ReadingFocus", "ZipCode" },
                values: new object[] { "Canadian expat, former bookstore owner. Passionate about mature, literary comics. The Vertigo line changed everything for me. Living in Lund near the university. Can meet in Lund or Malmö.", "Lund", "Mature Comics, Vertigo Line, Horror", "222 20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Biography", "City", "ReadingFocus", "ZipCode" },
                values: new object[] { "American expat in Helsingborg. Have been collecting X-Men since Claremont took over. Own nearly every issue from Giant-Size #1 through the 90s. Happy to share the classics! Usually available for meetups in Helsingborg centrum.", "Helsingborg", "X-Men Complete Runs, Marvel Bronze Age", "252 20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Biography", "City", "ReadingFocus", "ZipCode" },
                values: new object[] { "Spanish expat, been in Malmö for 10 years. Grew up on O'Neil/Adams Batman and the classic Teen Titans. Still think the 70s-80s were the golden era of DC storytelling. Live in Västra Hamnen, happy to meet anywhere in Malmö.", "Malmö", "Classic DC, Bronze Age Batman, Social Commentary Comics", "214 44" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Biography", "City", "ReadingFocus", "ZipCode" },
                values: new object[] { "Swedish-American, grew up in the States but moved to Sweden for university and stayed. Was there when the indie revolution started. Own runs of many titles that launched careers. Love sharing these overlooked gems. Living near Lund C, easy to meet up!", "Lund", "Independent Comics, Underground Comics, Alternative", "223 63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Biography", "City", "ReadingFocus", "ZipCode" },
                values: new object[] { "Born and raised in Malmö. Been reading horror comics since the 70s revival. Have extensive runs of Tomb of Dracula, Swamp Thing, and more. Love introducing people to classic horror comics. Can meet in Möllevången or Värnhem areas.", "Malmö", "Horror Comics, Classic Monster Comics, Dark Fantasy", "215 73" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MeetupDateTime",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "MeetupLocation",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "ReturnMeetupDateTime",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "ReturnMeetupLocation",
                table: "Loans");

            migrationBuilder.AlterColumn<string>(
                name: "ReadingFocus",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<string>(
                name: "LendingPreferences",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreferredDeliveryMethod",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OutboundTrackingNumber",
                table: "Loans",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReturnTrackingNumber",
                table: "Loans",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingMethod",
                table: "Loans",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Biography", "ReadingFocus", "Location", "PhoneNumber", "PreferredDeliveryMethod", "LendingPreferences" },
                values: new object[] { "Started reading comics in 1975. Took a break in the 90s and just getting back into it. Love sharing the classics I grew up with through this lending library.", "Bronze Age Marvel & DC", "Cleveland, OH", "555-0101", "Mail with Insurance", "Handle with care! These books mean a lot to me. Prefer lending to established members." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Biography", "ReadingFocus", "Location", "PhoneNumber", "PreferredDeliveryMethod", "LendingPreferences" },
                values: new object[] { "Former bookstore owner. Passionate about mature, literary comics. The Vertigo line changed everything for me.", "Vertigo & Mature Readers", "Portland, OR", "555-0102", "Mail with Insurance", "Love introducing new readers to quality mature comics. Please respect the condition." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Biography", "ReadingFocus", "Location", "PhoneNumber", "PreferredDeliveryMethod", "LendingPreferences" },
                values: new object[] { "Have been collecting X-Men since Claremont took over. Own nearly every issue from Giant-Size #1 through the 90s. Happy to share the classics!", "Complete X-Men Runs", "Atlanta, GA", "555-0103", "Mail with Insurance", "Claremont era is my specialty. Will lend full story arcs when possible." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Biography", "ReadingFocus", "Location", "PhoneNumber", "PreferredDeliveryMethod", "LendingPreferences" },
                values: new object[] { "Grew up on O'Neil/Adams Batman and the classic Teen Titans. Still think the 70s-80s were the golden era of DC storytelling.", "Classic DC Bronze Age", "Phoenix, AZ", "555-0104", "Mail", "Big on sharing Wolfman/Perez Titans and Adams-era Batman. Careful shipping always." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Biography", "ReadingFocus", "Location", "PhoneNumber", "PreferredDeliveryMethod", "LendingPreferences" },
                values: new object[] { "Was there when the indie revolution started. Own runs of many titles that launched careers. Love sharing these overlooked gems.", "Early Independent Comics", "Austin, TX", "555-0105", "Mail with Insurance", "Focus on forgotten indies that deserve more attention. Happy to recommend starting points." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Biography", "ReadingFocus", "Location", "PhoneNumber", "PreferredDeliveryMethod", "LendingPreferences" },
                values: new object[] { "Been reading horror comics since the 70s revival. Have extensive runs of Tomb of Dracula, Swamp Thing, and more.", "Horror Comics & Epic Magazine", "Boston, MA", "555-0106", "Mail", "Horror fans unite! These are mature comics - please be aware of content." });
        }
    }
}
