using System;
using System.Collections;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //check(0);
            //int[] nums = { 1, 2, 3, 4, 5, 6 };
            //    Console.WriteLine(nums[0]);

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "Mina");
            //hashtable.Add(2, "Nofel");
            //hashtable.Add("Mina", "05592887555");

            //foreach (DictionaryEntry item in hashtable)
            //{
            //    if (item.Value == "05592887555")
            //    {
            //        Console.WriteLine(item.Key);
            //    }
            //}
            //if (hashtable.ContainsKey("Mina"))
            //{
            //    Console.WriteLine(hashtable["Mina"]);
            //}

            #region
            //for (int i = 0; i <10; i++)
            //{
            //    int count = 0;
            //    string res=count.ToString();
            //    if (res.Length==10)
            //    {
            //        Console.WriteLine("bitdi");
            //    }
            //}


            //for (int count = 0; count < 10; count++)
            //{
            //    Console.WriteLine("bitdi");
            //}
            //if (count==10)
            //{
            //    count++;
            //    Console.WriteLine("bitdi");
            //}
            #endregion
            // }
            //public static void check()
            //{
            //    string s = Console.ReadLine();
            //    if (s.Length >= 8)
            //    {
            //        Console.WriteLine("true");
            //    }
            //    else
            //    {
            //        Console.WriteLine("false");
            //    }
            //}
            //public static void check(params int[] list)
            //{
            //    for (int i = 0; i < list.Length; i++)
            //    {
            //        Console.WriteLine(list[i]);
            //    }
            //}
            #endregion
            Console.WriteLine("-----------------");

            Medicine med = new Medicine("Adalzit", 20, 30);
            Medicine med2 = new Medicine("nospa", 20, 30);
            Pharmacy ph = new Pharmacy();
            ph.Book.Add(med);
            ph.Book.Add(med2);
            //ph.Sell("nospa", 15);
            //ph.Sell("nospa", 2);
            ph.AddMedicine("assf");
        }
    }
}


