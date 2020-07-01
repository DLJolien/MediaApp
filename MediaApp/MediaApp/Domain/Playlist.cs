using MediaApp.Domain.MediaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain
{
    public class Playlist<Media>
    {
        public int Id { get; set; }
        public bool Public { get; set; }
        public string Title { get; set; }
        public ICollection<PlaylistMedia> PlaylistMedias { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public TimeSpan Duration { get; set; }
    }
}

