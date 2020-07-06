using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class RemovedStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_Statuses_StatusId",
                table: "Media");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Media_StatusId",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Media");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "421b433a-28ef-44bf-8c1e-cacd944ed235");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a684d49f-6619-4552-abab-505d3f3a9fb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9bd6743-430e-4e50-b573-53fa2a969098", "AK+INAawBBZRZAo4TR5k+1WJHPeJLFNlwUIt7eSJ3O6LV6Ku/DOjXLh70qud3DXBaQ==", "c2d7b4d0-39de-4873-b2dc-a1876bb6af21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87d592d4-fc23-467b-b211-14f7f6119662", "AB6sOrYGaK0L82YtqckNW/UZ6w/e7gjDPco0C6VA1LCFjiz6z4gVqmpoF+OHudWgnw==", "a83abca0-471f-4cfe-a322-be5d0403e68e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Media",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Experienced" },
                    { 2, "Want to experience" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Media_StatusId",
                table: "Media",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Statuses_StatusId",
                table: "Media",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id");
        }
    }
}
