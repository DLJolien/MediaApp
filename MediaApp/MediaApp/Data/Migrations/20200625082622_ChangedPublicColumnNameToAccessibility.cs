using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class ChangedPublicColumnNameToAccessibility : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Public",
                table: "Media");

            migrationBuilder.AddColumn<string>(
                name: "Accessibility",
                table: "Media",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accessibility",
                table: "Media");

            migrationBuilder.AddColumn<string>(
                name: "Public",
                table: "Media",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
