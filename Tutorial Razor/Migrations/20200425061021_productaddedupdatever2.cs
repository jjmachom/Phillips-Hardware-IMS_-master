using Microsoft.EntityFrameworkCore.Migrations;

namespace Tutorial_Razor.Migrations
{
    public partial class productaddedupdatever2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Products",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
