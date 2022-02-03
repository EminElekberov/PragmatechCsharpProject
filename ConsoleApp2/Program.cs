using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            for (int i = 0; i < 100; i+=2)
            {
                Console.WriteLine(i);
                Console.ReadKey();
            }
        }
    }
}
