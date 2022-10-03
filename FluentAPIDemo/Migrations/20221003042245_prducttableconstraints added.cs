using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluentAPIDemo.Migrations
{
    public partial class prducttableconstraintsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropUniqueConstraint(
                name: "uq_categoryName",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "Products",
                type: "char(4)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddUniqueConstraint(
                name: "uq_ProductName",
                table: "Products",
                column: "ProductName");

            migrationBuilder.AddUniqueConstraint(
                name: "uq_CategoryName",
                table: "Categories",
                column: "CategoryName");

            migrationBuilder.AddForeignKey(
                name: "fk_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_CategoryId",
                table: "Products");

            migrationBuilder.DropUniqueConstraint(
                name: "uq_ProductName",
                table: "Products");

            migrationBuilder.DropUniqueConstraint(
                name: "uq_CategoryName",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(4)");

            migrationBuilder.AddUniqueConstraint(
                name: "uq_categoryName",
                table: "Categories",
                column: "CategoryName");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
