using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWeb.Models
{
    public class Singer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Album> Albums { get; set; }


    }
}