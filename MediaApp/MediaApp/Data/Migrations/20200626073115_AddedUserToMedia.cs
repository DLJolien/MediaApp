using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class AddedUserToMedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Media",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6efc0bb2-75dc-4d9e-9989-2b9530810979");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "539381a8-7d8c-4035-8f19-9b7f8d95f13e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b852530-aeb4-4e9e-bfd6-6bb3ec53864f", "ANslspb6GoHQmQu/fDAXXeTX+wWrwablbFZCQGYnLd52jZMe7Z3jIPHO4I1jR5LpSg==", "2e82df66-79d9-4135-91d9-a5a8b38a6aff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "935bdba5-9e2b-48d9-b222-4ff9927b7836", "AFp+6Wp+NUUT03fl0K48hW8DBFYtmj5N0A0VrIQkOyaOw8/LRsiK6H899gUnZkewVQ==", "9981846c-aad2-4146-afa1-823a3a6d859a" });

            migrationBuilder.CreateIndex(
                name: "IX_Media_UserId",
                table: "Media",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_AspNetUsers_UserId",
                table: "Media",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_AspNetUsers_UserId",
                table: "Media");

            migrationBuilder.DropIndex(
                name: "IX_Media_UserId",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Media");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a44c342a-9113-4276-9503-d593dc479fdb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "30172822-67ee-4ab0-aee6-5dfb0c9f0067");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34237bf2-a90a-41df-a138-aace89df434f", "AJu0xyPl2N+ctkPRvBmUJFMKvxLgkvHlOAmDJKTCzHM6zR+WKkxakSlIz8HcDKLCSQ==", "06a9d1c1-35ee-4a4f-b56c-ad7b4402b3e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92ba7e97-a969-4a39-be72-8c23b84f2c41", "AFExFCuGPphjdzq9j3PRUD7UX/czO017reCo/Tu5fRVJOCwJRpD2yVlXTDqiKzhgjg==", "6473aa71-ab41-457f-b715-3c57d5c32a66" });
        }
    }
}
