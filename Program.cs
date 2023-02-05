using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            bool startThread = true;
            while (true)
            {
                List<Player> list = Json.Deserialize() == null?new List<Player>() : Json.Deserialize();
                Console.CursorVisible = true;

                Console.Write("Введите ваш ник: ");
                string Name = Console.ReadLine();

                Thread th = new Thread(_ =>
                {
                    string time;
                    while (startThread)
                    {
                        sw.Start();
                        Thread.Sleep(100);
                        sw.Stop();

                        time = String.Format("{0:00}:{1:00}", sw.Elapsed.Minutes, sw.Elapsed.Seconds);
                        Console.SetCursorPosition(0, 6);
                        Console.ResetColor();
                        Console.Write(time);

                        Console.SetCursorPosition(Scoropechatanie.x, Scoropechatanie.y);
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (time == "02:00")
                        {
                            startThread = false;
                            Console.SetCursorPosition(0, 6);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(time);
                            Console.ResetColor();
                        }
                    }
                });
                while (true)
                {
                    Console.Clear();
                    Scoropechatanie sc = new Scoropechatanie();
                    while (true)
                    {
                        Console.Write("Нажите enter, чтобы начать ");
                        ConsoleKeyInfo key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                            sc = new Scoropechatanie();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            sc = new Scoropechatanie();
                        }
                    }
                    startThread = true;
                    th.Start();
                    if (sc.Test() || !startThread)
                    {
                        startThread = false;
                        Console.ResetColor();
                        Console.SetCursorPosition(0, 5);
                        Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
                        break;
                    }
                }
                Console.ReadKey();
                Console.Clear();

                list = Table.ChekElement(list, Name, String.Format("{0:00}:{1:00}", sw.Elapsed.Minutes, sw.Elapsed.Seconds));
                Table.DrewPlayer(list);
                Console.WriteLine("Чтобы выйти нажмите Escape или любую другую клавшу, чтобы продоожить.");
                
                if(Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
}