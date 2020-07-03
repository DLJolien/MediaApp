using MediaApp.Domain.MediaTypes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Models
{
    //public class MediaPaginatedListViewModel: PaginatedList<Media>
    //{
    //    public List<MediaListViewModel> ListItems { get; set; }
    //    public MediaPaginatedListViewModel(List<Media> items, int count, int pageIndex, int pageSize) : base(items, count, pageIndex, pageSize)
    //    {
    //        foreach (Media item in items)
    //        {
    //            MediaListViewModel vm = new MediaListViewModel()
    //            {
    //                Id = item.Id,
    //                Title = item.Title,
    //                ReleaseDate = item.ReleaseDate,
    //                PhotoUrl = item.PhotoUrl
    //            };
    //            ListItems.Add(vm);
    //        }
    //    }
    //    public override async Task<PaginatedList<Media>> CreateAsync(IQueryable<Media> source, int pageIndex, int pageSize)
    //    {
    //        var count = await source.CountAsync();
    //        var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
    //        return new MediaPaginatedListViewModel(items, count, pageIndex, pageSize);
    //    }
    //}
}
