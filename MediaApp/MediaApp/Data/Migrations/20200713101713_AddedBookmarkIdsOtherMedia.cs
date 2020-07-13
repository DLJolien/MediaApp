using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class AddedBookmarkIdsOtherMedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookmarkedMusicId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookmarkedPodcastId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookmarkedSeriesId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookmarkedMusicId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BookmarkedPodcastId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BookmarkedSeriesId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "3951b629-508a-4037-9c4f-bb66cbd62d91");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6fcb0b08-78b8-48da-9133-fb67c574c9d2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0362725-14da-42a6-a7d0-5b69f781f592", "AFaod3lRQixdVR1DhB19o5L4nI61HcB4hHobxRoDlns2FU7kdlXIiqcR8U2B3Tx9pg==", "cb64f14d-1601-4a8c-8975-2e9c19a12aed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a250b576-45b7-44a4-85e5-1b505f2f419f", "AB2M88AfcFFEt/pE3Hm8JDVgF0uYUWAUaoPHtfCEDSQXAmfQ/AvJZowqMZJbBY2+2A==", "0f5129bf-3055-4df4-bcb7-7c1c09a7f5eb" });
        }
    }
}
