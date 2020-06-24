using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.Data.Migrations
{
    public partial class AddedContentUrlMusicAndPodCastGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_AudioGenres_Music_GenreId",
                table: "Media");

            migrationBuilder.DropForeignKey(
                name: "FK_Media_PodcastGenre_Podcast_GenreId",
                table: "Media");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PodcastGenre",
                table: "PodcastGenre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AudioGenres",
                table: "AudioGenres");

            migrationBuilder.RenameTable(
                name: "PodcastGenre",
                newName: "PodcastGenres");

            migrationBuilder.RenameTable(
                name: "AudioGenres",
                newName: "MusicGenres");

            migrationBuilder.AddColumn<string>(
                name: "ContentUrl",
                table: "Media",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PodcastGenres",
                table: "PodcastGenres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MusicGenres",
                table: "MusicGenres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_MusicGenres_Music_GenreId",
                table: "Media",
                column: "Music_GenreId",
                principalTable: "MusicGenres",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_PodcastGenres_Podcast_GenreId",
                table: "Media",
                column: "Podcast_GenreId",
                principalTable: "PodcastGenres",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_MusicGenres_Music_GenreId",
                table: "Media");

            migrationBuilder.DropForeignKey(
                name: "FK_Media_PodcastGenres_Podcast_GenreId",
                table: "Media");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PodcastGenres",
                table: "PodcastGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MusicGenres",
                table: "MusicGenres");

            migrationBuilder.DropColumn(
                name: "ContentUrl",
                table: "Media");

            migrationBuilder.RenameTable(
                name: "PodcastGenres",
                newName: "PodcastGenre");

            migrationBuilder.RenameTable(
                name: "MusicGenres",
                newName: "AudioGenres");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PodcastGenre",
                table: "PodcastGenre",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AudioGenres",
                table: "AudioGenres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_AudioGenres_Music_GenreId",
                table: "Media",
                column: "Music_GenreId",
                principalTable: "AudioGenres",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_PodcastGenre_Podcast_GenreId",
                table: "Media",
                column: "Podcast_GenreId",
                principalTable: "PodcastGenre",
                principalColumn: "Id");
        }
    }
}
