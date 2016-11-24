using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{

    class Snake : Figure
    {
        public Snake(Point tail, int lenght, Direction direction)
        {
            _PointList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point point = new Point(tail);
                point.Move(i, direction);
                _PointList.Add(point);

            }
        }
    }
}
