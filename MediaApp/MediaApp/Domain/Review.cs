using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain
{
    public class Review
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime PublishedDate { get; set; }

        public ICollection<Review> Reviews{ get; set; }
    }
}
