using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain.MediaTypes
{
    public class Podcast : Media
    {
        public string Organisation { get; set; }
        public int GenreId { get; set; }
        public PodcastGenre Genre { get; set; }

        public Podcast()
        {
            Duration = TimeSpan.FromMinutes(60);
        }
    }
}
