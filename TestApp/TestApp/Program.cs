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
            Point p = new Point();
            int x = 0;
            int y = 0;
            char sym = ' ';
            Console.WriteLine("Если вы хотите прекратить рисовать нажмите пробел");
            while (true)
            {
                Console.Write("Какой символ хотите использовать? Чтобы выбрать нажмите его на клавиатуре: ");
                sym = Convert.ToChar(Console.ReadLine());
                p.SetSym(sym);
                ClearLine();
                Console.Write("Координаты в плоскости x: ");
                x = Convert.ToInt32(Console.ReadLine());
                ClearLine();
                Console.Write("Координаты в плоскости y: ");
                y = Convert.ToInt32(Console.ReadLine());
                ClearLine();
                p.SetX(x);
                p.SetY(y);
                p.Draw();
                Console.SetCursorPosition(0, 1);
                if (Console.ReadKey().KeyChar.Equals(' ')) break;
            }
            Console.ReadKey();
        }
    }
}