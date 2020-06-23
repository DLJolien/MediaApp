using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain.MediaTypes
{
    public class Podcast : Media
    {
        public List<string> Speakers { get; set; }
        public int GenreId { get; set; }
        public AudioGenre Genre { get; set; }

        public Podcast()
        {
            Duration = TimeSpan.FromMinutes(60);
        }
    }
}
