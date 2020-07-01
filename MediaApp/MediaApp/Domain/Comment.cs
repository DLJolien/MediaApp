using MediaApp.Domain.MediaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain
{
    public class Comment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime PublishedDate { get; set; }
        public Media Media { get; set; }
    }
}
