using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaApp.Domain;
using MediaApp.Domain.MediaTypes;
using MediaApp.Models;
using MediaApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MediaApp.Controllers
{
    public class FilmController : Controller
    {
        private readonly MediaDb _dbContext;
        private readonly IPhotoService _photoService;

        public FilmController(MediaDb dbcontext, IPhotoService photoService)
        {
            _dbContext = dbcontext;
            _photoService = photoService;
        }

        public async Task<IActionResult> Index()
        {

            List<FilmListViewModel> vmList = new List<FilmListViewModel>();
            var films = await _dbContext.Films.Include(x => x.Status).Include(x => x.Genre).ToListAsync();
            foreach (var film in films)
            {
                FilmListViewModel vm = new FilmListViewModel()
                {
                    Id = film.Id,
                    Title = film.Title,
                    Status = film.Status.Description,
                    ReleaseDate = film.ReleaseDate,
                    PhotoUrl = film.PhotoUrl,
                    Genre = film.Genre.Description,                  
                    
                };
                vmList.Add(vm);
            }
            return View(vmList);
        }
        public async Task<IActionResult> Detail(int id)
        {

            Film film = await _dbContext.Films.Include(x => x.Status).Include(x => x.Genre).FirstOrDefaultAsync(x => x.Id == id);
            FilmDetailViewModel vm = new FilmDetailViewModel()
            {
                Title = film.Title,
                Status = film.Status.Description,
                ReleaseDate = film.ReleaseDate,
                PhotoUrl = film.PhotoUrl,
                Director = film.Director,
                Genre = film.Genre.Description,
                Duration = film.Duration

            };
            return View(vm);
        }
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

        [HttpPost]
        public async Task<IActionResult> Create(FilmCreateViewModel vm)
        {
            //string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
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
                    Duration = vm.Duration
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
    }
}
