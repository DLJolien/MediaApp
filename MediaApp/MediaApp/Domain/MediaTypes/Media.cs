using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain.MediaTypes
{
    public abstract class Media
    {
        private string _contentUrl;
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan Duration { get; set; }
        public string PhotoUrl { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public string ContentUrl { get; set; }
        public string Accessibility { get; set; }
        public ICollection<MediaReview> MediaReviews { get; set; }

        public ICollection<MediaComment> MediaComments { get; set; }
        public Media()
        {
            ReleaseDate = DateTime.Now;
        }
       
    }
}
