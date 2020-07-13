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
    public class PodcastController : MediaController
    {
        private readonly MediaDb _dbContext;
        private readonly IPhotoService _photoService;
        private readonly SignInManager<User> _signInManager;

        public PodcastController(MediaDb dbcontext, IPhotoService photoService, SignInManager<User> signInManager) : base(dbcontext, photoService)
        {
            _dbContext = dbcontext;
            _photoService = photoService;
            _signInManager = signInManager;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index(string filterTitle = "", string filterGenre = "Choose a genre")
        {
            User user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));

            IEnumerable<Podcast> podcasts;

            if (!_signInManager.IsSignedIn(User))
            {
                podcasts = await _dbContext.Podcasts
                    .Include(podcast => podcast.Genre)
                    .OrderByDescending(podcast => podcast.ReleaseDate)
                    .Where(podcast => podcast.Public == true)
                    .ToListAsync();

            }
            else if (User.IsInRole("Admin"))
            {
                podcasts = await _dbContext.Podcasts
                    .Include(podcast => podcast.Genre)
                    .OrderByDescending(podcast => podcast.ReleaseDate)
                    .ToListAsync();
            }
            else
            {
                podcasts = await _dbContext.Podcasts
                                    .Include(podcast => podcast.Genre)
                                   .OrderByDescending(podcast => podcast.ReleaseDate)
                                   .Where(podcast => podcast.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier) || podcast.Public == true)
                                   .ToListAsync();
            }


            if (!String.IsNullOrEmpty(filterTitle) && filterGenre == "Choose a genre")
            {
                podcasts = podcasts.Where(x => x.Title.ToLower().Contains(filterTitle.ToLower())).ToList();
            }
            else if (String.IsNullOrEmpty(filterTitle) && filterGenre != "Choose a genre")
            {
                podcasts = podcasts.Where(x => x.Genre.Description == filterGenre).ToList();
            }
            else if (!String.IsNullOrEmpty(filterTitle) && filterGenre != "Choose a genre")
            {
                podcasts = podcasts.Where(x => x.Title.ToLower().Contains(filterTitle.ToLower()) && x.Genre.Description == filterGenre).ToList();
            }

            List<MediaListViewModel> vmList;

            if (!_signInManager.IsSignedIn(User))
            {
                vmList = podcasts.Select(x => new MediaListViewModel()
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
                vmList = podcasts.Select(x => new MediaListViewModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    ReleaseDate = x.ReleaseDate,
                    Genre = x.Genre.Description,
                    Bookmarked = _dbContext.PlaylistMedias.AnyAsync(y => y.MediaId == x.Id && y.PlaylistId == user.BookmarkedPodcastId).Result,
                    Seen = _dbContext.MediaSeens.AnyAsync(z => z.MediaId == x.Id && z.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier)).Result,
                    PhotoUrl = x.PhotoUrl,
                }).ToList();
            }

            return View(vmList);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Detail(int id)
        {

            Podcast podcast = await _dbContext.Podcasts.Include(x => x.Genre).FirstOrDefaultAsync(x => x.Id == id);
            PodcastDetailViewModel vm = new PodcastDetailViewModel()
            {
                Id = podcast.Id,
                Title = podcast.Title,
                ReleaseDate = podcast.ReleaseDate,
                PhotoUrl = podcast.PhotoUrl,
                Organisation = podcast.Organisation,
                Genre = podcast.Genre.Description,
                Duration = podcast.Duration,
                ContentUrl = podcast.ContentUrl,
                Public = podcast.Public,
                Comments = await _dbContext.Comments.Include(x => x.User).Where(comment => comment.MediaId == podcast.Id && comment.IsApproved == true).OrderByDescending(x => x.PublishedDate).ToListAsync()
            };

            return View(vm);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            PodcastCreateViewModel vm = new PodcastCreateViewModel();

            var genres = await _dbContext.PodcastGenres.ToListAsync();

            vm.Genres = genres.Select(genre => new SelectListItem() { Value = genre.Id.ToString(), Text = genre.Description }).ToList();
            vm.Duration = TimeSpan.FromMinutes(120);

            return View(vm);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(PodcastCreateViewModel vm)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!TryValidateModel(vm))
            {
                var genres = await _dbContext.PodcastGenres.ToListAsync();
                vm.Genres = genres.Select(genre => new SelectListItem() { Value = genre.Id.ToString(), Text = genre.Description }).ToList();
                vm.Duration = TimeSpan.FromMinutes(120);

                return View(vm);
            }
            else
            {
                Podcast newPodcast = new Podcast()
                {
                    Title = vm.Title,
                    ReleaseDate = vm.ReleaseDate,
                    Organisation = vm.Organisation,
                    GenreId = vm.SelectedGenreId,
                    Duration = vm.Duration,
                    Public = vm.Public,
                    UserId = userId,
                    ContentUrl = vm.ContentUrl
                };


                if (vm.Photo != null)
                {
                    string uniqueFileName = _photoService.UploadPicture(vm.Photo);
                    newPodcast.PhotoUrl = "/ug-media-pics/" + uniqueFileName;
                }
                else
                {
                    _photoService.AssignPicToMedia(newPodcast);
                }
                _dbContext.Podcasts.Add(newPodcast);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            Podcast podcastToEdit = await _dbContext.Podcasts.Include(x => x.Genre).FirstOrDefaultAsync(x => x.Id == id);
            if (User.IsInRole("Admin") || podcastToEdit.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                PodcastEditViewModel vm = new PodcastEditViewModel();

                var genres = await _dbContext.PodcastGenres.ToListAsync();

                vm.Genres = genres.Select(genre => new SelectListItem() { Value = genre.Id.ToString(), Text = genre.Description }).ToList();

                vm.Id = podcastToEdit.Id;
                vm.Title = podcastToEdit.Title;
                vm.ReleaseDate = podcastToEdit.ReleaseDate;
                vm.PhotoUrl = podcastToEdit.PhotoUrl;
                vm.Organisation = podcastToEdit.Organisation;
                vm.SelectedGenreId = podcastToEdit.Genre.Id;
                vm.Duration = podcastToEdit.Duration;
                vm.ContentUrl = podcastToEdit.ContentUrl;
                vm.Public = podcastToEdit.Public;

                return View(vm);

            }
            else
            {
                return LocalRedirect("/Identity/Account/AccessDenied");
            }
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(PodcastEditViewModel vm)
        {
            Podcast changedPodcast = await _dbContext.Podcasts.Include(x => x.Genre).FirstOrDefaultAsync(x => x.Id == vm.Id);
            if (User.IsInRole("Admin") || changedPodcast.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier))
            {

                changedPodcast.Title = vm.Title;
                changedPodcast.ReleaseDate = vm.ReleaseDate;
                changedPodcast.Organisation = vm.Organisation;
                changedPodcast.GenreId = vm.SelectedGenreId;
                changedPodcast.Duration = vm.Duration;
                changedPodcast.ContentUrl = vm.ContentUrl;
                changedPodcast.Public = vm.Public;

                if (vm.Photo != null)
                {
                    _photoService.DeletePicture(changedPodcast.PhotoUrl);
                    string uniqueFileName = _photoService.UploadPicture(vm.Photo);
                    changedPodcast.PhotoUrl = "/ug-media-pics/" + uniqueFileName;
                }
                _dbContext.Podcasts.Update(changedPodcast);
                await _dbContext.SaveChangesAsync();
            }
            return RedirectToAction("Detail", new { Id = vm.Id });
        }
    }
}
