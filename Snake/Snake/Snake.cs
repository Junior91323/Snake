using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    
    class Snake : Figure
    {
        public int Score
        {
            get { return _PointList.Count - StartLenght; }
        }
        private Direction Direction;
        private static int StartLenght;
        public Snake(Point tail, int lenght, Direction direction)
        {
            Direction = direction;
            StartLenght = lenght;
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
                newHead.Move(1, Direction);
                
            }
            return newHead;
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow: this.Direction = Direction.Left; break;
                case ConsoleKey.RightArrow: this.Direction = Direction.Right; break;
                case ConsoleKey.UpArrow: this.Direction = Direction.Top; break;
                case ConsoleKey.DownArrow: this.Direction = Direction.Bottom; break;
            }
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.Symbol = head.Symbol;
                food.Color = head.Color;
                _PointList.Add(food);
                return true;
            }

            return false;
        }

        public void ShowScore()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_PointList.Count - StartLenght);
        }
    }
}
