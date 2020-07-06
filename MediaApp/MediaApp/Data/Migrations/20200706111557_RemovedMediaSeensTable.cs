using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class RemovedMediaSeensTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MediaSeens");

            migrationBuilder.DropColumn(
                name: "Accessibility",
                table: "Media");

            migrationBuilder.AddColumn<bool>(
                name: "Public",
                table: "Media",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Public",
                table: "Media");

            migrationBuilder.AddColumn<string>(
                name: "Accessibility",
                table: "Media",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MediaSeens",
                columns: table => new
                {
                    MediaId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Seen = table.Column<bool>(type: "bit", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                        name: "FK_MediaSeens_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d710b6b6-f581-42f7-ab06-40c701ce3e3f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "80382229-81b7-47f9-ad66-726cce06064c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e53436c5-bf6c-4f11-90a8-6297bf816f43", "AClbM4+GzarLnGm0dz6dHs4kERxOe4fprkl4K2XHGEjE3clIdpp4dLbd1VzL+UzgDA==", "ce054caf-0c66-4a25-b432-fd9273f9eaf0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9383402a-9ede-4bac-9181-48536b29fcb8", "AErdEolWhsKUkuoEba1OA/ZdtWR//cVV/QJydJjh44CwViqrFt6eqygRm7YorvjzJg==", "031ebc66-208c-4bb9-820b-9a4375323a8a" });

            migrationBuilder.CreateIndex(
                name: "IX_MediaSeens_UserId1",
                table: "MediaSeens",
                column: "UserId1");
        }
    }
}
