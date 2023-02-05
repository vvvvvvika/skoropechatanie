using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Scoropechatanie
    {
        public Scoropechatanie()
        {
            x = 0;
            y = 0;
            Console.WriteLine(text);
        }
        private const string text = "Таким образом, рамки и место обучения кадров способствует подготовке и реализации ключевых компонентов планируемого обновления. Не следует, однако, забывать о том, что социально-экономическое развитие создаёт предпосылки качественно новых шагов для системы масштабного изменения ряда параметров. Практический опыт показывает, что начало повседневной работы по формированию позиции позволяет выполнить важнейшие задания по разработке системы масштабного изменения ряда параметров!";
        public static int x = 0;
        public static int y = 0;
        public bool Test()
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Green;
                ConsoleKeyInfo key = Console.ReadKey();
                while(key.KeyChar != text[i])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(x, y);
                    Console.Write(text[i]);
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.Green;
                    key = Console.ReadKey();
                }
                x++;
                if (x == Console.WindowWidth)
                {
                    y++;
                    x = 0;
                }
            }
            return true;
        }
    }
}
