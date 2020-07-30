using Microsoft.EntityFrameworkCore.Migrations;

namespace JETech.Leasing.Web.Migrations
{
    public partial class modifiedaddresscolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Owners");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Owners",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Owners");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Owners",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
