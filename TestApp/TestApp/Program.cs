using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestApp
{
    class Program
    { 

        static void Main(string[] args)
        {
            Walls walls = new Walls(Console.WindowWidth, Console.WindowHeight);
            walls.Draw();
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                snake.Move();
                Thread.Sleep(100);
            }
        }
    }
}