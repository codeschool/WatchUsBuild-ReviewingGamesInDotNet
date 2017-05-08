using GameReviewer.Models;
using Microsoft.AspNetCore.Mvc;

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
