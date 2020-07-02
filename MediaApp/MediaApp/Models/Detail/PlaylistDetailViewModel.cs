using MediaApp.Domain;
using MediaApp.Domain.MediaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Models.Detail
{
    public class PlaylistDetailViewModel
    {
        public int Id { get; set; }
        public bool Public { get; set; }
        public string Title { get; set; }
        public List<PlaylistMedia> PlaylistMedias { get; set; } = new List<PlaylistMedia>();
        public User User { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime LastModified { get; set; }
    }
}
