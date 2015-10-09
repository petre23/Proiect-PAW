using GamingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamingSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Game";
            Game gameInfo = new Game();
            gameInfo.Name = "Call Of Duty Black Ops 3";
            gameInfo.Genre = "FPS";
            gameInfo.Rating = (float)8.9;
            gameInfo.ReleaseYear = 2015;
            gameInfo.ImageUrl = "http://blogs-images.forbes.com/insertcoin/files/2015/08/black-ops-3-beta1.jpg";

            return View(gameInfo);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}