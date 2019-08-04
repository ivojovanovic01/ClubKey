using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubKey.Data.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Cities_CityId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Owners_OwnerId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Clubs_ClubId",
                table: "Events");

            migrationBuilder.AlterColumn<int>(
                name: "ClubId",
                table: "Events",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Clubs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Clubs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "Description", "Name", "RequiredPoints" },
                values: new object[,]
                {
                    { 1, "5 tickets purchased", "bronze medal", 5 },
                    { 2, "10 tickets purchased", "silver medal", 10 },
                    { 3, "15 tickets purchased", "gold medal", 15 }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Split" });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "CityId", "Location", "Name", "OwnerId" },
                values: new object[,]
                {
                    { 1, null, "123123123", "Vanilla", 3 },
                    { 2, null, "123123123", "Zenta", 1 },
                    { 3, null, "123123123", "Moon", 2 }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "ClubId", "FinishTime", "Name", "StartTime" },
                values: new object[,]
                {
                    { 8, 3, new DateTime(2019, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), "Rock party", new DateTime(2019, 2, 1, 23, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2019, 8, 24, 5, 0, 0, 0, DateTimeKind.Unspecified), "Pop party", new DateTime(2019, 8, 23, 23, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, new DateTime(2019, 8, 24, 3, 0, 0, 0, DateTimeKind.Unspecified), "Techno party", new DateTime(2019, 8, 23, 23, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(2019, 8, 21, 3, 0, 0, 0, DateTimeKind.Unspecified), "Black and white party", new DateTime(2019, 8, 20, 23, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2019, 8, 11, 5, 0, 0, 0, DateTimeKind.Unspecified), "Crazy party", new DateTime(2019, 8, 10, 23, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2019, 8, 11, 5, 0, 0, 0, DateTimeKind.Unspecified), "White party", new DateTime(2019, 8, 10, 23, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 2, new DateTime(2019, 8, 11, 3, 0, 0, 0, DateTimeKind.Unspecified), "Pjena party", new DateTime(2019, 8, 10, 23, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(2019, 8, 13, 3, 0, 0, 0, DateTimeKind.Unspecified), "Black party", new DateTime(2019, 8, 12, 23, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "CompanyOib", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "12123423323", "Zenta123", "zenta01" },
                    { 2, "23452211236", "Moon1", "moon123" },
                    { 3, "17845342454", "Vanila12345", "vanilla191" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "Image", "LastName", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "ivanivanic12@gmail.com", "Ivan", "https://i0.wp.com/www.winhelponline.com/blog/wp-content/uploads/2017/12/user.png?fit=256%2C256&quality=100&ssl=1", "Ivanic", "Ivanic12", "iivanic12" },
                    { 2, "matematic1@gmail.com", "Mate", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/User_icon_2.svg/220px-User_icon_2.svg.png", "Matic", "MMatic01", "mmatic01" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "EventId", "Price", "UserId" },
                values: new object[,]
                {
                    { new Guid("a45bae5b-dae1-4051-99d9-e18d25af4349"), 1, 100.0, 1 },
                    { new Guid("eaae0a8d-6e00-494c-a9fc-72a316c93780"), 4, 100.0, 1 },
                    { new Guid("fec6f388-6863-4ded-a03f-89c1d31e5f3d"), 1, 100.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "UserAchievements",
                columns: new[] { "UserId", "AchievementId", "UserPoints" },
                values: new object[,]
                {
                    { 1, 1, 0 },
                    { 1, 2, 0 },
                    { 1, 3, 0 },
                    { 2, 1, 0 },
                    { 2, 2, 0 },
                    { 2, 3, 0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Cities_CityId",
                table: "Clubs",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Owners_OwnerId",
                table: "Clubs",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Clubs_ClubId",
                table: "Events",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Cities_CityId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Owners_OwnerId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Clubs_ClubId",
                table: "Events");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("a45bae5b-dae1-4051-99d9-e18d25af4349"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("eaae0a8d-6e00-494c-a9fc-72a316c93780"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("fec6f388-6863-4ded-a03f-89c1d31e5f3d"));

            migrationBuilder.DeleteData(
                table: "UserAchievements",
                keyColumns: new[] { "UserId", "AchievementId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "UserAchievements",
                keyColumns: new[] { "UserId", "AchievementId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "UserAchievements",
                keyColumns: new[] { "UserId", "AchievementId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "UserAchievements",
                keyColumns: new[] { "UserId", "AchievementId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "UserAchievements",
                keyColumns: new[] { "UserId", "AchievementId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "UserAchievements",
                keyColumns: new[] { "UserId", "AchievementId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "ClubId",
                table: "Events",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Clubs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Clubs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Cities_CityId",
                table: "Clubs",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Owners_OwnerId",
                table: "Clubs",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Clubs_ClubId",
                table: "Events",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
