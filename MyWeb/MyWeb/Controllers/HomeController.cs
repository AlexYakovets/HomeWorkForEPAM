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
    {   AlbumDbContext DB = new AlbumDbContext();
        public ActionResult Index()
        {
            List<AlbumView> viewEntityCollection = new List<AlbumView>();
            //foreach (var s in DB.Singers)
            //{
            //    AlbumView viewEntity = new AlbumView();
            //    viewEntity.NameOfSinger = s.Name;
            //    viewEntity.DateOfBirth = s.DateOfBirth;
            //    var albums = from a in DB.Albums
            //                 where a.SingerId == s.Id
            //                 select a;
            //    //select new { Id = a.Id, Name = a.Name, DateOfRelease = a.DateOfRelease, };  
            //    foreach (var a in albums)
            //    {
            //        viewEntity.Id = a.Id;
            //        viewEntity.DateOfRelease = a.DateOfRelease;
            //        viewEntity.CountOfSongs = a.CountOfSongs;
            //        viewEntity.Name = a.Name;
            //        viewEntityCollection.Add(viewEntity);

            //    }
            //}
            var Singers = DB.Singers.ToList();
            foreach (var s in Singers)
            {
                
                var Albums = DB.Albums.ToList();
                var albums = from a in Albums
                             where a.SingerId == s.Id
                             select a;
                foreach (var a in albums)
                {
                    AlbumView viewEntity = new AlbumView();
                    viewEntity.NameOfSinger = s.Name;
                    viewEntity.DateOfBirth = s.DateOfBirth;
                    viewEntity.Id = a.Id;
                    viewEntity.DateOfRelease = a.DateOfRelease;
                    viewEntity.CountOfSongs = a.CountOfSongs;
                    viewEntity.Name = a.Name;
                    viewEntityCollection.Add(viewEntity);

                }         
            }




            ViewBag.Title = DB.Singers.Count();
            ViewBag.Albums = viewEntityCollection;

            return View();
        }



    }

}