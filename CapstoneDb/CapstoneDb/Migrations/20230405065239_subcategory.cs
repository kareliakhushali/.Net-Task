using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneDb.Migrations
{
    public partial class subcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Name", "SId" },
                values: new object[] { 1, "Android", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
