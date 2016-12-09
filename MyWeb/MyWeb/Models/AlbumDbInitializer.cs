using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Security.Cryptography;

namespace MyWeb.Models
{
    public class AlbumDbInitializer:DropCreateDatabaseAlways<AlbumDbContext>
    {
        
        protected override void Seed(AlbumDbContext context)
        {
            Singer s1 = new Singer { Id = 1, DateOfBirth = new DateTime(1994, 1, 21), Name = "Biber" };
            Singer s2 = new Singer {Id = 2, DateOfBirth = new DateTime(1942, 11, 23), Name = "Aquarell"};
            context.Albums.Add(new Album {Id=1,CountOfSongs = 14,DateOfRelease = new DateTime(1944, 1, 25), Name = "Vonuchaya pil",Singer = s1});
            context.Albums.Add(new Album { Id = 2, CountOfSongs = 19, DateOfRelease = new DateTime(1956, 1, 25), Name = "Koluchayа борода", Singer = s2 });
            context.Albums.Add(new Album { Id = 2, CountOfSongs = 12, DateOfRelease = new DateTime(2008,3, 25), Name = "Gay album namba wan", Singer = s2 });
            context.Singers.Add(s1);
            context.Singers.Add(s2);
            base.Seed(context);
        }
    }
}