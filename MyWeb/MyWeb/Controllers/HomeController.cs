using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MyWeb.Models;
using MyWeb.Models.ModelViews;

namespace MyWeb.Controllers
{
    public class HomeController : Controller
    {
        AlbumDbContext DB = new AlbumDbContext();
        public ActionResult Index()
        {
            List<AlbumView> viewEntityCollection = new List<AlbumView>();
            foreach (var a in DB.Albums)
            {
                AlbumView viewEntity = new AlbumView();
                viewEntity.Name = a.Name;
                viewEntity.CountOfSongs = a.CountOfSongs;
                viewEntity.DateOfRelease = a.DateOfRelease;
                viewEntity.NameOfSinger = a.Singer.Name;
                viewEntity.DateOfBirth = a.Singer.DateOfBirth;
                viewEntityCollection.Add(viewEntity);
            }
            ViewBag.Albums = viewEntityCollection;

            return View();
        }



    }

}