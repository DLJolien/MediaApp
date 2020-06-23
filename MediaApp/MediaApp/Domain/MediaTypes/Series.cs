using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain.MediaTypes
{
    public class Series : Media
    {
        public string Broadcaster { get; set; }
        public int NumberOfEpisodes { get; set; }
        public int NumberOfSeasons { get; set; }
        public int GenreId { get; set; }
        public FilmGenre Genre { get; set; }

        public Series()
        {
            Duration = TimeSpan.FromMinutes(50)*NumberOfEpisodes*NumberOfSeasons;
        }
    }
}
