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
        public async Task<IActionResult> Film(string filter = "")
        {
            User user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));
            Playlist<Media> bookmarkPlaylist;
            if (user.BookmarkedFilmsId == 0)
            {
                bookmarkPlaylist = await CreateBookmarkList("Bookmarked films");
                user.BookmarkedFilmsId = bookmarkPlaylist.Id;

            }
            else
            {
                bookmarkPlaylist = await _dbContext.Playlists.FirstOrDefaultAsync(x => x.Id == user.BookmarkedFilmsId);
            }
            IEnumerable<Media> bookmarkedMedia = _dbContext.PlaylistMedias.Include(x => x.Media).Where(x => x.PlaylistId == bookmarkPlaylist.Id).Select(x => x.Media).OrderByDescending(film => film.ReleaseDate);

            if (!String.IsNullOrEmpty(filter))
            {
                bookmarkedMedia = bookmarkedMedia.Where(x => x.Title.ToLower().Contains(filter.ToLower()));
            }

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
        public async Task<IActionResult> Music(string filter="")
        {
            User user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));
            Playlist<Media> bookmarkPlaylist;
            if (user.BookmarkedMusicId == 0)
            {
                bookmarkPlaylist = await CreateBookmarkList("Bookmarked music");
                user.BookmarkedMusicId = bookmarkPlaylist.Id;

            }
            else
            {
                bookmarkPlaylist = await _dbContext.Playlists.FirstOrDefaultAsync(x => x.Id == user.BookmarkedMusicId);
            }
            IEnumerable<Media> bookmarkedMedia = _dbContext.PlaylistMedias.Include(x => x.Media).Where(x => x.PlaylistId == bookmarkPlaylist.Id).Select(x => x.Media).OrderByDescending(music => music.ReleaseDate);

            if (!String.IsNullOrEmpty(filter))
            {
                bookmarkedMedia = bookmarkedMedia.Where(x => x.Title.ToLower().Contains(filter.ToLower()));
            }

            List<BookmarkListViewModel> vmList = bookmarkedMedia.Select(x => new BookmarkListViewModel()
            {
                Id = x.Id,
                Title = x.Title,
                ReleaseDate = x.ReleaseDate,
                Bookmarked = _dbContext.PlaylistMedias.AnyAsync(y => y.MediaId == x.Id && (y.PlaylistId == user.BookmarkedFilmsId || y.PlaylistId == user.BookmarkedPodcastId || y.PlaylistId == user.BookmarkedSeriesId || y.PlaylistId == user.BookmarkedMusicId)).Result,
                Seen = _dbContext.MediaSeens.AnyAsync(z => z.MediaId == x.Id && z.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier)).Result,
                PhotoUrl = x.PhotoUrl,
            }).ToList();

            return View(vmList);

        }
        [Authorize]
        public async Task<IActionResult> Podcast(string filter="")
        {
            User user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));
            Playlist<Media> bookmarkPlaylist;
            if (user.BookmarkedPodcastId == 0)
            {
                bookmarkPlaylist = await CreateBookmarkList("Bookmarked podcast");
                user.BookmarkedPodcastId = bookmarkPlaylist.Id;

            }
            else
            {
                bookmarkPlaylist = await _dbContext.Playlists.FirstOrDefaultAsync(x => x.Id == user.BookmarkedPodcastId);
            }
            IEnumerable<Media> bookmarkedMedia = _dbContext.PlaylistMedias.Include(x => x.Media).Where(x => x.PlaylistId == bookmarkPlaylist.Id).Select(x => x.Media).OrderByDescending(podcast => podcast.ReleaseDate);

            if (!String.IsNullOrEmpty(filter))
            {
                bookmarkedMedia = bookmarkedMedia.Where(x => x.Title.ToLower().Contains(filter.ToLower()));
            }

            List<BookmarkListViewModel> vmList = bookmarkedMedia.Select(x => new BookmarkListViewModel()
            {
                Id = x.Id,
                Title = x.Title,
                ReleaseDate = x.ReleaseDate,
                Bookmarked = _dbContext.PlaylistMedias.AnyAsync(y => y.MediaId == x.Id && (y.PlaylistId == user.BookmarkedFilmsId || y.PlaylistId == user.BookmarkedPodcastId || y.PlaylistId == user.BookmarkedSeriesId || y.PlaylistId == user.BookmarkedPodcastId)).Result,
                Seen = _dbContext.MediaSeens.AnyAsync(z => z.MediaId == x.Id && z.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier)).Result,
                PhotoUrl = x.PhotoUrl,
            }).ToList();

            return View(vmList);

        }
        [Authorize]
        [HttpPost]
        public async Task SaveToBookmarks(int id)
        {

            Playlist<Media> bookmarkPlaylist = await GetBookmarkPlaylist(id);

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
            Playlist<Media> bookmarkPlaylist = await GetBookmarkPlaylist(id);

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
        private async Task<Playlist<Media>> GetBookmarkPlaylist(int id)
        {
            User user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));
            Playlist<Media> bookmarkPlaylist;
            Media mediaToAdd = await _dbContext.Media.FirstOrDefaultAsync(x => x.Id == id);

            if (mediaToAdd.GetType() == typeof(Film))
            {
                if (user.BookmarkedFilmsId == 0)
                {
                    bookmarkPlaylist = await CreateBookmarkList("Bookmarked films");
                    user.BookmarkedFilmsId = bookmarkPlaylist.Id;
                }
                else
                {
                    bookmarkPlaylist = _dbContext.Playlists.Where(x => x.Id == user.BookmarkedFilmsId).FirstOrDefault();
                }
            }
            else if (mediaToAdd.GetType() == typeof(Music))
            {
                if (user.BookmarkedMusicId == 0)
                {
                    bookmarkPlaylist = await CreateBookmarkList("Bookmarked music");
                    user.BookmarkedMusicId = bookmarkPlaylist.Id;
                }
                else
                {
                    bookmarkPlaylist = _dbContext.Playlists.Where(x => x.Id == user.BookmarkedMusicId).FirstOrDefault();
                }
            }
            else if (mediaToAdd.GetType() == typeof(Podcast))
            {
                if (user.BookmarkedPodcastId == 0)
                {
                    bookmarkPlaylist = await CreateBookmarkList("Bookmarked podcasts");
                    user.BookmarkedPodcastId = bookmarkPlaylist.Id;
                }
                else
                {
                    bookmarkPlaylist = _dbContext.Playlists.Where(x => x.Id == user.BookmarkedPodcastId).FirstOrDefault();
                }
            }
            else
            {
                if (user.BookmarkedSeriesId == 0)
                {
                    bookmarkPlaylist = await CreateBookmarkList("Bookmarked series");
                    user.BookmarkedSeriesId = bookmarkPlaylist.Id;
                }
                else
                {
                    bookmarkPlaylist = _dbContext.Playlists.Where(x => x.Id == user.BookmarkedSeriesId).FirstOrDefault();
                }
            }
            return bookmarkPlaylist;
        }
    }
}
