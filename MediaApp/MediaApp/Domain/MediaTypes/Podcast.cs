using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain.MediaTypes
{
    public class Podcast
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<string> Speakers { get; set; }
        public string Subject { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan Duration { get; set; }
        public string PhotoUrl { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int GenreId { get; set; }
        public AudioGenre Genre { get; set; }

        public Podcast()
        {
            Id = new Guid().ToString();
            ReleaseDate = DateTime.Now;
            Duration = TimeSpan.FromMinutes(3);
        }
    }
}
