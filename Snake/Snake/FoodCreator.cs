using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int MapWidth { get; set; }
        int MapHeight { get; set; }
        char Symbol { get; set; }

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char symbol)
        {
            this.MapWidth = mapWidth;
            this.MapHeight = mapHeight;
            this.Symbol = symbol;
        }

        public Point Create(Figure figure)
        {
            int x = random.Next(3, this.MapWidth - 3);
            int y = random.Next(3, this.MapHeight - 3);
            Point food = new Point(x, y, this.Symbol, ConsoleColor.Yellow);
            if (figure.IsHit(food))
            {
                food.Clear();
                Create(figure);
            }

            return food;
        }
    }
}
