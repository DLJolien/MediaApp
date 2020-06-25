using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain.MediaTypes
{
    public class Film : Media
    {
        public string Director { get; set; }
        public int GenreId { get; set; }
        public FilmGenre Genre { get; set; }

        public Film()
        {
            Duration = TimeSpan.FromMinutes(120);
        }


    }
}
