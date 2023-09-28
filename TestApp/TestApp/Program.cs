using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    { 

        static void Main(string[] args)
        {
            Walls wall = new Walls(Console.WindowWidth, Console.WindowHeight);
            wall.Draw();
            Console.ReadKey();
        }
    }
}