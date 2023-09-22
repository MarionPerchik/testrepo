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
            int xleft = 0;
            int xright = 0;
            int y = 0;
            char sym = ' ';
            Console.WriteLine("Если вы хотите прекратить рисовать нажмите пробел");
            while (true)
            {
                Console.Write("Какой символ хотите использовать? Чтобы выбрать нажмите его на клавиатуре: ");
                sym = Convert.ToChar(Console.ReadLine());
                ClearLine();
                Console.Write("Линия горизонтальная? [y/n]: ");
                if (Console.ReadKey().KeyChar.Equals('y') || Console.ReadKey().KeyChar.Equals('н'))
                {
                    Console.SetCursorPosition(0, 1);
                    Console.Write("Координаты в плоскости xleft: ");
                    xleft = Convert.ToInt32(Console.ReadLine());
                    ClearLine();
                    Console.Write("Координаты в плоскости xright: ");
                    xright = Convert.ToInt32(Console.ReadLine());
                    ClearLine();
                    Console.Write("Координаты в плоскости y: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    ClearLine();
                    HorizontalLine h1 = new HorizontalLine(xleft, xright, y, sym);
                    h1.Draw();
                }
                else
                {
                    Console.SetCursorPosition(0, 2);
                    ClearLine();
                    Console.Write("Координаты в плоскости yup: ");
                    xleft = Convert.ToInt32(Console.ReadLine());
                    ClearLine();
                    Console.Write("Координаты в плоскости ydown: ");
                    xright = Convert.ToInt32(Console.ReadLine());
                    ClearLine();
                    Console.Write("Координаты в плоскости x: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    ClearLine();
                    VerticalLine y1 = new VerticalLine(xleft, xright, y, sym);
                    y1.Draw();
                }
                Console.SetCursorPosition(0, 1);
                if (Console.ReadKey().KeyChar.Equals(' ')) break;
            }
            Console.ReadKey();
        }
    }
}