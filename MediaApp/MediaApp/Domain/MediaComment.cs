using MediaApp.Domain.MediaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain
{
    public class MediaComment
    {
        public int MediaId { get; set; }
        public Media Media { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
