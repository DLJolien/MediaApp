using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Models.Index
{
    public class BookmarkListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PhotoUrl { get; set; }
        public bool Seen { get; set; } = false;
        public string Status { get; set; }
        public bool Bookmarked { get; set; } = true;
    }
}
