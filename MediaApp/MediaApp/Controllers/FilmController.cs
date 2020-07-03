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
using MediaApp.Models.Edit;
using MediaApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MediaApp.Controllers
{
    public class FilmController : Controller
    {
        private readonly MediaDb _dbContext;
        private readonly IPhotoService _photoService;
        private readonly SignInManager<User> _signInManager;

        public FilmController(MediaDb dbcontext, IPhotoService photoService, SignInManager<User> signInManager)
        {
            _dbContext = dbcontext;
            _photoService = photoService;
            _signInManager = signInManager;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index(string filterTitle = "", string filterGenre = "Choose a genre")
        {
            User user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));

            IEnumerable<Film> films;            

            if (!_signInManager.IsSignedIn(User))
            {
                films = await _dbContext.Films
                                        .Include(x => x.Status)
                                        .Include(x => x.Genre)
                                        .OrderByDescending(film => film.ReleaseDate)
                                        .Where(film => film.Accessibility == "Public")
                                        .ToListAsync();
            }
            else if (User.IsInRole("Admin"))
            {
                films = await _dbContext.Films
                                        .Include(x => x.Status)
                                        .Include(x => x.Genre)
                                        .OrderByDescending(film => film.ReleaseDate)
                                        .ToListAsync();
            }
            else
            {
                films = await _dbContext.Films
                                        .Include(x => x.Status)
                                        .Include(x => x.Genre)
                                        .OrderByDescending(film => film.ReleaseDate)
                                        .Where(film => film.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier) || film.Accessibility == "Public")
                                        .ToListAsync();
            }

            if(!String.IsNullOrEmpty(filterTitle) && filterGenre == "Choose a genre")
            {
                films = films.Where(x => x.Title.ToLower().Contains(filterTitle.ToLower())).ToList();                   
            }
            else if (String.IsNullOrEmpty(filterTitle) && filterGenre != "Choose a genre")
            {
                films = films.Where(x => x.Genre.Description == filterGenre).ToList();
            }
            else if(!String.IsNullOrEmpty(filterTitle) && filterGenre != "Choose a genre")
            {
                films = films.Where(x => x.Title.ToLower().Contains(filterTitle.ToLower()) && x.Genre.Description == filterGenre).ToList();
            }

            List<MediaListViewModel> vmList = films.Select(x => new MediaListViewModel()
             {
                 Id = x.Id,
                 Title = x.Title,
                 Status = x.Status.Description,
                 ReleaseDate = x.ReleaseDate,
                 Genre = x.Genre.Description,
                 Bookmarked = _dbContext.PlaylistMedias.AnyAsync(y => y.MediaId == x.Id && y.PlaylistId == user.BookmarkedFilmsId).Result,
                 PhotoUrl = x.PhotoUrl,
             }).ToList();

                
            return View(vmList);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Detail(int id)
        {

            Film film = await _dbContext.Films.Include(x => x.Status).Include(x => x.Genre).FirstOrDefaultAsync(x => x.Id == id);
            FilmDetailViewModel vm = new FilmDetailViewModel()
            {
                Id = film.Id,
                Title = film.Title,
                Status = film.Status.Description,
                ReleaseDate = film.ReleaseDate,
                PhotoUrl = film.PhotoUrl,
                Director = film.Director,
                Genre = film.Genre.Description,
                Duration = film.Duration,
                ContentUrl = film.ContentUrl,
                Accessibility = film.Accessibility

            };
            return View(vm);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            FilmCreateViewModel vm = new FilmCreateViewModel();

            var genres = await _dbContext.FilmGenres.ToListAsync();
            var statuses = await _dbContext.Statuses.ToListAsync();

            vm.Genres = genres.Select(genre => new SelectListItem() { Value = genre.Id.ToString(), Text = genre.Description }).ToList();
            vm.Statuses = statuses.Select(status => new SelectListItem() { Value = status.Id.ToString(), Text = status.Description }).ToList();

            return View(vm);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(FilmCreateViewModel vm)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!TryValidateModel(vm))
            {
                var genres = await _dbContext.FilmGenres.ToListAsync();
                var statuses = await _dbContext.Statuses.ToListAsync();

                vm.Genres = genres.Select(genre => new SelectListItem() { Value = genre.Id.ToString(), Text = genre.Description }).ToList();
                vm.Statuses = statuses.Select(status => new SelectListItem() { Value = status.Id.ToString(), Text = status.Description }).ToList();

                return View(vm);
            }
            else
            {
                Film newFilm = new Film()
                {
                    Title = vm.Title,
                    StatusId = vm.SelectedStatusId,
                    ReleaseDate = vm.ReleaseDate,
                    Director = vm.Director,
                    GenreId = vm.SelectedGenreId,
                    Duration = vm.Duration,
                    Accessibility = vm.Public,
                    UserId = userId, 
                    ContentUrl = vm.ContentUrl


                };

                if (vm.Photo != null)
                {
                    string uniqueFileName = _photoService.UploadPicture(vm.Photo);
                    newFilm.PhotoUrl = "/ug-media-pics/" + uniqueFileName;
                }
                else
                {
                    _photoService.AssignPicToMedia(newFilm);
                }
                _dbContext.Films.Add(newFilm);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            Film filmToEdit = await _dbContext.Films.Include(x => x.Genre).Include(x => x.Status).FirstOrDefaultAsync(x => x.Id == id);
            if (User.IsInRole("Admin") || filmToEdit.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                FilmEditViewModel vm = new FilmEditViewModel();

                var genres = await _dbContext.FilmGenres.ToListAsync();
                var statuses = await _dbContext.Statuses.ToListAsync();

                vm.Genres = genres.Select(genre => new SelectListItem() { Value = genre.Id.ToString(), Text = genre.Description }).ToList();
                vm.Statuses = statuses.Select(status => new SelectListItem() { Value = status.Id.ToString(), Text = status.Description }).ToList();

                vm.Id = filmToEdit.Id;
                vm.Title = filmToEdit.Title;
                vm.SelectedStatusId = filmToEdit.Status.Id;
                vm.ReleaseDate = filmToEdit.ReleaseDate;
                vm.PhotoUrl = filmToEdit.PhotoUrl;
                vm.Director = filmToEdit.Director;
                vm.SelectedGenreId = filmToEdit.Genre.Id;
                vm.Duration = filmToEdit.Duration;
                vm.ContentUrl = filmToEdit.ContentUrl;
                vm.Public = filmToEdit.Accessibility;

                return View(vm);

            }
            else
            {
                return LocalRedirect("/Identity/Account/AccessDenied");
            }
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(FilmEditViewModel vm)
        {
            Film changedFilm = await _dbContext.Films.Include(x => x.Genre).Include(x => x.Status).FirstOrDefaultAsync(x => x.Id == vm.Id);
            if (User.IsInRole("Admin") || changedFilm.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier))
            {

                changedFilm.Title = vm.Title;
                changedFilm.StatusId = vm.SelectedStatusId;
                changedFilm.ReleaseDate = vm.ReleaseDate;
                changedFilm.Director = vm.Director;
                changedFilm.GenreId = vm.SelectedGenreId;
                changedFilm.Duration = vm.Duration;
                changedFilm.ContentUrl = vm.ContentUrl;
                changedFilm.Accessibility = vm.Public;

                if (vm.Photo != null)
                {
                    _photoService.DeletePicture(changedFilm.PhotoUrl);
                    string uniqueFileName = _photoService.UploadPicture(vm.Photo);
                    changedFilm.PhotoUrl = "/ug-media-pics/" + uniqueFileName;
                }
                _dbContext.Films.Update(changedFilm);
                await _dbContext.SaveChangesAsync();
            }
            return RedirectToAction("Detail", new { Id = vm.Id });
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Film filmToDelete = await _dbContext.Films.FindAsync(id);
            if (User.IsInRole("Admin") || filmToDelete.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                MediaDeleteViewModel vm = new MediaDeleteViewModel()
                {
                    Id = filmToDelete.Id,
                    Title = filmToDelete.Title,
                    ReleaseDate = filmToDelete.ReleaseDate
                };

                return View(vm);
            }
            else
            {
                return LocalRedirect("/Identity/Account/AccessDenied");
            }
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            Film filmToDelete = _dbContext.Films.Find(id);
            if (User.IsInRole("Admin") || filmToDelete.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                _photoService.DeletePicture(filmToDelete.PhotoUrl);
                _dbContext.Films.Remove(filmToDelete);
                await _dbContext.SaveChangesAsync();
            }

            return (RedirectToAction("Index"));
        }

    }
}
