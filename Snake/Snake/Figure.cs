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

        internal virtual bool IsHit(Figure figure)
        {
            if (_PointList != null)
            {
                foreach (Point point in this._PointList)
                {
                    if (figure.IsHit(point))
                        return true;
                }
            }
            return false;
        }

        internal bool IsHit(Point point)
        {
            if (_PointList != null)
            {
                foreach (Point item in this._PointList)
                {
                    if (item.IsHit(point))
                        return true;
                }
            }
            return false;
        }
    }
}
