using MediaApp.Domain.MediaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain
{
    public class MediaReview
    {
        public int MediaId { get; set; }
        public Media Media { get; set; }
        public int ReviewId { get; set; }
        public Review Review { get; set; }
    }
}
