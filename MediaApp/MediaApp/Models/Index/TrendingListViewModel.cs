using MediaApp.Domain.MediaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Models.Index
{
    public class TrendingListViewModel
    {
        public List<Film> MostCommentedFilms { get; set; }
        public List<Podcast> MostCommentedPodcasts { get; set; }
        public List<Music> MostCommentedMusic { get; set; }
        public List<Series> MostCommentedSeries { get; set; }
    }
}
