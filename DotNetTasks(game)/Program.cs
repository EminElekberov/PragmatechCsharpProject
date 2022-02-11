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
            #region 1ci sual
            //    int dogru = 0;
            //    double Sum = 0;
            //    double bal = 0;
            //    int say = 0;
            //START:

            //    Random random = new Random();
            //    string[] words = { "You can", "gain experience", "if you", "are careful", "to avoid", "empty redundancy" };
            //    int index = random.Next(words.Length);
            //    int index2 = random.Next(words.Length);
            //    Console.WriteLine(words[index]);
            //    Console.WriteLine(words[index2]);
            //    List<string> newWords = new List<string>();


            //    for (int hak = 3; hak > 0; hak--)
            //    {
            //        Console.WriteLine("bir wsoz daxil edin: ");
            //        string soz = Console.ReadLine();
            //        say++;
            //        if (hak != 0)
            //        {
            //            if (soz == words[index2].ToString())
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
            //                Sum += bal;
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
            //Console.WriteLine("helede soz daxil edilsinmi? (y/n)");
            //if (Console.ReadKey().Key == ConsoleKey.Y)
            //{
            //    goto START;
            //}
            //    else
            //    {
            //        Console.WriteLine("sizin statistikalariniz: ");
            //        Console.WriteLine("soz ctluyunuz sayi: " + newWords.Count);
            //        Console.WriteLine("dogru " + dogru);
            //        int wrongWords=newWords.Count - dogru;
            //        Console.WriteLine("yanlis tapilan soz cutluklerinin sayi: "+ wrongWords);
            //        Console.WriteLine("qazanilan xal: "+Sum);
            //    }
            #endregion
                int amount = 2000;
                newCart:
                Console.WriteLine("sizin mebleginiz: " + amount);
                START:
                Console.WriteLine("kartin adini daxil edin ");
                string nm = Console.ReadLine();
                Console.WriteLine("karti nece gunluk isdeyirsiniz: ");
                int date = Convert.ToInt32(Console.ReadLine());
                DateTime dt = DateTime.Now.AddDays(date);

                Console.WriteLine("sizin kartin son isdifade muddeti: " + dt);
                Console.WriteLine("yeni kart yaratmaq ucun meblegi girin: ");
                int newCreateCardAmount = Convert.ToInt32(Console.ReadLine());
                if (newCreateCardAmount > amount)
                {
                    Console.WriteLine("bu qeder kartinizda pul yoxdur xais edililr dogru girin meblegi");
                }
                else
                {
                    amount -= newCreateCardAmount;
                    Console.WriteLine("sizn balansinizda qalan pul: "+amount);
                    Console.WriteLine("Zehmet olmasa 5 reqemli kod girin ");
                    string pass = Console.ReadLine();
                    bool a = false;
                    int change;
                    if (pass.Length == 5)
                    {
                        for (int i = 0; i < pass.Length; i++)
                        {
                            change = Convert.ToInt32(pass[i]);
                            if (change >= 48 && change <= 57)
                            {
                                a = true;
                            }
                            else
                            {
                                a = false;
                            }
                        }
                        if (a)
                        {
                            Console.WriteLine("Siz sifreni dogru girdiz ");
                        }
                        else
                        {
                            Console.WriteLine("sifre sadece reqemlerden ibaret olalidir");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("sifre dogru deyil");
                        Console.WriteLine("yeniden cehd edilsinmi? y/n)");
                        if (Console.ReadKey().Key == ConsoleKey.Y)
                        {
                            goto START;
                        }

                    }
                }
                Console.WriteLine("kart elave edilsinmi y/n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    goto newCart;
                }
                Atm atm = new Atm
                {
                    NewCreateCarAmount = newCreateCardAmount,
                    dates = dt,
                    Name = nm
                };
                Cards cards = new Cards();
                cards.Add(atm);
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
