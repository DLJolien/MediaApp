using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class AddedDbSetMediaSeen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MediaSeen_Media_MediaId",
                table: "MediaSeen");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaSeen_AspNetUsers_UserId1",
                table: "MediaSeen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MediaSeen",
                table: "MediaSeen");

            migrationBuilder.RenameTable(
                name: "MediaSeen",
                newName: "MediaSeens");

            migrationBuilder.RenameIndex(
                name: "IX_MediaSeen_UserId1",
                table: "MediaSeens",
                newName: "IX_MediaSeens_UserId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MediaSeens",
                table: "MediaSeens",
                columns: new[] { "MediaId", "UserId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d710b6b6-f581-42f7-ab06-40c701ce3e3f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "80382229-81b7-47f9-ad66-726cce06064c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e53436c5-bf6c-4f11-90a8-6297bf816f43", "AClbM4+GzarLnGm0dz6dHs4kERxOe4fprkl4K2XHGEjE3clIdpp4dLbd1VzL+UzgDA==", "ce054caf-0c66-4a25-b432-fd9273f9eaf0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9383402a-9ede-4bac-9181-48536b29fcb8", "AErdEolWhsKUkuoEba1OA/ZdtWR//cVV/QJydJjh44CwViqrFt6eqygRm7YorvjzJg==", "031ebc66-208c-4bb9-820b-9a4375323a8a" });

            migrationBuilder.AddForeignKey(
                name: "FK_MediaSeens_Media_MediaId",
                table: "MediaSeens",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaSeens_AspNetUsers_UserId1",
                table: "MediaSeens",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MediaSeens_Media_MediaId",
                table: "MediaSeens");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaSeens_AspNetUsers_UserId1",
                table: "MediaSeens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MediaSeens",
                table: "MediaSeens");

            migrationBuilder.RenameTable(
                name: "MediaSeens",
                newName: "MediaSeen");

            migrationBuilder.RenameIndex(
                name: "IX_MediaSeens_UserId1",
                table: "MediaSeen",
                newName: "IX_MediaSeen_UserId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MediaSeen",
                table: "MediaSeen",
                columns: new[] { "MediaId", "UserId" });

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
    }
}
