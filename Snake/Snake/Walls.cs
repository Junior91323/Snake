using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> _Walls;

        public Walls(int mapWidth, int mapHeight)
        {
            _Walls = new List<Figure>();

            Console.SetWindowSize(mapWidth, mapHeight);
            Console.SetBufferSize(mapWidth, mapHeight);

            Line lLine = new Line(new Point(0, 2, '#', ConsoleColor.White), Console.BufferHeight - 3, Line.LineType.Vertical);
            Line rLine = new Line(new Point(Console.BufferWidth - 1, 2, '#', ConsoleColor.White), Console.BufferHeight - 3, Line.LineType.Vertical);
            Line tLine = new Line(new Point(0, 2, '#', ConsoleColor.White), Console.BufferWidth, Line.LineType.Horizontal);
            Line bLine = new Line(new Point(0, Console.BufferHeight - 1, '#', ConsoleColor.White), Console.BufferWidth, Line.LineType.Horizontal);

            _Walls.Add(lLine);
            _Walls.Add(rLine);
            _Walls.Add(tLine);
            _Walls.Add(bLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (Figure item in _Walls)
            {
                if (item.IsHit(figure))
                    return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach (Figure item in _Walls)
            {
                item.Drow();
            }
        }
    }
}
