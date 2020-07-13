using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using MediaApp.Domain;
using MediaApp.Domain.MediaTypes;
using MediaApp.Models.Create;
using MediaApp.Models.Delete;
using MediaApp.Models.Detail;
using MediaApp.Models.Edit;
using MediaApp.Models.Index;
using MediaApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediaApp.Controllers
{
    public class PlaylistController : Controller
    {
        private readonly MediaDb _dbContext;
        private readonly IPhotoService _photoService;
        private readonly SignInManager<User> _signInManager;

        public PlaylistController(MediaDb dbcontext, IPhotoService photoService, SignInManager<User> signInManager)
        {
            _dbContext = dbcontext;
            _photoService = photoService;
            _signInManager = signInManager;
        }
        [Authorize]
        public async Task<IActionResult> Film(string filter = "")
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int filmBookmarkId = (await _dbContext.Users.FirstOrDefaultAsync(user => user.Id == User.FindFirstValue(ClaimTypes.NameIdentifier))).BookmarkedFilmsId;
            List<PlaylistListViewModel> vmList = await GetPlaylistListViewModels(filmBookmarkId, filter, "Film");
            return View(vmList);      
        }
        public async Task<IActionResult> Music(string filter = "")
        {
            int musicBookmarkId = (await _dbContext.Users.FirstOrDefaultAsync(user => user.Id == User.FindFirstValue(ClaimTypes.NameIdentifier))).BookmarkedMusicId;
            List<PlaylistListViewModel> vmList = await GetPlaylistListViewModels(musicBookmarkId, filter, "Music");
            return View(vmList);
        }
        public async Task<IActionResult> Podcast(string filter = "")
        {
            int podcastBookmarkId = (await _dbContext.Users.FirstOrDefaultAsync(user => user.Id == User.FindFirstValue(ClaimTypes.NameIdentifier))).BookmarkedPodcastId;
            List<PlaylistListViewModel> vmList = await GetPlaylistListViewModels(podcastBookmarkId, filter, "Podcast");
            return View(vmList);
        }
        public async Task<IActionResult> Series(string filter = "")
        {
            int seriesBookmarkId = (await _dbContext.Users.FirstOrDefaultAsync(user => user.Id == User.FindFirstValue(ClaimTypes.NameIdentifier))).BookmarkedSeriesId;
            List<PlaylistListViewModel> vmList = await GetPlaylistListViewModels(seriesBookmarkId, filter, "Series");
            return View(vmList);
        }

        private async Task<List<PlaylistListViewModel>> GetPlaylistListViewModels(int id, string filter, string type)
        {
            IEnumerable<Playlist<Media>> playlists;
           
            if (User.IsInRole("Admin"))
            {
                playlists = await _dbContext.Playlists
                    .Include(x => x.User)
                    .Include(x => x.PlaylistMedias)
                    .ThenInclude(x => x.Media)
                    .Where(playlist => playlist.Type == type && playlist.Id != id)
                    .ToListAsync();

            }
            else
            {
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                playlists = await _dbContext.Playlists
                    .Include(x => x.User)
                    .Include(x => x.PlaylistMedias)
                    .ThenInclude(x => x.Media)
                    .Where(playlist => (playlist.UserId == userId || playlist.Public == true) && playlist.Type == type && playlist.Id != id)
                    .ToListAsync();
            }

            if (!String.IsNullOrEmpty(filter))
            {
                playlists = playlists.Where(x => x.Title.ToLower().Contains(filter.ToLower()) ||
                                            x.User.UserName.ToLower().Contains(filter.ToLower()));
            }

            List<PlaylistListViewModel> vmList = new List<PlaylistListViewModel>();

            foreach (var playlist in playlists)
            {
                PlaylistListViewModel vm = new PlaylistListViewModel()
                {
                    Id = playlist.Id,
                    Title = playlist.Title,
                    Duration = new TimeSpan(playlist.PlaylistMedias.Select(x => x.Media).Sum(x => x.Duration.Ticks)),
                    User = playlist.User,
                    PlaylistMedias = playlist.PlaylistMedias
                };
                vmList.Add(vm);
            }
            return vmList;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create(string mediaType)
        {
            PlaylistCreateViewModel vm = new PlaylistCreateViewModel()
            {
                MediaType = mediaType
            };

            return View(vm);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(PlaylistCreateViewModel vm)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!TryValidateModel(vm))
            {
                return View(vm);
            }
            else
            {
                Playlist<Media> newPlaylist = new Playlist<Media>()
                {
                    Title = vm.Title,
                    Public = vm.Public,
                    UserId = userId,
                    LastModified = DateTime.Now,
                    Type = vm.MediaType
                };

                _dbContext.Playlists.Add(newPlaylist);
                await _dbContext.SaveChangesAsync();

                if (vm.MediaType == "Film")
                {
                    return RedirectToAction("ManageItems", new { Id = newPlaylist.Id, type = "Film" });
                }
                else
                {
                    return RedirectToAction("Index");
                }

            }
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> ManageItems(int id, string type, string filterTitle = "")
        {
            IEnumerable<Media> media;

            if(type == "Film")
            {
                if (User.IsInRole("Admin"))
                {
                    media = await _dbContext.Films
                        .OrderByDescending(film => film.ReleaseDate)
                        .ToListAsync();
                }
                else
                {
                    media = await _dbContext.Films
                                       .OrderByDescending(film => film.ReleaseDate)
                                       .Where(film => film.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier) || film.Public == true)
                                       .ToListAsync();
                }
            }
            else if (type == "Music")
            {
                if (User.IsInRole("Admin"))
                {
                    media = await _dbContext.Music
                        .OrderByDescending(music => music.ReleaseDate)
                        .ToListAsync();
                }
                else
                {
                    media = await _dbContext.Music
                                       .OrderByDescending(music => music.ReleaseDate)
                                       .Where(music => music.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier) || music.Public == true)
                                       .ToListAsync();
                }
            }
            else if(type == "Podcast")
            {
                if (User.IsInRole("Admin"))
                {
                    media = await _dbContext.Podcasts
                        .OrderByDescending(podcast => podcast.ReleaseDate)
                        .ToListAsync();
                }
                else
                {
                    media = await _dbContext.Podcasts
                                       .OrderByDescending(podcast => podcast.ReleaseDate)
                                       .Where(podcast => podcast.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier) || podcast.Public == true)
                                       .ToListAsync();
                }
            }
            else
            {
                if (User.IsInRole("Admin"))
                {
                    media = await _dbContext.Series
                        .OrderByDescending(series => series.ReleaseDate)
                        .ToListAsync();
                }
                else
                {
                    media = await _dbContext.Series
                                       .OrderByDescending(series => series.ReleaseDate)
                                       .Where(series => series.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier) || series.Public == true)
                                       .ToListAsync();
                }
            }

            if (!String.IsNullOrEmpty(filterTitle))
            {
                media = media.Where(x => x.Title.ToLower().Contains(filterTitle.ToLower())).ToList();
            }

            PlaylistManageItemsViewModel vm = new PlaylistManageItemsViewModel()
            {
                PlaylistId = id,
                Type = type
            };

            vm.AllItemsInLibrary.AddRange(media);
            vm.AlreadyIncluded = await _dbContext.PlaylistMedias.Include(x => x.Media).Where(x => x.PlaylistId == id).Select(x => x.Media).ToListAsync();

            return View(vm);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddItem(int playlistId, int mediaId, string type)
        {
            Playlist<Media> playlist = await _dbContext.Playlists.FindAsync(playlistId);
            playlist.LastModified = DateTime.Now;

            PlaylistMedia playlistMedia = new PlaylistMedia()
            {
                PlaylistId = playlistId,
                MediaId = mediaId
            };
            _dbContext.PlaylistMedias.Add(playlistMedia);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("ManageItems", new { id = playlistId, type = type });
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> RemoveItem(int playlistId, int mediaId, string type)
        {
            Playlist<Media> playlist = await _dbContext.Playlists.FirstOrDefaultAsync(x => x.Id == playlistId);
            playlist.LastModified = DateTime.Now;

            PlaylistMedia playlistMediaToDelete = await _dbContext.PlaylistMedias.FirstOrDefaultAsync(x => x.PlaylistId == playlistId && x.MediaId == mediaId);
            _dbContext.PlaylistMedias.Remove(playlistMediaToDelete);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("ManageItems", new { id = playlistId, type = type });
        }
        [Authorize]
        public async Task<IActionResult> Detail(int id)
        {

            Playlist<Media> playlist = await _dbContext.Playlists.FirstOrDefaultAsync(x => x.Id == id);
            List<PlaylistMedia> playlistMedias = await _dbContext.PlaylistMedias.Include(x => x.Media).Where(x => x.PlaylistId == id).ToListAsync();

            PlaylistDetailViewModel vm = new PlaylistDetailViewModel()
            {
                Id = playlist.Id,
                Title = playlist.Title,
                Public = playlist.Public,
                PlaylistMedias = playlistMedias,
                LastModified = playlist.LastModified,
                User = await _dbContext.Users.FindAsync(playlist.UserId)
            };
            if (vm.PlaylistMedias.Count > 0)
            {
                vm.Duration = new TimeSpan(playlist.PlaylistMedias.Select(x => x.Media).Sum(x => x.Duration.Ticks));
            }
            return View(vm);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Playlist<Media> playlistToDelete = await _dbContext.Playlists.FindAsync(id);
            PlaylistDeleteViewModel vm = new PlaylistDeleteViewModel()
            {
                Id = playlistToDelete.Id,
                Title = playlistToDelete.Title
            };
            return View(vm);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            Playlist<Media> playlistToDelete = await _dbContext.Playlists.FindAsync(id);
            if (playlistToDelete.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier) || User.IsInRole("Admin"))
            {
                _dbContext.Playlists.Remove(playlistToDelete);
                await _dbContext.SaveChangesAsync();
            }

            return (RedirectToAction("Index"));
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Playlist<Media> playlistToEdit = await _dbContext.Playlists.Include(x => x.PlaylistMedias).FirstOrDefaultAsync(x => x.Id == id);

            PlaylistEditViewModel vm = new PlaylistEditViewModel()
            {
                Id = playlistToEdit.Id,
                Title = playlistToEdit.Title,
                Public = playlistToEdit.Public,
            };
            return View(vm);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, PlaylistEditViewModel vm)
        {
            Playlist<Media> changedPlaylist = await _dbContext.Playlists.Include(x => x.PlaylistMedias).FirstOrDefaultAsync(x => x.Id == id);
            if (User.IsInRole("Admin") || changedPlaylist.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                changedPlaylist.Title = vm.Title;
                changedPlaylist.Public = vm.Public;

                _dbContext.Playlists.Update(changedPlaylist);
                await _dbContext.SaveChangesAsync();

                return (RedirectToAction("Index"));
            }
            else
            {
                return LocalRedirect("/Identity/Account/AccessDenied");
            }
        }
       
    }
}
