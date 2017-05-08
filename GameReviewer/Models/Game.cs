using System.Collections.Generic;
using System.Linq;

namespace GameReviewer.Models
{
    public class Game
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Rating
        {
            get
            {
                if (Reviews.Any())
                {
                    return Reviews.Average(e => e.Rating);
                }
                else
                {
                    return 0;
                }
            }
        }

        public List<Review> Reviews { get; set; } = new List<Review>();

        public static List<Game> GetAll()
        {
            return GlobalVariables.Games;
        }

        public static Game Get(string name)
        {
            foreach (var game in GlobalVariables.Games)
            {
                if (game.Name == name)
                    return game;
            }
            return null;
        }

        public static void Create(Game game)
        {
            GlobalVariables.Games.Add(game);
        }

        public void AddReviewToGame(Review review)
        {
            Reviews.Add(review);
        }
    }
}
