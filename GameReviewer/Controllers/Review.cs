using GameReviewer.Models;
using Microsoft.AspNetCore.Mvc;

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
