using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyWeb.Models
{
    public class AlbumDbContext:DbContext
    {
        public AlbumDbContext() : base("name=Album")
        {
            //Database.SetInitializer<AlbumDbContext>(new AlbumDbInitializer());
            Database.SetInitializer<AlbumDbContext>(null);

        }
        public DbSet<Album> Albums { get; set; }

        public DbSet<Singer> Singers { get; set; }

    }
}