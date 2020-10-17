using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalTestWebApi.Migrations
{
    public partial class MoreDataAddedToAddressModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine3",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryIsoCode",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postcode",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Addresses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "AddressLine3",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CountryIsoCode",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Postcode",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Addresses");
        }
    }
}
