using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class AddedMediaTypeToPlaylist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Playlists",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c40090ad-28f4-4fd7-bed7-1404657a4356");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "30290aa3-a106-4233-9157-dca1d9ee5cef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1aa1d97f-c248-4242-837e-dc45c7b1c9a6", "AC7Fehm/hb2EduQC2Q0oFrnLX9XtdV8kebhTzDhQxi7vNupPo98w7VohUlrHIpbsug==", "131fd598-8287-489c-8dce-b03d4e7a92d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6656b56a-e223-4a90-ada0-d5b96c561970", "ADIOIPSOxAghEMVz2U2cDEbLt9nTw3mSONKPKutfKAA7ngpfqZ4pPzYQBfWhEznwFA==", "dca72ef9-a70b-4a93-a3df-5e8061904abd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Playlists");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ae2da896-0ef8-458a-b643-e6c70dcc93a5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "db6ae30d-2823-4e0d-8a97-f2c73a825e3e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e57101a-0af1-4cc4-9370-a3585cfaaebf", "ACLdUBz4nYihI1cisFHWfSHmfae3de7VESIe9CiP6mPwQz4dDlPZR6A4ihEUsX/VSQ==", "ae4d9b9e-ed6a-4da6-9069-900773d66fe1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc3862f4-f0bf-4211-8c51-237bf0dd3294", "AGZNaKWcq+E1qy5tYbJK7uRVpTYw5yH+GlwXHlmXrF6rwf5PmOBiu6pv71mo0BtsTg==", "b4e17749-9514-4ca0-b35f-1c2beb6bdfb8" });
        }
    }
}
