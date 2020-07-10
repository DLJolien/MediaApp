using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MediaApp.Domain;
using MediaApp.Domain.MediaTypes;
using MediaApp.Models.Index;
using MediaApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediaApp.Controllers
{
    public class BookmarkController : Controller
    {
        private readonly MediaDb _dbContext;

        public BookmarkController(MediaDb dbcontext)
        {
            _dbContext = dbcontext;
        }
        [Authorize]
        public async Task<IActionResult> Film()
        {          
                User user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));
            Playlist<Media> bookmarkPlaylist;
            if (user.BookmarkedFilmsId == 0)
            {
                bookmarkPlaylist = CreateBookmarkList("Bookmarked films").Result;
                user.BookmarkedFilmsId = bookmarkPlaylist.Id;

            }
            else
            {
                bookmarkPlaylist = await _dbContext.Playlists.FirstOrDefaultAsync(x => x.Id == user.BookmarkedFilmsId);
            }
                IEnumerable<Media> bookmarkedMedia = _dbContext.PlaylistMedias.Include(x => x.Media).Where(x => x.PlaylistId == bookmarkPlaylist.Id).Select(x => x.Media).OrderByDescending(film => film.ReleaseDate);

                List<BookmarkListViewModel> vmList = bookmarkedMedia.Select(x => new BookmarkListViewModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    ReleaseDate = x.ReleaseDate,
                    Bookmarked = _dbContext.PlaylistMedias.AnyAsync(y => y.MediaId == x.Id && y.PlaylistId == user.BookmarkedFilmsId).Result,
                    Seen = _dbContext.MediaSeens.AnyAsync(z => z.MediaId == x.Id && z.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier)).Result,
                    PhotoUrl = x.PhotoUrl,
                }).ToList();

                return View(vmList);
       
        }
        [Authorize]
        [HttpPost]
        public async Task SaveToBookmarks(int id)
        {
            User user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));
            Playlist<Media> bookmarkPlaylist;

            if (user.BookmarkedFilmsId == 0)
            {
                bookmarkPlaylist = CreateBookmarkList("Bookmarked films").Result;
                user.BookmarkedFilmsId = bookmarkPlaylist.Id;   
                
            }
            else
            {
                bookmarkPlaylist = _dbContext.Playlists.Where(x => x.Id == user.BookmarkedFilmsId).FirstOrDefault();
            }

            if (!await _dbContext.PlaylistMedias.AnyAsync(x => x.MediaId == id && x.PlaylistId == bookmarkPlaylist.Id))
            {
                _dbContext.PlaylistMedias.Add(new PlaylistMedia() { MediaId = id, PlaylistId = bookmarkPlaylist.Id });
                await _dbContext.SaveChangesAsync();
            }
        }
        [Authorize]
        [HttpPost]
        public async Task RemoveFromBookmarks(int id)
        {
            User user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));

            Playlist<Media> bookmarkPlaylist = _dbContext.Playlists.Where(x => x.Id == user.BookmarkedFilmsId).FirstOrDefault();

            PlaylistMedia playlistMedia = await _dbContext.PlaylistMedias.Where(x => x.MediaId == id && x.PlaylistId == bookmarkPlaylist.Id).FirstOrDefaultAsync();

            _dbContext.PlaylistMedias.Remove(playlistMedia);
            await _dbContext.SaveChangesAsync();

        }

        private async Task<Playlist<Media>> CreateBookmarkList(string title)
        {
            Playlist<Media> newBookmarkedFilmsList = new Playlist<Media>()
            {
                Title = title,
                Public = false,
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier)
            };
            _dbContext.Playlists.Add(newBookmarkedFilmsList);
            await _dbContext.SaveChangesAsync();
            return newBookmarkedFilmsList;
        }
    }
}
