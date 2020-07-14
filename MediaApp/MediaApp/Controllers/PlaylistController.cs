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
        public async Task<IActionResult> Index(string mediaType, string filter = "")
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int id;
            if (mediaType == "Film")
            {
                id = (await _dbContext.Users.FirstOrDefaultAsync(user => user.Id == userId)).BookmarkedFilmsId;
            }
            else if(mediaType == "Podcast")
            {
            id = (await _dbContext.Users.FirstOrDefaultAsync(user => user.Id == userId)).BookmarkedPodcastId;              
            }
            else if(mediaType == "Music")
            {
                id = (await _dbContext.Users.FirstOrDefaultAsync(user => user.Id == userId)).BookmarkedMusicId;
            }
            else
            {
                id = (await _dbContext.Users.FirstOrDefaultAsync(user => user.Id == userId)).BookmarkedSeriesId;
            }                      
            PlaylistListViewModel vm = await GetPlaylistListViewModels(id, filter, mediaType);
            return View(vm);
        }
        
        private async Task<PlaylistListViewModel> GetPlaylistListViewModels(int id, string filter, string type)
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

            PlaylistListViewModel vm = new PlaylistListViewModel() { 
            Playlists = playlists,
            MediaType = type
            };
            return vm;
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

                    return RedirectToAction("ManageItems", new { id = newPlaylist.Id, mediaType = vm.MediaType });              
            }
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> ManageItems(int id, string mediaType, string filterTitle = "")
        {
            IEnumerable<Media> media;

            if(mediaType == "Film")
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
            else if (mediaType == "Music")
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
            else if(mediaType == "Podcast")
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
                Type = mediaType
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

            return RedirectToAction("ManageItems", new { id = playlistId, mediaType = type });
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
        public async Task<IActionResult> Delete(int id, string type)
        {
            Playlist<Media> playlistToDelete = await _dbContext.Playlists.FindAsync(id);
            PlaylistDeleteViewModel vm = new PlaylistDeleteViewModel()
            {
                Id = playlistToDelete.Id,
                Title = playlistToDelete.Title,
                MediaType = type
            };
            return View(vm);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(int id, string type)
        {
            Playlist<Media> playlistToDelete = await _dbContext.Playlists.FirstOrDefaultAsync(x => x.Id == id);
            if (playlistToDelete.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier) || User.IsInRole("Admin"))
            {
                _dbContext.Playlists.Remove(playlistToDelete);
                await _dbContext.SaveChangesAsync();
            }

            return (RedirectToAction("Index", new { mediaType = type }));
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
