using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MediaApp.Models
{
    public class MediaCreateViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Title required to fill in.")]
        [MaxLength(40, ErrorMessage = "Only 40 chars allowed")]
        public string Title { get; set; }

        [Range(typeof(DateTime), "01/01/1910", "01/01/2040")]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;
        public TimeSpan Duration { get; set; }
        public List<SelectListItem> Genres { get; set; } = new List<SelectListItem>();
        public bool Public { get; set; }
        public string ContentUrl { get; set; }
        public int SelectedGenreId { get; set; }
        public IFormFile Photo { get; set; }
    }
}
