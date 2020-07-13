using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MediaApp.Domain;
using MediaApp.Domain.MediaTypes;
using MediaApp.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediaApp.Controllers
{
    public class MediaController : Controller
    {
        private readonly MediaDb _dbContext;

        public MediaController(MediaDb dbcontext)
        {
            _dbContext = dbcontext;
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
