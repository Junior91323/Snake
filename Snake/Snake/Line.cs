using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Line : Figure
    {
        public enum LineType
        {
            Horizontal,
            Vertical
        }

        public Line(Point start, int length, LineType type)
        {
            if (start != null)
            {
                InitPointList(start, length, type);
            }
        }

        private void InitPointList(Point start, int length, LineType type)
        {
            this._PointList = new List<Point>();
            switch (type)
            {
                case LineType.Horizontal:
                    {
                        for (int x = start.X; x < start.X + length; x++)
                        {
                            Point point = new Point(x, start.Y, start.Symbol, start.Color);
                            this._PointList.Add(point);
                        }
                        break;
                    }
                case LineType.Vertical:
                    {
                        for (int y = start.Y; y < start.Y + length; y++)
                        {
                            Point point = new Point(start.X, y, start.Symbol, start.Color);
                            this._PointList.Add(point);
                        }
                        break;
                    }
            }
        }
    }
}
