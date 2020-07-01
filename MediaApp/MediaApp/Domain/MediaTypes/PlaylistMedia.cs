using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain.MediaTypes
{
    public class PlaylistMedia
    {
        public int PlaylistId { get; set; }
        public Playlist<Media> Playlist { get; set; }
        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}
