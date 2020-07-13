using MediaApp.Domain.MediaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Models.Create
{
    public class PlaylistManageItemsViewModel
    {
        public int PlaylistId { get; set; }
        public List<Media> AllItemsInLibrary { get; set; } = new List<Media>();
        public List<Media> AlreadyIncluded { get; set; } = new List<Media>();
        public ICollection<PlaylistMedia> PlaylistMedias { get; set; }
        public string Type { get; set; }

    }
}
