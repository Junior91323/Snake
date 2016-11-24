﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
    {
        private short X { get; set; }
        private short Y { get; set; }
        private char Symbol { get; set; }
        private ConsoleColor Color { get; set; }

        public Point(short x, short y, char symbol, ConsoleColor color)
        {
            this.X = x;
            this.Y = y;
            this.Symbol = symbol;
            this.Color = color;
        }
        public void Drow()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.ForegroundColor = this.Color;
            Console.Write(this.Symbol);
        }
    }
}
