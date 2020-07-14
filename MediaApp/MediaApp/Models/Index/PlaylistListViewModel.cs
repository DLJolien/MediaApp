using MediaApp.Domain;
using MediaApp.Domain.MediaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Models.Index
{
    public class PlaylistListViewModel
    {
        public IEnumerable<Playlist<Media>> Playlists { get; set; }
        public ICollection<PlaylistMedia> PlaylistMedias { get; set; }
        public string MediaType { get; set; }
    }
}
