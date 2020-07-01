using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class AddDurationToPlaylist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "Playlists",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "8644b49b-33f5-406c-963b-916f6d8b223b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "08321c56-fd45-4afa-885e-25a62697ddeb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35a67bc2-bf46-4917-9c4f-941aea0e0df7", "AFMSqCPL4JV0dj27m5k7A/kOXFIux3eMLeOtD3v049vqSSz88IJ89Gq2GIHLXH2zOQ==", "c60c6122-f809-4f84-a441-9f1a2913583f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb8edb2f-93bd-43d4-ace1-e4625604c2d0", "AH+cn29NhmxFv4yfH12SfLqAXwt3NLAt89zDoOBT2GcdURxrUfkcnztcnqmo+m1u9Q==", "8597b179-cac0-43e2-bafc-f39aa9d7bf4d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Playlists");

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
    }
}
