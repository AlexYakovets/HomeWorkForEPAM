using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWeb.Models
{
    public class Album
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfRelease { get; set; }
        public int CountOfSongs { get; set; }
        public int SingerId { get; set; }


        //public Album()
        //{
        //    Singer = new Singer();
        //}


    }
}