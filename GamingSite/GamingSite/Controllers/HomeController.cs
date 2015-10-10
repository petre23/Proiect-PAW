using GamingSite.Models;
using GamingSite.Models.ModelBL;
using GamingSite.Models.ModelBO;
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
            List<Game> gameList = new List<Game>();
            GameBL gameLogic = new GameBL();
            gameList = gameLogic.GetAllGames();

            return View(gameList);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}