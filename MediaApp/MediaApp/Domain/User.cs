using MediaApp.Domain.MediaTypes;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain
{
    public class User : IdentityUser
    {
        public string PhotoUrl { get; set; }
        public int BookmarkedFilmsId { get; set; } = 0;
        public int BookmarkedMusicId { get; set; } = 0;
        public int BookmarkedPodcastId { get; set; } = 0;
        public int BookmarkedSeriesId { get; set; } = 0;
    }
}
