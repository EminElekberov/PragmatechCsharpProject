using Microsoft.EntityFrameworkCore.Migrations;

namespace Porto_ecommerce_30_.Migrations
{
    public partial class addedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "ClothType", "Discount", "Image", "Price", "TrendWord" },
                values: new object[] { 1, "on Jackets", "get up 30%", "slide1.jpg", 199, "winter clothes" });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "ClothType", "Discount", "Image", "Price", "TrendWord" },
                values: new object[] { 2, "on Coat", "get up 30%", "slide2.jpg", 199, "Season clothes" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
