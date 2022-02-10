using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTasks_game_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Random random = new Random();
            //string[] words = { "man", "rat", "cow", "chicken","asdf","frfrt" };
            //for (int i = 0; i < 2; i++)
            //{
            //    int index = random.Next(words.Length);
            //    Console.WriteLine(words[index]);

            //}
            #endregion


            Random random = new Random();
            string[] words = { "man", "rat", "cow", "chicken", "asdf", "frfrt" };

            int index = random.Next(words.Length);
            int index2 = random.Next(words.Length);
            Console.WriteLine(words[index]);
            Console.WriteLine(words[index2]);
        START:

            double bal;
            int say = 0;
            for (int hak = 3; hak > 0; hak--)
            {
                Console.WriteLine("bir wsoz daxil edin: ");
                string soz = Console.ReadLine();
                say++;
                if (hak != 0)
                {
                    if (soz == words[index2].ToString())
                    {
                        if (hak == 3)
                        {
                            bal = 9.2;
                            Console.WriteLine($"tebriker ikinci sozu {say} texminde  bildiniz ve sizin baliniz {bal}");
                        }
                        else if (hak == 2)
                        {
                            bal = 6.2;
                            Console.WriteLine($"tebriker ikinci sozu {say} texminde bildiniz ve sizin baliniz {bal}");
                        }
                        else if (hak == 1)
                        {
                            bal = 4;
                            Console.WriteLine($"tebriker ikinci sozu {say} texminde bildiniz ve sizin baliniz {bal}");
                        }

                        return;
                    }
                    else
                    {
                        Console.WriteLine("dogru tapa bilmediniz");
                    }

                }
                else
                {
                    Console.WriteLine("sizin arti qtexmin haqqiniz qalmadi");

                }
                
            }
            Console.WriteLine("helede soz daxil edilsinmi? (y/n)");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                goto START;
            }
            #region
            //string content = "This is really fun. I am learning to code.  ";
            //char[] list = new char[] { ' ', '.' };

            //var split = content.Split(list, StringSplitOptions.RemoveEmptyEntries);


            //Random random = new Random();
            //for (int i = 0; i < 2; i++)
            //{
            //    string randomString = split[random.Next(1, split.Length)];
            //    Console.WriteLine(randomString);
            //}
            #endregion
        }
    }
}
