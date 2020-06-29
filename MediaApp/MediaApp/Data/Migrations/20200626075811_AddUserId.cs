using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class AddUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "542f1aa2-bb7e-41a8-86ca-dde678c5055c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "e9947e95-e7b8-4d09-b992-601f295930b9");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
