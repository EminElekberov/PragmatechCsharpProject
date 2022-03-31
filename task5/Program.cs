using System;
using System.Collections.Generic;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  task1
            //Dictionary<string, string> dictionary = new Dictionary<string, string>();
            //for (int count = 0; count <= 3; count++)
            //{

            //    Console.WriteLine("Hörmətli istifadəçi! Zəhmət olmasa ölkə adı qeyd edin");
            //    string country = Console.ReadLine();
            //    Console.WriteLine("Hörmətli istifadəçi! Zəhmət olmasa paytaxt  adı qeyd edin");
            //    string village = Console.ReadLine();



            //    dictionary.Add(country, village);
            //    foreach (var item in dictionary)
            //    {
            //        Console.WriteLine(item.Key + " " + item.Value);
            //    }

            //}
            //Console.WriteLine("Hörmətli istifadəçi! Zəhmət olmasa paytaxtını tapmaq istədiyiniz ölkənin adını qeyd edin.");
            //string rep_country = Console.ReadLine();
            //foreach (var item in dictionary)
            //{
            //    if (rep_country == item.Key)
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //    if (rep_country == "all")
            //    {
            //        Console.WriteLine(item.Key + " " + item.Value);
            //    }
            //    else
            //    {
            //        Console.WriteLine("adi dogru girin zehmet olmasa");
            //    }
            //    Console.WriteLine("Yeni paytaxt axtarılsın?  1-Yes" +
            //        "2-No ");
            //    string answer = Console.ReadLine();
            //    switch (answer)
            //    {
            //        case "Yes":
            //            Console.WriteLine("yeni olke adi girin");
            //            string country1 = Console.ReadLine();
            //            if (item.Value==country1)
            //            {
            //                Console.WriteLine(item.Value);
            //            }
            //            else
            //            {
            //                Console.WriteLine("girdiyiniz olkenin  paytaxti tapilmamisdir");
            //            }
            //            break;
            //        case "NO":
            //            System.Environment.Exit(0);
            //            break;
            //        default:
            //            break;
            //    }
            //    //if (dictionary.ContainsKey(item.Key=rep_country))
            //    //{
            //    //    Console.WriteLine(item.Value);
            //    //}
            //}
            #endregion


            #region task2
            //Queue<string> queue = new Queue<string>();
            //Console.WriteLine("ad daxil edin");
            //string name = Console.ReadLine();
            //if (queue.Count<10)
            //{
            //    queue.Enqueue(name);
            //    Console.WriteLine("ugurla elave olundu");
            //}
            //else
            //{
            //    queue.Dequeue();
            //Console.WriteLine("-----------------");
            //
            //}
            #endregion

            #region  
            List<int> numbers = new List<int>();
            List<int> newNumbers1 = new List<int>();
            List<int> newNumbers2 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"eded daxil et {i + 1 / 10}");
                int number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);
            }
            Console.WriteLine("ededlerin yeri deyisdirilir");
            for (int i = 5; i < numbers.Count; i++)
            {
                newNumbers1.Add(numbers[i]);

            }
            for (int i = 0; i < 5; i++)
            {
                newNumbers2.Add(numbers[i]);

            }
            newNumbers1.AddRange(numbers);
            newNumbers1.ForEach(Console.WriteLine);
            Console.WriteLine("ededler ugurla deyisdi");
            #endregion



        }
    }
}
