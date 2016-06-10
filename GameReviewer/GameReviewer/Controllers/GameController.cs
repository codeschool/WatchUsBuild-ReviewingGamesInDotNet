using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GameReviewer.Models;

namespace GameReviewer.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            return View(Game.GetAll());
        }

        // GET: Game/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        // POST: Game/Create
        [HttpPost]
        public ActionResult Create(Game game)
        {
            try
            {
                Game.Create(game);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}