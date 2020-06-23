using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Models
{
    public class FilmListViewModel 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PhotoUrl { get; set; }
        public string Status { get; set; }
        public string Genre { get; set; }

    }
}
