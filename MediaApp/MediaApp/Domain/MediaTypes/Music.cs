using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain.MediaTypes
{
    public class Music : Media
    {

        public string Singer { get; set; }
        public int GenreId { get; set; }
        public MusicGenre Genre { get; set; }

        public Music()
        {
            Duration = TimeSpan.FromMinutes(3);
        }

    }
}
