using System;
using System.Collections.Generic;

namespace task12
{
    public  class Program
    {
       
        //
        static void Main(string[] args)
        {

            #region Delegate ile yazilanlar 
            #region IsOdd IsEven
            //Check ch = new Check(IsOdd);
            //ch += IsEven;
            //ch.Invoke(5);
            //ch.Invoke(5);
            
            

            


            //
            #endregion
            #region IsContainsDigit
            //Check1 ch = new Check1(DigitFunctions);
            //ch.Invoke("123");
            #endregion
            #region GetValueIndexes
            //Check2 ch = new Check2(GetValueIndexes);
            //ch.Invoke("ccefc43234243ibhbu");
            #endregion
            //int[] r=new int[] { 1,2,3,6,5,8,6,9};

            //foreach (var item in GetValueIndexes(r, 1))
            //{
            //    Console.WriteLine(item);
            //}
            // }
            //
            #region IsOdd delegate
            //public delegate bool Check(int n);
            //public static bool IsOdd(int n)
            //{
            //    if (n % 2 == 0)
            //    {
            //        Console.WriteLine($"{n} ededi cutdur");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{n} ededi cut deyil");
            //        return false;
            //    }
            //    return true;

            //}
            //public static bool IsEven(int n)
            //{
            //    if (n % 2 == 1)
            //    {
            //        Console.WriteLine($"{n} ededi tekdir");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{n} ededi tek deyil");
            //        return false;
            //    }
            //    return true;

            //}
            #endregion
            //

            #region IsContainsDigit
            //public delegate bool Check1(string n);
            //public static bool DigitFunctions(string n)
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
            //        return false;
            //    }

            //    return true;
            //}
            #endregion

            #region GetValueIndexes
            //public delegate string Check2(string c);
            //public static string GetValueIndexes(string pass)
            //{
            //    char[] check = pass.ToCharArray();
            //    for (int i = 0; i < check.Length; i++)
            //    {
            //        int change = Convert.ToInt32(check[i]);

            //        if (change > 96 && change < 123)
            //        {
            //            Console.WriteLine(i + "  string tipindedir");
            //        }
            //        else
            //        {
            //            Console.WriteLine(i + " string tipinde deyil ");
            //        }

            //    }
            //    return pass;
            //}
            #endregion

            //public static  List<int> GetValueIndexes(int[] number,int x)
            //{
            //    List<int> list = new List<int>();
            //    for (int i = 0; i < number.Length; i++)
            //    {
            //        if (number[i]==x)
            //        {
            //            list.Add(i);
            //        }
            //    }
            //    return list;
            //}

            #endregion

            #region Extension clasla yazilanlar
            int r = 6;
            r.IsOdd();

            //int num = 5;
            //num.ISeven();

            //string s = "123";
            //s.DigitFunctions();

            //string m = "emin123Emin";
            //m.GetValueIndexes();


            //int[] r = new int[] { 1, 2, 3, 6, 5, 8, 6, 9 };
            //int z = 3;

            //foreach (var item in r.GetValueIndexes(z))
            //{
            //    Console.WriteLine(z+" ededinin indeksi "+item);
            //}
            #endregion
        }
    }
}
