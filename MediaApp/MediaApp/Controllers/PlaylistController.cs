using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using MediaApp.Domain;
using MediaApp.Domain.MediaTypes;
using MediaApp.Models.Create;
using MediaApp.Models.Detail;
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
        [AllowAnonymous]
        public async Task<IActionResult> Index(string filter = "")
        {
            IEnumerable<Playlist<Media>> playlists = await _dbContext.Playlists.Include(x => x.User).Include(x => x.PlaylistMedias).ThenInclude(x => x.Media).ToListAsync();

            if (_signInManager.IsSignedIn(User) && !User.IsInRole("Admin"))
            {
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                playlists = playlists.Where(playlist => playlist.UserId == userId || playlist.Public == true);
            }
            else if (!_signInManager.IsSignedIn(User))
            {
                playlists = playlists.Where(playlist => playlist.Public == true);
            }
            if (!String.IsNullOrEmpty(filter))
            {
                playlists = playlists.Where(x => x.Title.ToLower().Contains(filter.ToLower()));
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
            return View(vmList);
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
        public async Task<IActionResult> Create(PlaylistCreateViewModel vm, string mediaType)
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
                    UserId = userId,
                };

                _dbContext.Playlists.Add(newPlaylist);
                await _dbContext.SaveChangesAsync();

                if (vm.MediaType == "Film")
                {
                    return RedirectToAction("ManageFilms", new { Id = newPlaylist.Id });
                }
                else
                {
                    return RedirectToAction("Index");
                }

            }
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> ManageFilms(int id)
        {
            PlaylistAddFilmViewModel vm = new PlaylistAddFilmViewModel()
            {
                PlaylistId = id
            };

            IEnumerable<Film> films;

            films = await _dbContext.Films.Include(x => x.Status).Include(x => x.Genre).ToListAsync();

            if (_signInManager.IsSignedIn(User) && !User.IsInRole("Admin"))
            {
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                films = films.Where(film => film.UserId == userId || film.Accessibility == "Public");
            }
            else if (!_signInManager.IsSignedIn(User))
            {
                films = films.Where(film => film.Accessibility == "Public");
            }

            vm.AllFilmsInLibrary.AddRange(films);

            var alreadyInPlaylist = await _dbContext.PlaylistMedias.Include(x => x.Media).Where(x => x.PlaylistId == id).ToListAsync();
            vm.AlreadyIncluded = alreadyInPlaylist.Select(x => x.Media).ToList();

            return View(vm);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddFilm(int playlistId, int mediaId)
        {

            PlaylistMedia playlistMedia = new PlaylistMedia()
            {
                PlaylistId = playlistId,
                MediaId = mediaId
            };
            _dbContext.PlaylistMedias.Add(playlistMedia);
            await _dbContext.SaveChangesAsync();

            IEnumerable<Film> films;

            films = await _dbContext.Films.Include(x => x.Status).Include(x => x.Genre).ToListAsync();

            if (_signInManager.IsSignedIn(User) && !User.IsInRole("Admin"))
            {
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                films = films.Where(film => film.UserId == userId || film.Accessibility == "Public");
            }
            else if (!_signInManager.IsSignedIn(User))
            {
                films = films.Where(film => film.Accessibility == "Public");
            }

            var alreadyInPlaylist = await _dbContext.PlaylistMedias.Include(x => x.Media).Where(x => x.PlaylistId == playlistId).ToListAsync();
            PlaylistAddFilmViewModel vm = new PlaylistAddFilmViewModel()
            {
                PlaylistId = playlistId,
                AlreadyIncluded = alreadyInPlaylist.Select(x => x.Media).ToList(),
            };

            vm.AllFilmsInLibrary.AddRange(films);

            return RedirectToAction("ManageFilms", new { id = playlistId });
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> RemoveFilm(int playlistId, int mediaId)
        {
            PlaylistMedia playlistMediaToDelete = await _dbContext.PlaylistMedias.FirstOrDefaultAsync( x => x.PlaylistId == playlistId && x.MediaId == mediaId);
            _dbContext.PlaylistMedias.Remove(playlistMediaToDelete);
            await _dbContext.SaveChangesAsync();

            return  RedirectToAction("ManageFilms", new { id = playlistId });
        }
        [AllowAnonymous]
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
                User = await _dbContext.Users.FindAsync(playlist.UserId)
            };
            if(vm.PlaylistMedias.Count > 0)
            {
                vm.Duration = new TimeSpan(playlist.PlaylistMedias.Select(x => x.Media).Sum(x => x.Duration.Ticks));
            }
            return View(vm);
        }

    }
}
