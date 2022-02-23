using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4Assignment.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingID);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieTitle = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Year = table.Column<ushort>(nullable: false),
                    Director = table.Column<string>(nullable: true),
                    Edited = table.Column<string>(nullable: true),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    RatingID = table.Column<string>(nullable: true),
                    RatingID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieTitle);
                    table.ForeignKey(
                        name: "FK_Responses_Ratings_RatingID1",
                        column: x => x.RatingID1,
                        principalTable: "Ratings",
                        principalColumn: "RatingID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieTitle", "Category", "Director", "Edited", "LentTo", "Notes", "RatingID", "RatingID1", "Year" },
                values: new object[] { "cars", "Animation", "Disney", "No", "no one", "cinematic masterpiece", "G", null, (ushort)2007 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieTitle", "Category", "Director", "Edited", "LentTo", "Notes", "RatingID", "RatingID1", "Year" },
                values: new object[] { "Up", "Animation", "Disney", "No", "no one", "amazing cinematic masterpiece", "G", null, (ushort)2009 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_RatingID1",
                table: "Responses",
                column: "RatingID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Ratings");
        }
    }
}
