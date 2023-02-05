using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    internal class Json
    {
        public static void Serialize(List<Player> list)
        {
            File.WriteAllText("D:\\Json.json",JsonConvert.SerializeObject(list));
        }
        public static List<Player> Deserialize()
        {
            return JsonConvert.DeserializeObject<List<Player>>(File.ReadAllText("D:\\Json.json"));
        }
        public static bool SearchPlayer(List<Player> list, string Name)
        {
            foreach(var element in list)
            {
                if(element.Name == Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
