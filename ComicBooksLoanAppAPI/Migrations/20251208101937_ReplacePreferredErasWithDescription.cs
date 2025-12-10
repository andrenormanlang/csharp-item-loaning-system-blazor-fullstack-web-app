using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicBooksLoanAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class ReplacePreferredErasWithDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PreferredEras",
                table: "Users",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Biography", "Description" },
                values: new object[] { "Living in Malmö since 2018. Started reading comics in 1975. Took a break in the 90s and just getting back into it. Love sharing the classics I grew up with through this lending library. Happy to meet up anywhere in central Malmö!", "Bronze Age enthusiast with focus on Spider-Man and X-Men runs from the 1970s-1980s" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Biography", "Description" },
                values: new object[] { "Former bookstore owner living in Lund. Passionate about mature, literary comics. The Vertigo line changed everything for me. Living near the university. Can meet in Lund or Malmö.", "Collector of mature literary comics, especially the Vertigo imprint and horror titles" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Biography", "Description" },
                values: new object[] { "Living in Helsingborg. Have been collecting X-Men since Claremont took over. Own nearly every issue from Giant-Size #1 through the 90s. Happy to share the classics! Usually available for meetups in Helsingborg centrum.", "Complete X-Men collector from Giant-Size #1 through the 1990s, specializing in Claremont era" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Biography", "Description" },
                values: new object[] { "Been in Malmö for 10 years. Grew up on O'Neil/Adams Batman and the classic Teen Titans. Still think the 70s-80s were the golden era of DC storytelling. Live in Västra Hamnen, happy to meet anywhere in Malmö.", "Classic DC collector focusing on O'Neil/Adams Batman and socially conscious 70s-80s DC titles" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Biography", "Description" },
                values: new object[] { "Living in Lund. Was there when the indie revolution started. Own runs of many titles that launched careers. Love sharing these overlooked gems. Living near Lund C, easy to meet up!", "Independent and underground comics specialist with extensive runs of 1970s-80s indie titles" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Horror comics enthusiast with extensive collections of 1970s Marvel and DC horror titles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Users",
                newName: "PreferredEras");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Biography", "PreferredEras" },
                values: new object[] { "British expat living in Malmö since 2018. Started reading comics in 1975. Took a break in the 90s and just getting back into it. Love sharing the classics I grew up with through this lending library. Happy to meet up anywhere in central Malmö!", "Bronze Age, Copper Age" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Biography", "PreferredEras" },
                values: new object[] { "Canadian expat, former bookstore owner. Passionate about mature, literary comics. The Vertigo line changed everything for me. Living in Lund near the university. Can meet in Lund or Malmö.", "Copper Age, Modern Age" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Biography", "PreferredEras" },
                values: new object[] { "American expat in Helsingborg. Have been collecting X-Men since Claremont took over. Own nearly every issue from Giant-Size #1 through the 90s. Happy to share the classics! Usually available for meetups in Helsingborg centrum.", "Bronze Age, Copper Age" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Biography", "PreferredEras" },
                values: new object[] { "Spanish expat, been in Malmö for 10 years. Grew up on O'Neil/Adams Batman and the classic Teen Titans. Still think the 70s-80s were the golden era of DC storytelling. Live in Västra Hamnen, happy to meet anywhere in Malmö.", "Bronze Age" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Biography", "PreferredEras" },
                values: new object[] { "Swedish-American, grew up in the States but moved to Sweden for university and stayed. Was there when the indie revolution started. Own runs of many titles that launched careers. Love sharing these overlooked gems. Living near Lund C, easy to meet up!", "Bronze Age, Copper Age" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "PreferredEras",
                value: "Bronze Age, Copper Age");
        }
    }
}
