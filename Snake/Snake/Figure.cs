using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> _PointList;

        public void Drow()
        {
            foreach (Point point in this._PointList)
            {
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = point.Color;
                Console.Write(point.Symbol);
            }
        }
    }
}
