using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneDb.Migrations
{
    public partial class SubCatMigrationForCatId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SId",
                table: "SubCategories",
                newName: "CatId");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CatId", "IsActive", "Name", "Profile", "Qty", "Rate", "SubId" },
                values: new object[,]
                {
                    { 1, 1, true, "Oppo", null, 10, 50, 1 },
                    { 2, 1, true, "Vivo", null, 12, 55, 1 },
                    { 3, 2, true, "Samsung", null, 10, 105, 2 },
                    { 4, 2, true, "One Plus", null, 15, 200, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "CatId",
                table: "SubCategories",
                newName: "SId");
        }
    }
}
