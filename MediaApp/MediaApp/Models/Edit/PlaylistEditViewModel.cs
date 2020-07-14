using MediaApp.Domain;
using MediaApp.Domain.MediaTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Models.Edit
{
    public class PlaylistEditViewModel
    {
        public int Id { get; set; }
        public bool Public { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Title required to fill in.")]
        [MaxLength(40, ErrorMessage = "Only 40 chars allowed")]
        public string Title { get; set; }
        public string MediaType { get; set; }
    }
}
