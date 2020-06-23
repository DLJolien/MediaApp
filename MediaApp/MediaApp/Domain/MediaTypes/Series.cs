using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain.MediaTypes
{
    public class Series
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Broadcaster { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan DurationPerEpisode { get; set; }
        public string PhotoUrl { get; set; }
        public int NumberOfEpisodes { get; set; }
        public int NumberOfSeasons { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int GenreId { get; set; }
        public FilmGenre Genre { get; set; }

        public Series()
        {
            Id = new Guid().ToString();
            ReleaseDate = DateTime.Now;
            DurationPerEpisode = TimeSpan.FromMinutes(50);
        }
    }
}
