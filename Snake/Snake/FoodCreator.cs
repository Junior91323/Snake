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

        public Point Create()
        {
            int x = random.Next(2, this.MapWidth - 2);
            int y = random.Next(2, this.MapHeight - 2);
            return new Point(x, y, this.Symbol, ConsoleColor.Yellow);
        }
    }
}
