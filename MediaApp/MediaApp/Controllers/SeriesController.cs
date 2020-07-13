using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MediaApp.Areas.Identity.Pages.Account;
using MediaApp.Data.Migrations;
using MediaApp.Domain;
using MediaApp.Domain.MediaTypes;
using MediaApp.Models;
using MediaApp.Models.Create;
using MediaApp.Models.Detail;
using MediaApp.Models.Edit;
using MediaApp.Models.Index;
using MediaApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MediaApp.Controllers
{
    public class SeriesController : MediaController
    {
        private readonly MediaDb _dbContext;
        private readonly IPhotoService _photoService;
        private readonly SignInManager<User> _signInManager;

        public SeriesController(MediaDb dbcontext, IPhotoService photoService, SignInManager<User> signInManager) : base(dbcontext, photoService)
        {
            _dbContext = dbcontext;
            _photoService = photoService;
            _signInManager = signInManager;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index(string filterTitle = "", string filterGenre = "Choose a genre")
        {
            User user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));

            IEnumerable<Series> series;

            if (!_signInManager.IsSignedIn(User))
            {
                series = await _dbContext.Series
                    .Include(series => series.Genre)
                    .OrderByDescending(series => series.ReleaseDate)
                    .Where(series => series.Public == true)
                    .ToListAsync();

            }
            else if (User.IsInRole("Admin"))
            {
                series = await _dbContext.Series
                    .Include(series => series.Genre)
                    .OrderByDescending(series => series.ReleaseDate)
                    .ToListAsync();
            }
            else
            {
                series = await _dbContext.Series
                                    .Include(series => series.Genre)
                                   .OrderByDescending(series => series.ReleaseDate)
                                   .Where(series => series.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier) || series.Public == true)
                                   .ToListAsync();
            }


            if (!String.IsNullOrEmpty(filterTitle) && filterGenre == "Choose a genre")
            {
                series = series.Where(x => x.Title.ToLower().Contains(filterTitle.ToLower())).ToList();
            }
            else if (String.IsNullOrEmpty(filterTitle) && filterGenre != "Choose a genre")
            {
                series = series.Where(x => x.Genre.Description == filterGenre).ToList();
            }
            else if (!String.IsNullOrEmpty(filterTitle) && filterGenre != "Choose a genre")
            {
                series = series.Where(x => x.Title.ToLower().Contains(filterTitle.ToLower()) && x.Genre.Description == filterGenre).ToList();
            }

            List<MediaListViewModel> vmList;

            if (!_signInManager.IsSignedIn(User))
            {
                vmList = series.Select(x => new MediaListViewModel()
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
                vmList = series.Select(x => new MediaListViewModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    ReleaseDate = x.ReleaseDate,
                    Genre = x.Genre.Description,
                    Bookmarked = _dbContext.PlaylistMedias.AnyAsync(y => y.MediaId == x.Id && y.PlaylistId == user.BookmarkedSeriesId).Result,
                    Seen = _dbContext.MediaSeens.AnyAsync(z => z.MediaId == x.Id && z.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier)).Result,
                    PhotoUrl = x.PhotoUrl,
                }).ToList();
            }

            return View(vmList);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Detail(int id)
        {

            Series series = await _dbContext.Series.Include(x => x.Genre).FirstOrDefaultAsync(x => x.Id == id);
            SeriesDetailViewModel vm = new SeriesDetailViewModel()
            {
                Id = series.Id,
                Title = series.Title,
                ReleaseDate = series.ReleaseDate,
                PhotoUrl = series.PhotoUrl,
                NumberOfEpisodes = series.NumberOfEpisodes,
                NumberOfSeasons = series.NumberOfSeasons,
                Broadcaster = series.Broadcaster,
                Genre = series.Genre.Description,
                Duration = series.Duration,
                ContentUrl = series.ContentUrl,
                Public = series.Public,
                Comments = await _dbContext.Comments.Include(x => x.User).Where(comment => comment.MediaId == series.Id && comment.IsApproved == true).OrderByDescending(x => x.PublishedDate).ToListAsync()
            };

            return View(vm);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            SeriesCreateViewModel vm = new SeriesCreateViewModel();

            var genres = await _dbContext.FilmGenres.ToListAsync();

            vm.Genres = genres.Select(genre => new SelectListItem() { Value = genre.Id.ToString(), Text = genre.Description }).ToList();
            vm.Duration = TimeSpan.FromMinutes(120);

            return View(vm);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(SeriesCreateViewModel vm)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!TryValidateModel(vm))
            {
                var genres = await _dbContext.FilmGenres.ToListAsync();
                vm.Genres = genres.Select(genre => new SelectListItem() { Value = genre.Id.ToString(), Text = genre.Description }).ToList();
                vm.Duration = TimeSpan.FromMinutes(120);

                return View(vm);
            }
            else
            {
                Series newSeries = new Series()
                {
                    Title = vm.Title,
                    ReleaseDate = vm.ReleaseDate,
                    NumberOfEpisodes = vm.NumberOfEpisodes,
                    NumberOfSeasons = vm.NumberOfSeasons,
                    Broadcaster = vm.Broadcaster,
                    GenreId = vm.SelectedGenreId,
                    Duration = vm.Duration,
                    Public = vm.Public,
                    UserId = userId,
                    ContentUrl = vm.ContentUrl
                };


                if (vm.Photo != null)
                {
                    string uniqueFileName = _photoService.UploadPicture(vm.Photo);
                    newSeries.PhotoUrl = "/ug-media-pics/" + uniqueFileName;
                }
                else
                {
                    _photoService.AssignPicToMedia(newSeries);
                }
                _dbContext.Series.Add(newSeries);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            Series seriesToEdit = await _dbContext.Series.Include(x => x.Genre).FirstOrDefaultAsync(x => x.Id == id);
            if (User.IsInRole("Admin") || seriesToEdit.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                SeriesEditViewModel vm = new SeriesEditViewModel();

                var genres = await _dbContext.FilmGenres.ToListAsync();

                vm.Genres = genres.Select(genre => new SelectListItem() { Value = genre.Id.ToString(), Text = genre.Description }).ToList();

                vm.Id = seriesToEdit.Id;
                vm.Title = seriesToEdit.Title;
                vm.ReleaseDate = seriesToEdit.ReleaseDate;
                vm.PhotoUrl = seriesToEdit.PhotoUrl;
                vm.NumberOfEpisodes = seriesToEdit.NumberOfEpisodes;
                vm.NumberOfSeasons = seriesToEdit.NumberOfSeasons;
                vm.Broadcaster = seriesToEdit.Broadcaster;
                vm.SelectedGenreId = seriesToEdit.Genre.Id;
                vm.Duration = seriesToEdit.Duration;
                vm.ContentUrl = seriesToEdit.ContentUrl;
                vm.Public = seriesToEdit.Public;

                return View(vm);

            }
            else
            {
                return LocalRedirect("/Identity/Account/AccessDenied");
            }
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(SeriesEditViewModel vm)
        {
            Series changedSeries = await _dbContext.Series.Include(x => x.Genre).FirstOrDefaultAsync(x => x.Id == vm.Id);
            if (User.IsInRole("Admin") || changedSeries.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier))
            {

                changedSeries.Title = vm.Title;
                changedSeries.ReleaseDate = vm.ReleaseDate;
                changedSeries.NumberOfEpisodes = vm.NumberOfEpisodes;
                changedSeries.NumberOfSeasons = vm.NumberOfSeasons;
                changedSeries.Broadcaster = vm.Broadcaster;
                changedSeries.GenreId = vm.SelectedGenreId;
                changedSeries.Duration = vm.Duration;
                changedSeries.ContentUrl = vm.ContentUrl;
                changedSeries.Public = vm.Public;

                if (vm.Photo != null)
                {
                    _photoService.DeletePicture(changedSeries.PhotoUrl);
                    string uniqueFileName = _photoService.UploadPicture(vm.Photo);
                    changedSeries.PhotoUrl = "/ug-media-pics/" + uniqueFileName;
                }
                _dbContext.Series.Update(changedSeries);
                await _dbContext.SaveChangesAsync();
            }
            return RedirectToAction("Detail", new { Id = vm.Id });
        }
    }
}
