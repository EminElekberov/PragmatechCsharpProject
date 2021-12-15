using System;
using System.Collections.Generic;
using System.Text;

namespace task6
{
    class Menu
    {
        public static void MenuBar()
        {
            string select = Console.ReadLine();
            switch (select)
            {
                case "1":
                    Methods.CreateStudents();
                    break;
                case "2":
                    Methods.NewGroup();
                    break;
                case "3":
                    Methods.ShowStudents();
                    break;
                case "4":
                    Methods.ShowGroup();
                    break;
                case "6":
                    Methods.ClassLenght();
                    break;
                case "7":
                    Methods.SystemExit();
                    break;
                default:
                    Console.WriteLine("dogru emir daxil etmediz");
                    break;
            }
        }
    }
}
