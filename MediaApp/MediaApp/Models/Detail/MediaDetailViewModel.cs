﻿using MediaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Models
{
    public class MediaDetailViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan Duration { get; set; }
        public string PhotoUrl { get; set; }
        public string Genre { get; set; }
        public string ContentUrl { get; set; }
        public bool Public { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public string InputComment { get; set; }

    }
}
