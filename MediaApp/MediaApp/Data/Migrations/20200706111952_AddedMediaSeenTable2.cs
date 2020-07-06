using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class AddedMediaSeenTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MediaSeens",
                columns: table => new
                {
                    MediaId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaSeens", x => new { x.MediaId, x.UserId });
                    table.ForeignKey(
                        name: "FK_MediaSeens_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MediaSeens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_MediaSeens_UserId",
                table: "MediaSeens",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MediaSeens");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2db0aacf-7f3d-4ccf-bfba-1dbf3eee71cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "3cc50a1d-fec0-4172-a994-b1d622271a11");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c08c666-5894-408a-837c-e31d6c6e7dc4", "AC2lzbNUHCJubf1iZkMVFPPJ5PtmQKn20g5gFINtuZ6tHrYKwZ3cORH564xfV6hApw==", "cf5227e1-cf37-4850-97ca-3aff2377c0a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1cc3296-77c8-45b6-b8d1-92761a6d4f2a", "AIN7el2ZhxR9nILFdeWoLGTeQqZCUeoXOzVY1v6jXLSFQIZVQMHiacW22Ig9MrotSQ==", "442d9068-e509-47a0-a608-ee05330430fa" });
        }
    }
}
