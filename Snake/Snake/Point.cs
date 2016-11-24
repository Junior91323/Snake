using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        #region Fields
        private int _X;
        private int _Y;
        private char _Symbol;
        private ConsoleColor _Color;
        #endregion

        #region Properties
        public int X
        {
            get
            {
                return _X;
            }
        }
        public int Y
        {
            get
            {
                return _Y;
            }
        }
        public char Symbol
        {
            get
            {
                return _Symbol;
            }
        }
        public ConsoleColor Color
        {
            get
            {
                return _Color;
            }
        }
        #endregion

        public Point(int x, int y, char symbol, ConsoleColor color)
        {
            this._X = x;
            this._Y = y;
            this._Symbol = symbol;
            this._Color = color;
        }
        public Point(Point point)
        {
            this._X = point.X;
            this._Y = point.Y;
            this._Symbol = point.Symbol;
            this._Color = point.Color;
        }
        public void Drow()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.ForegroundColor = this.Color;
            Console.Write(this.Symbol);
        }
        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Left: this._X = this._X - offset; break;
                case Direction.Right: this._X = this._X + offset; break;
                case Direction.Top: this._Y = this._Y - offset; break;
                case Direction.Bottom: this._Y = this._Y + offset; break;
            }
        }
    }
}
