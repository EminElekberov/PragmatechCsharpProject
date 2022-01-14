using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
   public  class Program
    {
        static void Main(string[] args)
        {
            for (int i = 550; i < 600; i+=2)
            {
                Console.WriteLine(i);
            }
            #region
            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //Console.WriteLine("reqem daxil edin");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ad daxil edin");
            //string name=Console.ReadLine();
            //dictionary.Add(a, name);
            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}
            /*
             * task 1 
            Console.WriteLine("1 ci reqemi daxil edin ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 ci reqemi daxil edin ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3 ci reqemi daxil edin ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4 ci reqemi daxil edin ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("5 ci reqemi daxil edin ");
            int e = Convert.ToInt32(Console.ReadLine());
            int res = avarage(a, b, c, d, e);
            Console.WriteLine("reqemlerin ededi ortasi " + res);
        }
        public static int avarage(int a,int b,int c,int d,int e)
        {
            int result = (a + b + c + d + e) / 5;
            return result;
        }
            */


            /*  task 2
            Console.WriteLine("Uzunlugu girin ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eni girin ");
            int b = Convert.ToInt32(Console.ReadLine());
            int res = perimetr(a, b);
            int res_area = area(a, b);
            Console.WriteLine("dzubucaqlinin perimetri "+res+" sahesi "+res_area);
        }
        public static int perimetr(int a, int b)
        {
            int netice = (a + b) * 2;
            return netice;
        }
        public static int area(int a, int b)
        {
            int netice_area = a * b;
            return netice_area;

        }
            */


            /*
             * task 3
            Console.WriteLine("1 ci reqemi daxil edin ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 ci reqemi daxil edin ");
            int b = Convert.ToInt32(Console.ReadLine());
            int res = vur(a, b);
            Console.WriteLine("vurmanin cavabi: "+res);
        }
        public static int vur(int a, int b)
        {
            return a * b;
        }
            */



            /*
             * task 4
            Console.WriteLine("eded daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());
            int res = kvTopla(a);
            Console.WriteLine("netice "+res);
            //
        }
        public static int kvTopla(int a)
        {
            int cem = 0, d;
            for (int i = 0; i <= a; i++)
            {
                d = i * i;
                cem += d;
            }
            Console.WriteLine("cem " + cem);
            Console.ReadLine();
            return 0;
        }
            */


            /*
            //task 5
            int cem = 0,f=1 ;
            Console.WriteLine("ededi daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                cem += i;
                f *= i;
            }
            Console.WriteLine("hasili: " + f + " cemi: " + cem);
            Console.ReadLine();

            */

            //DateTime currentDateTime = DateTime.Now;
            //int result = currentDateTime.Year;
            //int res = result - 15;
            //Console.WriteLine(res);
            //int a = 7;
            //int b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine("--------");
            //a = 8;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //IsEven(5);
            //string sentence = "Mahesh Chand";
            //char[] charArr = sentence.ToCharArray();
            //foreach (char ch in charArr)
            //{
            //    Console.WriteLine(ch);
            //}
            // DigitFunctions("12P3");
            //isNumber is true and numericValue=123

            //  GetValueIndexes("emin neceen");
            //PasswordChecker("emin12");
            //DigitFunction("948487");
            //}
            //public static string DigitFunction(string n)
            //{
            //    int numericValue;
            //    bool isNumber = int.TryParse(n, out numericValue);
            //    if (isNumber)
            //    {
            //        for (int i = 0; i < n.Length; i++)
            //        {
            //            Console.WriteLine("daxil olan ifadelerin hamsii string tipinde deyil"+n[i]);

            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("dogrudur");
            //    }

            //    return n;
            //    }

            //public static string PasswordChecker(string pass)
            //{
            //    for (int i = 0; i < pass.Length; i++)
            //    {
            //        int change = Convert.ToInt32(pass[i]);
            //        char[] check = pass.ToCharArray();

            //        if (change > 96 && change < 123)
            //        {
            //            Console.WriteLine("butun ifadeler string tipindedir");
            //        }
            //        else if (change > 32 && change < 64)
            //        {
            //            for (int j = 0; j < pass.Length; j++)
            //            {
            //                Console.WriteLine("sehv olan yerin indeksi " + check[i]);
            //            }
            //        }
            //    }
            //    return pass;
            //}
            //    public static string DigitFunctions(string n)
            //{
            //    int numericValue;
            //    bool isNumber = int.TryParse(n, out numericValue);
            //    if (isNumber)
            //    {
            //        Console.WriteLine("true");
            //    }
            //    else
            //    {
            //        Console.WriteLine("false");
            //    }

            //    return n;
            //}
            //public static bool IsEven(int n)
            //{
            //    if (n % 2 == 0)
            //    {
            //        Console.WriteLine("true");
            //    }
            //    else
            //    {
            //        Console.WriteLine("false");
            //        return false;
            //    }
            //    return true;
            //}
            #endregion
            //int r = 6;
            //r.IsOdd();

            //int num = 5;
            //num.ISeven();

            //string s = "123";
            //s.DigitFunctions();

            //string m = "emin123Emin";
            //m.GetValueIndexes();


            int[] r = new int[] { 1, 2, 3, 6, 5, 8, 6, 9 };
            int z = 3;

            foreach (var item in r.GetValueIndexes(z))
            {
                Console.WriteLine(item);
            }
        }
       
    }
}