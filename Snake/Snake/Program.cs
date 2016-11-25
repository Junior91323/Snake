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
        const int Width = 100;
        const int Height = 50;

        static void Main(string[] args)
        {
            Console.Title = "Snake";

            Walls walls = new Walls(Width, Height);
            walls.Draw();

            Snake snake = new Snake(new Point(50, 25, '*', ConsoleColor.Green), 10, Direction.Right);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(Console.BufferWidth, Console.BufferHeight, '@');
            Point foodItem = foodCreator.Create(snake);
            foodItem.Drow();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    StopGame();
                    Console.ReadKey();
                    break;
                }
                if (snake.Eat(foodItem))
                {
                    foodItem = foodCreator.Create(snake);
                    foodItem.Drow();
                    snake.ShowScore();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100 - (snake.Score));
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

            }
        }

        static void StopGame()
        {
            int startX = Width / 2 - 20;
            int startY = Width / 4;
            Console.SetCursorPosition(startX, startY);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=======================================");
            Console.SetCursorPosition(startX + 15, startY + 1);
            Console.WriteLine("GAME OVER");
            Console.SetCursorPosition(startX, startY + 2);
            Console.WriteLine("=======================================");
        }
    }
}
