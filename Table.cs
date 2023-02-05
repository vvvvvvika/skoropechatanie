using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Table
    {
        public static void DrewPlayer(List<Player> list)
        {
            foreach(var element in list)
            {
                Console.WriteLine(element.Name + " " + element.Time); ;
            }
        }
        public static List<Player> ChekElement (List<Player> list, string Name, string time)
        {
            Console.ResetColor();
            if (list != null)
            {
                if (string.IsNullOrEmpty(Name))
                {
                    Name = "Player";
                    int i = 0;
                    foreach (var element in list)
                    {
                        if (element.Name == Name)
                        {
                            Name = "Player" + (i++);
                        }
                    }

                }
                else
                {
                    foreach (var element in list)
                    {
                        if (element.Name == Name)
                        {
                            return list;
                        }
                    }
                }
            }
            list.Add(new Player
            {
                Name = Name,
                Time = time
            });
            Json.Serialize(list);
            return list;
        }
    }
}
