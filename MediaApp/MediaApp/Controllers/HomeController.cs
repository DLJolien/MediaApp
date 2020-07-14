using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediaApp.Models;
using Microsoft.AspNetCore.Authorization;
using MediaApp.Domain;
using Microsoft.EntityFrameworkCore;
using MediaApp.Models.Index;

namespace MediaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MediaDb _dbContext;

        public HomeController(ILogger<HomeController> logger, MediaDb dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var filmsMostCommented = _dbContext.Films
                .Include(x => x.Comments)
                .Where(media => media.Public == true)
                .OrderByDescending(media => media.Comments.Count).Skip(0).Take(4).ToList();

            var podcastsMostCommented = _dbContext.Podcasts
                .Include(x => x.Comments)
                .Where(media => media.Public == true)
                .OrderByDescending(media => media.Comments.Count).Skip(0).Take(4).ToList();

            var seriesMostCommented = _dbContext.Series
                .Include(x => x.Comments)
                .Where(media => media.Public == true)
                .OrderByDescending(media => media.Comments.Count).Skip(0).Take(4).ToList();

            var musicMostCommented = _dbContext.Music
                .Include(x => x.Comments)
                .Where(media => media.Public == true)
                .OrderByDescending(media => media.Comments.Count).Skip(0).Take(4).ToList();

            TrendingListViewModel vm = new TrendingListViewModel()
            {
                MostCommentedFilms = filmsMostCommented,
                MostCommentedPodcasts = podcastsMostCommented,
                MostCommentedSeries = seriesMostCommented,
                MostCommentedMusic = musicMostCommented
            };
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
