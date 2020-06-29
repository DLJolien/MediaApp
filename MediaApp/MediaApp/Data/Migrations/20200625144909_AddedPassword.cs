using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class AddedPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c0f72536-665d-42f5-aa11-767957ab8057");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b7e56fa1-0f7b-4376-b9a2-a37fceb3c9ac");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06863e38-3528-47f4-8b7f-9e4f48bf41a2", null, "714139ba-ec74-4271-ab57-b19e6407234f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0db1ad8e-93f3-4614-a490-86d03782b056", null, "fb2c9f35-62d6-4854-a608-46bb2171a623" });
        }
    }
}
