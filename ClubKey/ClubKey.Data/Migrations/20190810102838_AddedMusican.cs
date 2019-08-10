using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubKey.Data.Migrations
{
    public partial class AddedMusican : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Events",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Hashtag",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MusicianId",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Events",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Musician",
                columns: table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musician", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Musician",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "DJ Krmak" },
                    { 2, "DJ Mrki" },
                    { 3, "Mate Cajka" },
                    { 4, "Severina" }
                });

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 43.521948999999999, 16.432046 });

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 43.500075000000002, 16.455708000000001 });

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 43.508144000000001, 16.450879 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Hashtag", "MusicianId", "Price" },
                values: new object[] { "Najbolji party uz puno pjene", 5, 2, 20.00 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Hashtag", "MusicianId", "Price" },
                values: new object[] { "Najbolji party svi u bijelo", 5, 2, 30.00 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Hashtag", "MusicianId", "Price" },
                values: new object[] { "Party iznenađenja", 5, 1, 30.00 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Hashtag", "MusicianId", "Price" },
                values: new object[] { "Najbolji crni party ikad", 5, 1, 40.00 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Hashtag", "MusicianId", "Price" },
                values: new object[] { "Najbolji black and white party u gradu", 5, 4, 100.00 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Hashtag", "MusicianId" , "Price" },
                values: new object[] { "Za ljubitelje techna", 2, 1, 20.00 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Hashtag", "MusicianId", "Price" },
                values: new object[] { "Najbolji party za ljubitelje popa", 1, 4, 100.00 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Hashtag", "MusicianId", "Price" },
                values: new object[] { "Najluđi party", 1, 4, 50.00 });

            migrationBuilder.CreateIndex(
                name: "IX_Events_MusicianId",
                table: "Events",
                column: "MusicianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Musician_MusicianId",
                table: "Events",
                column: "MusicianId",
                principalTable: "Musician",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Musician_MusicianId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "Musician");

            migrationBuilder.DropIndex(
                name: "IX_Events_MusicianId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Hashtag",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "MusicianId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.0, 0.0 });
        }
    }
}
