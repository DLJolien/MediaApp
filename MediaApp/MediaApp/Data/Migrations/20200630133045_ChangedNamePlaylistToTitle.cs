using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class ChangedNamePlaylistToTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Playlists");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Playlists",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "72c00f87-c633-4a96-a61a-cefa0e0c25dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "0c3d06d3-38b4-41e1-8b58-191a465baf87");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02746fe2-3f80-4f3c-9b14-66678994bc26", "ADnxV7gBrvqPI1O/GVLObBcSpUxb1pTBA6bd4fTMb6IZ0cwVKhOrS+pUWxC2gwlShA==", "31c666f1-2064-4ffe-bdf0-e379c3fd7fd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7a527ed-cfc9-4894-8c81-34d1c5d99c92", "AJdJY3spUy/rZqCe/ZCIOAArqlKwxc39zCJKgPIId6wFrPw/NxLtYbDiB519LDLvIw==", "338c2ae8-6476-43e6-a21f-3420171160f4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Playlists");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Playlists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "aeb46a3a-3088-42d2-8f4e-7df2c25ea0ce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "79d5fe65-f480-4d9b-a627-347586f3aa61");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "775358a3-8382-4417-8373-624a33fd9d43", "ADECysz1Vm+eB4Gp3uQvnrAbzO1Y9xbQ33ic8FBQzkmNr5/CFG4BFz+t6pOcHSjbwg==", "996d8d22-d229-407d-b263-ffbc4d20161b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc09a938-f0a8-47d8-bfdf-85c70ac5c632", "ABfOKEAzoWCyLloPfhAb0sAzx0eS1Er6vjjc+cCRISKVI6ArJd2fnslV9NdZCT3sPw==", "57287e80-6a29-4e7d-b1a0-b84e17219a9d" });
        }
    }
}
