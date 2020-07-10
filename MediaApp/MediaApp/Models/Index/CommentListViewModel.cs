using MediaApp.Domain;
using MediaApp.Domain.MediaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Models.Index
{
    public class CommentListViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDate { get; set; }
        public string UserName { get; set; }
        public string MediaTitle { get; set; }
        public int MediaId { get; set; }
        public bool IsApproved { get; set; }
    }
}
