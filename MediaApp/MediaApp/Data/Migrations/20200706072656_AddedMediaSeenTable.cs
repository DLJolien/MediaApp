using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class AddedMediaSeenTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MediaSeen",
                columns: table => new
                {
                    MediaId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Seen = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaSeen", x => new { x.MediaId, x.UserId });
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4911895f-20ba-4ff4-9c91-51cbce4ff54d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "68ba9725-dd79-440d-97f7-eba17054b510");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d62429d5-a7cf-49af-a30b-b5c48f399619", "ALy+QzxSy/+EIa1qzbBkXbrUd9kJ180mdh+7CcVJNLo1pqFFwnj4e1Ysp5M5U6TpwA==", "ddda35d9-5ccd-4857-9058-f3145379609d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4a8034d-8919-42d6-ba87-24da264a5146", "AOdwX5mtb+rJDbsiba65vvyaPJz95OErFcMBBmjU0MHid/e3dFpr38dO8hYY6nb9sQ==", "6c8103fe-d89a-4624-9128-16fc1ca651c0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MediaSeen");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f8b210f8-822d-46f8-8ea7-5aa3028a0e66");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "3187585b-8682-4c6a-a5b1-6926d2d1adec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "910c8efa-67c8-4b02-8ca9-993401f8800e", "AIxASq1Q6tht0m04rKdN+5f5GsB2Z5HMUW3/khtm3pgtE7qA1hz1e5H+YBDPaDbL3w==", "1b5be57b-621d-4bc0-96e6-87a7f4944800" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d872634-47a9-4065-8193-089c9a65ce2c", "APqpqiOOkNh8UZ0kw/asiIDzjC8Y1W1c7zF7O+fRjy+0/Q0JyoK/7+bX3iAsoV+Vpw==", "05d89dbd-4c15-4af0-9ad6-9cb49c5b079c" });
        }
    }
}
