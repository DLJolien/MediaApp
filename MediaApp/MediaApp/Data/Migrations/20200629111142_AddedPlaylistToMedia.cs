using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class AddedPlaylistToMedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MediaComments");

            migrationBuilder.DropTable(
                name: "Mediareviews");

            migrationBuilder.AddColumn<int>(
                name: "MediaId",
                table: "Reviews",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewId",
                table: "Reviews",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MediaId",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Public = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Playlists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlaylistMedias",
                columns: table => new
                {
                    PlaylistId = table.Column<int>(nullable: false),
                    MediaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistMedias", x => new { x.MediaId, x.PlaylistId });
                    table.ForeignKey(
                        name: "FK_PlaylistMedias_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistMedias_Playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "aeb46a3a-3088-42d2-8f4e-7df2c25ea0ce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "79d5fe65-f480-4d9b-a627-347586f3aa61");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "775358a3-8382-4417-8373-624a33fd9d43", "ADECysz1Vm+eB4Gp3uQvnrAbzO1Y9xbQ33ic8FBQzkmNr5/CFG4BFz+t6pOcHSjbwg==", "996d8d22-d229-407d-b263-ffbc4d20161b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc09a938-f0a8-47d8-bfdf-85c70ac5c632", "ABfOKEAzoWCyLloPfhAb0sAzx0eS1Er6vjjc+cCRISKVI6ArJd2fnslV9NdZCT3sPw==", "57287e80-6a29-4e7d-b1a0-b84e17219a9d" });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MediaId",
                table: "Reviews",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewId",
                table: "Reviews",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MediaId",
                table: "Comments",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistMedias_PlaylistId",
                table: "PlaylistMedias",
                column: "PlaylistId");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_UserId",
                table: "Playlists",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Media_MediaId",
                table: "Comments",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Media_MediaId",
                table: "Reviews",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Reviews_ReviewId",
                table: "Reviews",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Media_MediaId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Media_MediaId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Reviews_ReviewId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "PlaylistMedias");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_MediaId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ReviewId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Comments_MediaId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "MediaId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "MediaId",
                table: "Comments");

            migrationBuilder.CreateTable(
                name: "MediaComments",
                columns: table => new
                {
                    MediaId = table.Column<int>(type: "int", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaComments", x => new { x.MediaId, x.CommentId });
                    table.ForeignKey(
                        name: "FK_MediaComments_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MediaComments_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mediareviews",
                columns: table => new
                {
                    MediaId = table.Column<int>(type: "int", nullable: false),
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mediareviews", x => new { x.MediaId, x.ReviewId });
                    table.ForeignKey(
                        name: "FK_Mediareviews_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mediareviews_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5e4ef307-2b6f-4a60-aeb6-f5cd946006c9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b71aa89f-b000-492d-b8eb-99ae0af8b805");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e6e117c-c01a-4a3b-a255-0343bcb44dd2", "APIZf25aHvsCqIy14qhyOZtq3wpt0DYBifJtggQwx1wJ7n7TZfvN6kr53FeRevMWPQ==", "25af66b1-0866-4b4b-925c-8060911b9533" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5995405-1978-4660-9756-432979779c23", "AK7NDRuIHFOLNUuaL7S2W3ImbPJXzMFoxhXuXNavZQZ1AE4JupaM+3zJNC3ytwg2yQ==", "3ca7faf8-2126-4457-80a8-152a6b4dc0bf" });

            migrationBuilder.CreateIndex(
                name: "IX_MediaComments_CommentId",
                table: "MediaComments",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Mediareviews_ReviewId",
                table: "Mediareviews",
                column: "ReviewId");
        }
    }
}
