using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWeb.Models.ModelViews
{
    public class AlbumView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfRelease { get; set; }
        public int CountOfSongs { get; set; }
        public string NameOfSinger { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}