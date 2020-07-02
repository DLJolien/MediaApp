using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class AddedLastModifiedToPlaylist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Playlists");

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
    }
}
