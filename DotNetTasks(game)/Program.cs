using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DotNetTasks_game_
{
    class Program
    {
        public static int secondsCount = 0;
        public static Timer aTmr = new Timer(1000);
        public static int correctCount = 0;
        public static double SumCorrect = 0;
        static void Main(string[] args)
        {
            #region 1ci sual

            //    Console.WriteLine("Axtarilan sozu bu metnden sececksiniz: \n" +
            //        "You can gain experience, if you are careful to avoid empty redundancy. Do not fall into the" +
            //        " error of the artisan who boasts of twenty years experience in craft while in fact he has had" +
            //        " only one year of experience–twenty times. And never resent the advantage of experience your" +
            //        " elders have. Recall that they have paid for this experience in the coin of life, and have" +
            //        " emptied a purse that cannot be refilled.");
            //    aTmr.Elapsed += ATmr_Elapsed;
            //    aTmr.Enabled = true;
            //    aTmr.AutoReset = true;
            //    aTmr.Start();
            //    int dogru = 0;
            //    double Sum = 0;
            //    double bal = 0;
            //    int say = 0;
            //    List<string> newWords = new List<string>();
            //START:
            //    string content = "You can gain experience, if you are careful to avoid empty redundancy. Do not fall into the error of the artisan who boasts of twenty years experience in craft while in fact he has had only one year of experience–twenty times. And never resent the advantage of experience your elders have. Recall that they have paid for this experience in the coin of life, and have emptied a purse that cannot be refilled. ";
            //    char[] list = new char[] { ' ', '.' };
            //    var seperate = content.ToLower().Split(list, StringSplitOptions.RemoveEmptyEntries);
            //    Random random = new Random();

            //    int i = random.Next(seperate.Length);

            //    Console.WriteLine("\n" + seperate[i]);
            //    for (int hak = 3; hak > 0; hak--)
            //    {
            //        Console.WriteLine("bir wsoz daxil edin: ");
            //        string soz = Console.ReadLine();
            //        say++;
            //        if (hak != 0)
            //        {
            //            if (soz == seperate[i+1].ToString())
            //            {
            //                if (hak == 3)
            //                {
            //                    bal = 6.2;
            //                    Console.WriteLine($"tebriker ikinci sozu {say} texminde  bildiniz ve sizin baliniz {bal}");
            //                }
            //                else if (hak == 2)
            //                {
            //                    bal = 4;
            //                    Console.WriteLine($"tebriker ikinci sozu {say} texminde bildiniz ve sizin baliniz {bal}");
            //                }
            //                else if (hak == 1)
            //                {
            //                    bal = 2;
            //                    Console.WriteLine($"tebriker ikinci sozu {say} texminde bildiniz ve sizin baliniz {bal}");
            //                }
            //                dogru++;
            //                correctCount++;
            //                Sum += bal;
            //                SumCorrect = Sum;
            //            }
            //            else
            //            {
            //                Console.WriteLine("dogru tapa bilmediniz");
            //            }
            //            newWords.Add(soz);

            //        }
            //        else
            //        {
            //            Console.WriteLine("sizin arti qtexmin haqqiniz qalmadi");

            //        }

            //    }
            //    Console.WriteLine("helede soz daxil edilsinmi? (y/n)");
            //    if (Console.ReadKey().Key == ConsoleKey.Y)
            //    {
            //        goto START;
            //    }
            //    else
            //    {
            //        Console.WriteLine("sizin statistikalariniz: ");
            //        Console.WriteLine("soz ctluyunuz sayi: " + newWords.Count);
            //        Console.WriteLine("dogru " + dogru);
            //        int wrongWords = newWords.Count - dogru;
            //        Console.WriteLine("yanlis tapilan soz cutluklerinin sayi: " + wrongWords);
            //        Console.WriteLine("qazanilan xal: " + Sum);
            //    }
            #endregion
            #region
            Cards cards = new Cards();
            while (true)
            {
                Console.WriteLine("hansi emeliyyati secmek isdeyirsen \n" +
                    "a)kart elave et" +
                    "b)Karti gosder" +
                    "c)Karti sil" +
                    "d)Cixis" +
                    "e)Butun kartlari gosder");

                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "a":
                        Cards.CreateStudents();
                        //
                        break;
                    case "b":
                        Console.WriteLine("kartin adini gir: ");
                        string names = Console.ReadLine();
                        cards.ShowInfo(names);
                        break;
                    case "c":
                        Console.WriteLine("kartin adini gir: ");
                        string remnames = Console.ReadLine();
                        cards.Remove(remnames);
                        break;
                    case "d":
                        Environment.Exit(0);
                        break;
                    case "e":
                        Cards.ShowAllCards();
                        break;
                    default:
                        Console.WriteLine("dogru emeliiyyat secmediniz");
                        break;
                }
            }
        }
        #endregion
    }
    #region 1 ci sual 
    //private static void ATmr_Elapsed(object sender, ElapsedEventArgs e)
    //    {
    //        secondsCount++;
    //        if (secondsCount==120)
    //        {
    //            Console.WriteLine("\n  oyun bitdi: ");
    //            Console.WriteLine("dogru cavablar: "+correctCount);
    //            Console.WriteLine("toplanilan bal: "+SumCorrect);
    //        }
    //    }
    #endregion

}

