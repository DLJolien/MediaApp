using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class AddedBookmarkedFilmsIdToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookmarkedFilmsId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f8b210f8-822d-46f8-8ea7-5aa3028a0e66");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "3187585b-8682-4c6a-a5b1-6926d2d1adec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "910c8efa-67c8-4b02-8ca9-993401f8800e", "AIxASq1Q6tht0m04rKdN+5f5GsB2Z5HMUW3/khtm3pgtE7qA1hz1e5H+YBDPaDbL3w==", "1b5be57b-621d-4bc0-96e6-87a7f4944800" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d872634-47a9-4065-8193-089c9a65ce2c", "APqpqiOOkNh8UZ0kw/asiIDzjC8Y1W1c7zF7O+fRjy+0/Q0JyoK/7+bX3iAsoV+Vpw==", "05d89dbd-4c15-4af0-9ad6-9cb49c5b079c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookmarkedFilmsId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0483260b-90c5-4fe9-be68-dad6852f8597");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "85cbfd9b-718e-4364-a3b1-0d9e488b4b14");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f62c65d-ecae-4143-93e5-be30a530e72f", "ADlxivxo+r/xV/tIZ5IlsVDIHu1t2E790pY1c464lIpu37RCRyk+95+Vq+hfUhPYCg==", "7c9e55b6-e88c-4e7f-8c63-b3acdc0761a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11ae41fa-af6d-4dcb-8d11-239f96d6041a", "AMK/5F68agUngzBd6jIQD8zXooOv1QLnZiNwIG45zM6ODr39ntG3hg42gd6Ffas29A==", "c670c651-4855-41fc-959e-d0d55fc8d616" });
        }
    }
}
