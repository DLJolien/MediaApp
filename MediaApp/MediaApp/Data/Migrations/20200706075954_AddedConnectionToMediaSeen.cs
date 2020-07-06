using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class AddedConnectionToMediaSeen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "MediaSeen",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "42543fa3-a0fd-4c79-bd7a-9804409adc81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c8704e5d-a298-4213-a09b-b39e8138681c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e995c1f9-51ac-45b6-a3fa-6cf2b08daff8", "AHLeoOPvvfYXK8sDvm+363wLpxovf2Ob6qvVkqpl/MIbeWTCPMzv4w4DPX6roFqenA==", "47676c7c-4b32-46a3-8673-583f26316ddd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10e74ee0-127e-4ee9-a2ab-9e55ac4c0f3b", "AHkZndEnu+NC0yc/bVzR9E+Za6d7+GVMCIZNb8TOfPVsWBb2C3F/Z5x0JiBJGM7+yQ==", "729518b6-e51c-4209-a4da-bfaf03acf7f4" });

            migrationBuilder.CreateIndex(
                name: "IX_MediaSeen_UserId1",
                table: "MediaSeen",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MediaSeen_Media_MediaId",
                table: "MediaSeen",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaSeen_AspNetUsers_UserId1",
                table: "MediaSeen",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MediaSeen_Media_MediaId",
                table: "MediaSeen");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaSeen_AspNetUsers_UserId1",
                table: "MediaSeen");

            migrationBuilder.DropIndex(
                name: "IX_MediaSeen_UserId1",
                table: "MediaSeen");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "MediaSeen");

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
    }
}
