using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 50);
            Console.SetBufferSize(100, 50);
            DrowFrame();

            Snake snake = new Snake(new Point(50,25,'*',ConsoleColor.Green),3,Direction.Right);
            snake.Drow();
            for (int i = 0; i<20; i++)
            {
                Thread.Sleep(300);
                snake.Move();
            }
            Console.ReadKey();
        }
        static void DrowFrame()
        {
            Line lLine = new Line(new Point(0, 1, '#', ConsoleColor.White), Console.BufferHeight-1, Line.LineType.Vertical);
            Line rLine = new Line(new Point(Console.BufferWidth-1, 1, '#', ConsoleColor.White), Console.BufferHeight-1, Line.LineType.Vertical);
            Line tLine = new Line(new Point(1, 1, '#', ConsoleColor.White), Console.BufferWidth-1, Line.LineType.Horizontal);
            Line bLine = new Line(new Point(0, Console.BufferHeight-1, '#', ConsoleColor.White), Console.BufferWidth, Line.LineType.Horizontal);

            lLine.Drow();
            rLine.Drow();
            tLine.Drow();
            bLine.Drow();
        }
    }
}
