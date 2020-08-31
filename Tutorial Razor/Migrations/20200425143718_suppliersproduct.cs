using Microsoft.EntityFrameworkCore.Migrations;

namespace Tutorial_Razor.Migrations
{
    public partial class suppliersproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Suppliers",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Suppliers");
        }
    }
}
