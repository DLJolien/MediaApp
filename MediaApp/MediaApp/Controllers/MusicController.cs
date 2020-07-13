using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MediaApp.Domain;
using MediaApp.Domain.MediaTypes;
using MediaApp.Models;
using MediaApp.Models.Create;
using MediaApp.Models.Detail;
using MediaApp.Models.Edit;
using MediaApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MediaApp.Controllers
{
    public class MusicController : MediaController
    {
        private readonly MediaDb _dbContext;
        private readonly IPhotoService _photoService;
        private readonly SignInManager<User> _signInManager;
        public MusicController(MediaDb dbcontext, IPhotoService photoService, SignInManager<User> signInManager) : base(dbcontext, photoService)
        {
            _dbContext = dbcontext;
            _photoService = photoService;
            _signInManager = signInManager;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index(string filterTitle = "", string filterGenre = "Choose a genre")
        {
            User user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));

            IEnumerable<Music> music;

            if (!_signInManager.IsSignedIn(User))
            {
                music = await _dbContext.Music
                    .Include(music => music.Genre)
                    .OrderByDescending(music => music.ReleaseDate)
                    .Where(music => music.Public == true)
                    .ToListAsync();

            }
            else if (User.IsInRole("Admin"))
            {
                music = await _dbContext.Music
                    .Include(music => music.Genre)
                    .OrderByDescending(music => music.ReleaseDate)
                    .ToListAsync();
            }
            else
            {
                music = await _dbContext.Music
                                    .Include(music => music.Genre)
                                   .OrderByDescending(music => music.ReleaseDate)
                                   .Where(music => music.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier) || music.Public == true)
                                   .ToListAsync();
            }


            if (!String.IsNullOrEmpty(filterTitle) && filterGenre == "Choose a genre")
            {
                music = music.Where(x => x.Title.ToLower().Contains(filterTitle.ToLower())).ToList();
            }
            else if (String.IsNullOrEmpty(filterTitle) && filterGenre != "Choose a genre")
            {
                music = music.Where(x => x.Genre.Description == filterGenre).ToList();
            }
            else if (!String.IsNullOrEmpty(filterTitle) && filterGenre != "Choose a genre")
            {
                music = music.Where(x => x.Title.ToLower().Contains(filterTitle.ToLower()) && x.Genre.Description == filterGenre).ToList();
            }

            List<MediaListViewModel> vmList;

            if (!_signInManager.IsSignedIn(User))
            {
                vmList = music.Select(x => new MediaListViewModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    ReleaseDate = x.ReleaseDate,
                    Genre = x.Genre.Description,
                    PhotoUrl = x.PhotoUrl,
                }).ToList();
            }
            else
            {
                vmList = music.Select(x => new MediaListViewModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    ReleaseDate = x.ReleaseDate,
                    Genre = x.Genre.Description,
                    Bookmarked = _dbContext.PlaylistMedias.AnyAsync(y => y.MediaId == x.Id && y.PlaylistId == user.BookmarkedFilmsId).Result,
                    Seen = _dbContext.MediaSeens.AnyAsync(z => z.MediaId == x.Id && z.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier)).Result,
                    PhotoUrl = x.PhotoUrl,
                }).ToList();
            }

            return View(vmList);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Detail(int id)
        {

            Music music = await _dbContext.Music.Include(x => x.Genre).FirstOrDefaultAsync(x => x.Id == id);
            MusicDetailViewModel vm = new MusicDetailViewModel()
            {
                Id = music.Id,
                Title = music.Title,
                ReleaseDate = music.ReleaseDate,
                PhotoUrl = music.PhotoUrl,
                Singer = music.Singer,
                Genre = music.Genre.Description,
                Duration = music.Duration,
                ContentUrl = music.ContentUrl,
                Public = music.Public,
                Comments = await _dbContext.Comments.Include(x => x.User).Where(comment => comment.MediaId == music.Id && comment.IsApproved == true).OrderByDescending(x => x.PublishedDate).ToListAsync()
            };

            return View(vm);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            MusicCreateViewModel vm = new MusicCreateViewModel();

            var genres = await _dbContext.MusicGenres.ToListAsync();
            vm.Genres = genres.Select(genre => new SelectListItem() { Value = genre.Id.ToString(), Text = genre.Description }).ToList();
            vm.Duration = TimeSpan.FromMinutes(3);

            return View(vm);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(MusicCreateViewModel vm)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!TryValidateModel(vm))
            {
                var genres = await _dbContext.MusicGenres.ToListAsync();
                vm.Genres = genres.Select(genre => new SelectListItem() { Value = genre.Id.ToString(), Text = genre.Description }).ToList();
                vm.Duration = TimeSpan.FromMinutes(3);

                return View(vm);
            }
            else
            {
                Music newMusic = new Music()
                {
                    Title = vm.Title,
                    ReleaseDate = vm.ReleaseDate,
                    Singer = vm.Singer,
                    GenreId = vm.SelectedGenreId,
                    Duration = vm.Duration,
                    Public = vm.Public,
                    UserId = userId,
                    ContentUrl = vm.ContentUrl
                };


                if (vm.Photo != null)
                {
                    string uniqueFileName = _photoService.UploadPicture(vm.Photo);
                    newMusic.PhotoUrl = "/ug-media-pics/" + uniqueFileName;
                }
                else
                {
                    _photoService.AssignPicToMedia(newMusic);
                }
                _dbContext.Music.Add(newMusic);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            Music musicToEdit = await _dbContext.Music.Include(x => x.Genre).FirstOrDefaultAsync(x => x.Id == id);
            if (User.IsInRole("Admin") || musicToEdit.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                MusicEditViewModel vm = new MusicEditViewModel();

                var genres = await _dbContext.FilmGenres.ToListAsync();

                vm.Genres = genres.Select(genre => new SelectListItem() { Value = genre.Id.ToString(), Text = genre.Description }).ToList();

                vm.Id = musicToEdit.Id;
                vm.Title = musicToEdit.Title;
                vm.ReleaseDate = musicToEdit.ReleaseDate;
                vm.PhotoUrl = musicToEdit.PhotoUrl;
                vm.Singer = musicToEdit.Singer;
                vm.SelectedGenreId = musicToEdit.Genre.Id;
                vm.Duration = musicToEdit.Duration;
                vm.ContentUrl = musicToEdit.ContentUrl;
                vm.Public = musicToEdit.Public;

                return View(vm);

            }
            else
            {
                return LocalRedirect("/Identity/Account/AccessDenied");
            }
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(MusicEditViewModel vm)
        {
            Music changedMusic = await _dbContext.Music.Include(x => x.Genre).FirstOrDefaultAsync(x => x.Id == vm.Id);
            if (User.IsInRole("Admin") || changedMusic.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier))
            {

                changedMusic.Title = vm.Title;
                changedMusic.ReleaseDate = vm.ReleaseDate;
                changedMusic.Singer = vm.Singer;
                changedMusic.GenreId = vm.SelectedGenreId;
                changedMusic.Duration = vm.Duration;
                changedMusic.ContentUrl = vm.ContentUrl;
                changedMusic.Public = vm.Public;

                if (vm.Photo != null)
                {
                    _photoService.DeletePicture(changedMusic.PhotoUrl);
                    string uniqueFileName = _photoService.UploadPicture(vm.Photo);
                    changedMusic.PhotoUrl = "/ug-media-pics/" + uniqueFileName;
                }
                _dbContext.Music.Update(changedMusic);
                await _dbContext.SaveChangesAsync();
            }
            return RedirectToAction("Detail", new { Id = vm.Id });
        }
    }
}
