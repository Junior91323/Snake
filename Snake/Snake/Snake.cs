using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{

    class Snake : Figure
    {
        Direction _Direction;

        public Snake(Point tail, int lenght, Direction direction)
        {
            _Direction = direction;
            _PointList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point point = new Point(tail);
                point.Move(i, direction);
                _PointList.Add(point);
            }
        }

        public void Move()
        {
            Point tail = _PointList.FirstOrDefault();
            if (tail != null)
            {
                _PointList.Remove(tail);
                Point head = GetNextPoint();
                _PointList.Add(head);

                tail.Clear();
                head.Drow();
            }
        }

        private Point GetNextPoint()
        {
            Point newHead = null;
            Point head = _PointList.LastOrDefault();
            if (head != null)
            {
                newHead = new Point(head);
                newHead.Move(1, _Direction);
                
            }
            return newHead;
        }
    }
}
