using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameReviewer.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GameReviewer.Controllers
{
    public class ReviewController : Controller
    {
        // GET: /<controller>/
        public IActionResult Create(string game)
        {
            ViewData["Game"] = game;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Review review, string gameName)
        {
            var game = Game.Get(gameName);
            game.AddReviewToGame(review);
            return RedirectToAction("Index", "Game");
        }
    }
}
