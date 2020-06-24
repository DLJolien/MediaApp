﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaApp.Domain;
using MediaApp.Domain.MediaTypes;
using MediaApp.Models;
using MediaApp.Models.Edit;
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

            List<MediaListViewModel> vmList = new List<MediaListViewModel>();
            var films = await _dbContext.Films.Include(x => x.Status).Include(x => x.Genre).OrderBy(film => film.ReleaseDate).ToListAsync();
            foreach (var film in films)
            {
                MediaListViewModel vm = new MediaListViewModel()
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
                Id= film.Id,
                Title = film.Title,
                Status = film.Status.Description,
                ReleaseDate = film.ReleaseDate,
                PhotoUrl = film.PhotoUrl,
                Director = film.Director,
                Genre = film.Genre.Description,
                Duration = film.Duration,
                ContentUrl = film.ContentUrl

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
                    Duration = vm.Duration,
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
                Film filmToEdit = await _dbContext.Films.Include(x => x.Genre).Include(x =>x.Status).FirstOrDefaultAsync(x => x.Id == id);

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

                return View(vm);
            }
            [HttpPost]
            public async Task<IActionResult> Edit(FilmEditViewModel vm)
            {
                Film changedFilm = await _dbContext.Films.Include(x => x.Genre).Include(x => x.Status).FirstOrDefaultAsync(x => x.Id == vm.Id);
                //if (changedFilm.BankAppIdentityId == User.FindFirstValue(ClaimTypes.NameIdentifier))
                //{
                   
                    changedFilm.Title = vm.Title;
                    changedFilm.StatusId = vm.SelectedStatusId;
                    changedFilm.ReleaseDate = vm.ReleaseDate;
                    changedFilm.Director = vm.Director;
                    changedFilm.GenreId = vm.SelectedGenreId;
                    changedFilm.Duration = vm.Duration;
                    changedFilm.ContentUrl = vm.ContentUrl;

                if (vm.Photo != null)
                {
                    _photoService.DeletePicture(changedFilm.PhotoUrl);
                    string uniqueFileName = _photoService.UploadPicture(vm.Photo);
                    changedFilm.PhotoUrl = "/ug-media-pics/" + uniqueFileName;
                }
                _dbContext.Films.Update(changedFilm);
                    await _dbContext.SaveChangesAsync();
                //}

                return (RedirectToAction("Index"));
            }
            [HttpGet]
            public async Task<IActionResult> Delete(int id)
            {
                Film FilmToDelete = await _dbContext.Films.FindAsync(id);
                MediaDeleteViewModel vm = new MediaDeleteViewModel()
                {
                    Id = FilmToDelete.Id,
                    Title = FilmToDelete.Title,
                    ReleaseDate = FilmToDelete.ReleaseDate
                };

                return View(vm);
            }
            [HttpPost]
            public async Task<IActionResult> ConfirmDelete(int id)
            {
                Film FilmToDelete = _dbContext.Films.Find(id);
                //if (FilmToDelete.BankAppIdentityId == User.FindFirstValue(ClaimTypes.NameIdentifier))
                //{
                    _dbContext.Films.Remove(FilmToDelete);
                    await _dbContext.SaveChangesAsync();
                //}

                return (RedirectToAction("Index"));
            }
        
    }
}
