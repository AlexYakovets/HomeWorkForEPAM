using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Web.Management;

namespace MyWeb.Models
{
    public class AlbumDbInitializer:DropCreateDatabaseAlways<AlbumDbContext>
    {
        protected override void Seed(AlbumDbContext context)
        {
            //Album a1=(new Album { Id = 1, CountOfSongs = 14, DateOfRelease = new DateTime(1944, 1, 25), Name = "Vonuchaya pil1"});
            //Album a2=(new Album { Id = 2, CountOfSongs = 19, DateOfRelease = new DateTime(1956, 1, 25), Name = "Koluchayа борода2"});
            //Album a3=(new Album { Id = 2, CountOfSongs = 12, DateOfRelease = new DateTime(2008, 3, 25), Name = "Gay album namba wan3"});
            //List<Album> ListAlbum=new List<Album>();
            //List<Album> ListAlbum2 = new List<Album>();
            //ListAlbum.Add(a1);
            //Singer s1 = new Singer{Id = 1, DateOfBirth = new DateTime(1994, 1, 21), Name = "Biber", Albums = ListAlbum};
            //ListAlbum2.Add(a2);
            //ListAlbum2.Add(a3);
            //Singer s2 = new Singer {Id = 2, DateOfBirth = new DateTime(1942, 11, 23), Name = "Aquarell",Albums = ListAlbum2};
            ////context.Albums.Add(new Album {Id=1,CountOfSongs = 14,DateOfRelease = new DateTime(1944, 1, 25), Name = "Vonuchaya pil",Singer = s1});
            ////context.Albums.Add(new Album { Id = 2, CountOfSongs = 19, DateOfRelease = new DateTime(1956, 1, 25), Name = "Koluchayа борода", Singer = s2 });
            ////context.Albums.Add(new Album { Id = 2, CountOfSongs = 12, DateOfRelease = new DateTime(2008,3, 25), Name = "Gay album namba wan", Singer = s2 });
            //context.Singers.Add(s1);
            //context.Singers.Add(s2);
            //base.Seed(context);
        }
    }
}