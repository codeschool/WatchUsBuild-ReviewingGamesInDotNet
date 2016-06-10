using System.Collections.Generic;

namespace GameReviewer.Models
{
    public class Game
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }

        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
