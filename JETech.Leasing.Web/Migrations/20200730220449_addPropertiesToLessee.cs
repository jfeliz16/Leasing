using Microsoft.EntityFrameworkCore.Migrations;

namespace JETech.Leasing.Web.Migrations
{
    public partial class addPropertiesToLessee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Lessees",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CellPhone",
                table: "Lessees",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Document",
                table: "Lessees",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Lessees",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FixedPhone",
                table: "Lessees",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Lessees",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Lessees");

            migrationBuilder.DropColumn(
                name: "CellPhone",
                table: "Lessees");

            migrationBuilder.DropColumn(
                name: "Document",
                table: "Lessees");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Lessees");

            migrationBuilder.DropColumn(
                name: "FixedPhone",
                table: "Lessees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Lessees");
        }
    }
}
