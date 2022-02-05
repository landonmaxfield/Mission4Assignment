using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4Assignment.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieTitle = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Year = table.Column<ushort>(nullable: false),
                    Director = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    Edited = table.Column<string>(nullable: true),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieTitle);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieTitle", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "cars", "Animation", "Disney", "No", "no one", "cinematic masterpiece", "G", (ushort)2007 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieTitle", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Up", "Animation", "Disney", "No", "no one", "amazing cinematic masterpiece", "G", (ushort)2009 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
