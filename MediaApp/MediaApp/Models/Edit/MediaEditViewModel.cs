using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Models.Edit
{
    public class MediaEditViewModel
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Title required to fill in.")]
        [MaxLength(40, ErrorMessage = "Only 40 chars allowed")]
        public string Title { get; set; }

        [Range(typeof(DateTime), "01/01/1910", "01/01/2040")]
        public DateTime ReleaseDate { get; set; }
        public TimeSpan Duration { get; set; }
        public List<SelectListItem> Genres { get; set; } = new List<SelectListItem>();
        public int SelectedGenreId { get; set; }
        public string Public { get; set; } = "Public";
        public List<SelectListItem> PublicStatus = new List<SelectListItem>(){
            new SelectListItem(){ Value = "Public", Text="Public"},
            new SelectListItem(){ Value = "Private", Text="Private"}};
        public IFormFile Photo { get; set; }
        public string PhotoUrl { get; set; }
        public string ContentUrl { get; set; }
    }
}
