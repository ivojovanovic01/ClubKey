using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubKey.Data.Migrations
{
    public partial class AddedClubLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Clubs");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Clubs",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Clubs",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Clubs");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Clubs",
                nullable: false,
                defaultValue: "");
        }
    }
}
