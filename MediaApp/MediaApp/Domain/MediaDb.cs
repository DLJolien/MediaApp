using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain
{
    public class MediaDb : DbContext
    {
        public MediaDb(DbContextOptions<MediaDb> options) : base(options)
        {
            
        }
    }
}
