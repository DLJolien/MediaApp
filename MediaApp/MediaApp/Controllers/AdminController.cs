using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaApp.Domain;
using MediaApp.Models.Index;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediaApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly MediaDb _dbContext;

        public AdminController(MediaDb dbcontext)
        {
            _dbContext = dbcontext;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var comments = await _dbContext.Comments.Include(x => x.User).Include(x => x.Media).Where(comment => comment.IsApproved == false).ToListAsync();

            List<CommentListViewModel> vmList = comments.Select(comment => new CommentListViewModel()
            {
                Id = comment.Id,
                Description = comment.Description,
                UserName = comment.User.UserName,
                MediaId = comment.MediaId,
                MediaTitle = comment.Media.Title,
                PublishedDate = comment.PublishedDate
            }).ToList();
            return View(vmList);
        }

        public async Task RemoveComment(int id)
        {
            Comment comment = await _dbContext.Comments.Where(x => x.Id == id).FirstOrDefaultAsync();
            _dbContext.Comments.Remove(comment);
            await _dbContext.SaveChangesAsync();
        }
        public async Task ApproveComment(int id)
        {
            _dbContext.Comments.Where(x => x.Id == id).FirstOrDefaultAsync().Result.IsApproved = true;
            await _dbContext.SaveChangesAsync();
        }
    }
}
