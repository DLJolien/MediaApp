using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Models
{
    public class MediaCreateViewModel
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; } = DateTime.Now;
        public TimeSpan Duration { get; set; }
        public int SelectedStatusId { get; set; } = 1;
        public List<SelectListItem> Statuses { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Genres { get; set; } = new List<SelectListItem>();
        public int SelectedGenreId { get; set; }
        public IFormFile Photo { get; set; }
    }
}
