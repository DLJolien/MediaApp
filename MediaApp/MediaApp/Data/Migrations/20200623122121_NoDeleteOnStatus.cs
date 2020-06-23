using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class NoDeleteOnStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_Statuses_StatusId",
                table: "Media");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Statuses_StatusId",
                table: "Media",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_Statuses_StatusId",
                table: "Media");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Statuses_StatusId",
                table: "Media",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
