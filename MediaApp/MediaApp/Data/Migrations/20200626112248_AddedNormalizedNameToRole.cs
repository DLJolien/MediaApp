using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class AddedNormalizedNameToRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "5e4ef307-2b6f-4a60-aeb6-f5cd946006c9", "Admin" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "b71aa89f-b000-492d-b8eb-99ae0af8b805", "User" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e6e117c-c01a-4a3b-a255-0343bcb44dd2", "APIZf25aHvsCqIy14qhyOZtq3wpt0DYBifJtggQwx1wJ7n7TZfvN6kr53FeRevMWPQ==", "25af66b1-0866-4b4b-925c-8060911b9533" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5995405-1978-4660-9756-432979779c23", "AK7NDRuIHFOLNUuaL7S2W3ImbPJXzMFoxhXuXNavZQZ1AE4JupaM+3zJNC3ytwg2yQ==", "3ca7faf8-2126-4457-80a8-152a6b4dc0bf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "542f1aa2-bb7e-41a8-86ca-dde678c5055c", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "e9947e95-e7b8-4d09-b992-601f295930b9", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54e59602-967c-4f5f-a457-a86bc45a45a2", "AHrHRXW3jZzXyTv5Yp6EMhUc15QZ2FjD5S73x5TSxsDAI+rMpc2Z4959Zz9hL1U4iA==", "d311abf1-245f-43cc-a7b2-52d789d80988" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f4f1cc3-61bc-43a0-bc83-24e086b2977d", "AFuB8NKuMwGTJOMRENz1puSrGJ4iDadUxkgzUdtD+FxF9dtIhn7pcaXudkC9Mh3Piw==", "ff74d1b7-1cd4-4e2a-9002-c713de9c6edd" });
        }
    }
}
