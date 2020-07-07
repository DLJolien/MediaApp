using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class ChangedCommentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Media_MediaId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "MediaId",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Comments",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "bcbad81c-b203-40a1-a04a-1cdd77a5a4b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c81cb90a-2316-49ca-b2fb-cfd68c06b75c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "956eba54-2d1c-44ef-b89a-b00f9d2cd768", "AESWjC49EVuSWwvltLBb+HxbgHyUifoM+r0WmDu7H3UO+mHLIOjXnwjhDnI4bcFQuA==", "640cdcd1-5fd7-4f5e-921c-97b8b176406b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42ae7597-1a8e-4462-bed0-afaa77a039d7", "AKV/hNQ86+QO+wfY7p0rLRPp8qAMSGgzALqpoQO1uTEVzonFWMcUzv3bERHgFql0Kw==", "d259dd6d-6dc5-462d-8d92-ef3c96416c2e" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Media_MediaId",
                table: "Comments",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Media_MediaId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "MediaId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "387bb216-768b-450d-97a5-e9b2dccdda9e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a8da3d34-8e77-464a-be77-68d5ee63977f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53b314cd-91ff-4f37-aba3-4e6305a7f114", "AP+8Ll2uLLWr67Bd62cfEYkrUgiVP4ZKpeO/1daeN54O03igLMfDUjtPwhgklFJT/w==", "e661d002-ef45-4721-9875-c5d6d6a6da9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9560d4c2-275f-41d8-b4b3-1e0ed65706fe", "AFlet1MC04wYzS2u0ymWa/CEK7zRklnJS+pzTr91PcSEQy4PkHgpSh0anpwhR9Hvxw==", "df026fd5-2fe9-441e-b865-1a2ee1cc4443" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Media_MediaId",
                table: "Comments",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
