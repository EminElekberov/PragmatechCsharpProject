using Microsoft.EntityFrameworkCore.Migrations;

namespace RepeatAsp.Migrations
{
    public partial class addedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 255, nullable: false),
                    Name = table.Column<string>(maxLength: 15, nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Slider",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrendWord = table.Column<string>(nullable: true),
                    DisCount = table.Column<string>(nullable: true),
                    ClothType = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slider", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Slider",
                columns: new[] { "ID", "ClothType", "DisCount", "Image", "Price", "TrendWord" },
                values: new object[] { 1, "On Jackets", "Get up to 60% off", "slide1.jpg", 130, "Winter Fashion Trends" });

            migrationBuilder.InsertData(
                table: "Slider",
                columns: new[] { "ID", "ClothType", "DisCount", "Image", "Price", "TrendWord" },
                values: new object[] { 2, "On Coat", "Get up to 10% off", "slide2.jpg", 200, "Season Fashion Trends" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Slider");
        }
    }
}
