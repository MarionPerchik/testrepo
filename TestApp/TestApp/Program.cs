using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        static void Main(string[] args)
        {
            /*Point p1 = new Point(2, 2, '*');
            p1.Draw();
            Point p2 = new Point(2, 2, '*');
            p2.Draw();
            if (p1.IsHit(p2))
            {
                Console.SetCursorPosition(0, 6);
                Console.WriteLine("Точки пересекаются");
            }
            else
            {
                Console.SetCursorPosition(0, 6);
                Console.WriteLine("Точки не пересекаются");
            }*/
            HorizontalLine h1 = new HorizontalLine(3, 10, 3, '*');
            h1.Draw();
            VerticalLine v1 = new VerticalLine(0,7,12,'*');
            v1.Draw();
            if (h1.IsHit(v1))
            {
                Console.SetCursorPosition(0, 15);
                Console.WriteLine("Линии пересекаются");
            }
            else
            {
                Console.SetCursorPosition(0, 15);
                Console.WriteLine("Линии не пересекаются");
            }
            Console.ReadKey();
        }
    }
}