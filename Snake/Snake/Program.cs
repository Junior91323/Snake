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

            Snake snake = new Snake(new Point(50, 25, '*', ConsoleColor.Green), 10, Direction.Right);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(Console.BufferWidth, Console.BufferHeight, '@');
            Point foodItem = foodCreator.Create();
            foodItem.Drow();

            while (true)
            {
                if (snake.Eat(foodItem))
                {
                    foodItem = foodCreator.Create();
                    foodItem.Drow();
                    snake.ShowScore();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100-snake.Score);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

            }
        }
        static void DrowFrame()
        {
            Line lLine = new Line(new Point(0, 2, '#', ConsoleColor.White), Console.BufferHeight - 3, Line.LineType.Vertical);
            Line rLine = new Line(new Point(Console.BufferWidth - 1, 2, '#', ConsoleColor.White), Console.BufferHeight - 3, Line.LineType.Vertical);
            Line tLine = new Line(new Point(0, 2, '#', ConsoleColor.White), Console.BufferWidth, Line.LineType.Horizontal);
            Line bLine = new Line(new Point(0, Console.BufferHeight - 1, '#', ConsoleColor.White), Console.BufferWidth, Line.LineType.Horizontal);

            lLine.Drow();
            rLine.Drow();
            tLine.Drow();
            bLine.Drow();
        }
    }
}
