using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class AddedIsApprovedToComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Comments",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Comments");

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
        }
    }
}
