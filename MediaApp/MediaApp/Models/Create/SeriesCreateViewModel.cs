using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Models.Create
{
    public class SeriesCreateViewModel : MediaCreateViewModel
    {
        public string Broadcaster { get; set; }
        public int NumberOfEpisodes { get; set; }
        public int NumberOfSeasons { get; set; }
    }
}
