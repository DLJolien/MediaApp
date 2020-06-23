using MediaApp.Domain.MediaTypes;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MediaApp.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        public PhotoService(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }
        public void DeletePicture(string url)
        {
            if (url.StartsWith("/"))
            {
                url = url.Substring(1);
            }

            string pathName = Path.Combine(_hostEnvironment.WebRootPath, url);
            File.Delete(pathName);
        }

        public string UploadPicture(IFormFile photo)
        {
            string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(photo.FileName);
            string pathName = Path.Combine(_hostEnvironment.WebRootPath, "ug-media-pics");
            string fileNameWithPath = Path.Combine(pathName, uniqueFileName);

            using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
            {
                photo.CopyTo(stream);
            }
            return uniqueFileName;
        }
        public void AssignPicToMedia(Media media)
        {
            string pathToPicture = string.Empty;
            if (media.GetType() == typeof(Film))
            {
                pathToPicture = "film.png";
            }
            else
            {
                pathToPicture = "music.jpg";
            }

            media.PhotoUrl = "/icons/" + pathToPicture;
        }

     
        }
    }
}
