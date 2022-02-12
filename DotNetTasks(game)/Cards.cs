using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTasks_game_
{
    public class Cards
    {
        public static List<Atm> atms = new List<Atm>();
        //
        
        public Cards()
        {
        }
        public static void CreateStudents()
        {
            int amount = 2000;
            int count = 0;

        newCart:
            Console.WriteLine("\n sizin mebleginiz: " + amount);
        START:
            if (amount == 0)
            {
                Console.WriteLine("kartda pul yoxdur ona gorede yeni kart elave etmek mumkun olmadi");
                return;
            }
            Console.WriteLine("\n kartin adini daxil edin ");
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

                Console.WriteLine("sizn balansinizda qalan pul: " + amount);
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
                count++;
            }
            atms.Add(new Atm(newCreateCardAmount, dt, nm));
            Console.WriteLine("kart elave edilsinmi \n y/n \n");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                goto newCart;
            }
        }
        public static void ShowAllCards()
        {
            foreach (var item in atms)
            {
                Console.WriteLine("kartin adi: " + item.Name + " " + "kartdaki pul: " + item.NewCreateCarAmount + "" +
                    "kartinn son isdifade tarixi: " + item.dates);
            }
        }
        public void ShowInfo(string cartName)
        {
            Atm info = atms.Find(n => n.Name.Trim().ToLower() == cartName.Trim().ToLower());
            if (info != null)
            {
                Console.WriteLine($"name {info.Name} \n amount{info.NewCreateCarAmount} \n " +
                    $"end date {info.dates}");
            }
            else
            {
                Console.WriteLine("this card is not found");
            }


        }
        public void Remove(string crdName)
        {
            string removeCards = crdName.Trim().ToLower();
            if (removeCards == null)
            {
                Console.WriteLine("kart adini girin");
            }
            Atm remove = atms.Find(r => r.Name.Trim().ToLower().Contains(removeCards));
            if (remove != null)
            {
                atms.Remove(remove);
                Console.WriteLine("This card removed");
            }
            else
            {
                Console.WriteLine("card is not found");
            }
        }

    }
}
