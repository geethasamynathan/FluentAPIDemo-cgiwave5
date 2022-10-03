using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluentAPIDemo.Migrations
{
    public partial class uniqueconstraintaddedtocategorytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "uq_categoryName",
                table: "Categories",
                column: "CategoryName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "uq_categoryName",
                table: "Categories");
        }
    }
}
