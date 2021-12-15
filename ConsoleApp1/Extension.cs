using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Extension
    {
        #region IsEven
        //public static bool ISeven(this int n)
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

        #region IsContainsDigit
        //public static bool DigitFunctions(this string n)
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
        //public static string GetValueIndexes(this string pass)
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

        #region GetValueINdex
        public static List<int> GetValueIndexes(this int[] number, int x)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == x)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        #endregion

        public static bool IsOdd(this int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} ededi cutdur");
            }
            else
            {
                Console.WriteLine($"{n} ededi cut deyil");
                return false;
            }
            return true;
        }

    }
}
