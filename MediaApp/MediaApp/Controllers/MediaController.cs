using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MediaApp.Domain;
using MediaApp.Domain.MediaTypes;
using MediaApp.Models;
using MediaApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediaApp.Controllers
{
    public class MediaController : Controller
    {
        private readonly MediaDb _dbContext;
        private readonly IPhotoService _photoService;

        public MediaController(MediaDb dbcontext, IPhotoService photoService)
        {
            _dbContext = dbcontext;
            _photoService = photoService;
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Media mediaToDelete = await _dbContext.Media.FindAsync(id);
            if (User.IsInRole("Admin") || mediaToDelete.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                MediaDeleteViewModel vm = new MediaDeleteViewModel()
                {
                    Id = mediaToDelete.Id,
                    Title = mediaToDelete.Title,
                    ReleaseDate = mediaToDelete.ReleaseDate
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
            Media mediaToDelete = _dbContext.Media.Find(id);
            if (User.IsInRole("Admin") || mediaToDelete.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                if (!String.IsNullOrEmpty(mediaToDelete.PhotoUrl))
                {
                    _photoService.DeletePicture(mediaToDelete.PhotoUrl);
                }
                _dbContext.Media.Remove(mediaToDelete);
                await _dbContext.SaveChangesAsync();
            }

            return (RedirectToAction("Index","Home"));
        }
        public async Task RemoveFromSeen(int id)
        {
            User user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));

            MediaSeen mediaSeen = await _dbContext.MediaSeens.Where(x => x.MediaId == id && x.UserId == user.Id).FirstOrDefaultAsync();

            _dbContext.MediaSeens.Remove(mediaSeen);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddToSeen(int id)
        {
            User user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));
            _dbContext.MediaSeens.Add(new MediaSeen() { MediaId = id, UserId = user.Id });
            await _dbContext.SaveChangesAsync();
        }
        public async Task Comment(int Id, string comment)
        {
            _dbContext.Comments.Add(new Comment()
            {
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                Description = comment,
                PublishedDate = DateTime.Now,
                MediaId = Id

            });
            await _dbContext.SaveChangesAsync();
        }
    }
}
