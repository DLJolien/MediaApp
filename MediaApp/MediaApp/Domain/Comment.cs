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
        public DateTime PublishedDate { get; set; }
        public Media Media { get; set; }
        public int MediaId { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public bool IsApproved { get; set; } = false;
    }
}
