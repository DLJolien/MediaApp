using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Models.Detail
{
    public class SeriesDetailViewModel : MediaDetailViewModel
    {
        public string Broadcaster { get; set; }
        public int NumberOfEpisodes { get; set; }
        public int NumberOfSeasons { get; set; }
    }
}
