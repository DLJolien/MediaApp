using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain.MediaTypes
{
    public abstract class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan Duration { get; set; }
        public string PhotoUrl { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public string ContentUrl { get; set; }
        public string Accessibility { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public ICollection<PlaylistMedia> PlaylistMedias { get; set; }
        public ICollection<Review> Reviews { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public Media()
        {
            ReleaseDate = DateTime.Now;
        }
       
    }
}
