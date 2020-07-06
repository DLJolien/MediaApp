using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain.MediaTypes
{
    public class MediaSeen
    {
        public int MediaId { get; set; }
        public Media Media { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
