using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTasks_game_
{
     public class Menu
    {
        Cards cards = new Cards();
        public  void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("hansi emeliyyati secmek isdeyirsen \n" +
                    "a)Karti gosder" +
                    "b)Karti sil" +
                    "c)Cixis");
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "a":
                        Console.WriteLine("kartin adini gir: ");
                        string names = Console.ReadLine();
                        cards.ShowInfo(names);
                        break;
                    case "b":
                        Console.WriteLine("kartin adini gir: ");
                        string remnames = Console.ReadLine();
                        cards.Remove(remnames);
                        break;
                    case "c":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("dogru emeliiyyat secmediniz");
                        break;
                }
            }
        }
    }
}
