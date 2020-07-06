using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain.MediaTypes
{
    public class MediaSeen
    {
        public int MediaId { get; set; }
        public int UserId { get; set; }
        public bool Seen { get; set; }
    }
}
