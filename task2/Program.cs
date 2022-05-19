using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Qadir
            int count = 0, i;
            bool a = false, b = false;
            Console.WriteLine("soz daxil edin zehmet olmasa: ");
            string word = Console.ReadLine();
            char[] chars = word.ToCharArray();
            for (i = 0; i < chars.Length; i++)
            {
                // Console.WriteLine(chars[i]);
                if (chars[i].ToString().ToLower() == "x")
                {
                    count++;
                    a = true;

                }
                else
                {
                    b = false;
                }

            }
            if (a == true)
            {
                Console.WriteLine("daxile edilen ifadede  x var ve sayi ise: " + count);
            }
            else if (b == false)
            {
                Console.WriteLine("burda x herfi yoxdur");
            }
            #endregion

            #region
            //int i;
            //Console.WriteLine("soz daxil edin zehmet olmasa: ");
            //string word = Console.ReadLine();
            //char[] chars = word.ToCharArray();
            //for (i = 0; i < chars.Length; i++)
            //{
            //    Console.Write(chars[i].ToString().Replace("*", "/"));
            //}
            #endregion

            #region Vicay
            //int count = 0, i;
            //bool a = false, b = false;
            //Console.WriteLine("soz daxil edin zehmet olmasa: ");
            //string word = Console.ReadLine();
            //char[] chars = word.ToCharArray();
            //for (i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //    if (chars[i].ToString() == " ")
            //    {
            //        count++;
            //        a = true;
            //    }
            //    else
            //    {
            //        b = false;
            //    }

            //}
            //if (a == true)
            //{
            //    Console.WriteLine("daxile edilen ifadede  bosluq var ve sayi ise: " + count);
            //}
            //else if (b == false)
            //{
            //    Console.WriteLine("burda bosluq yoxdur");
            //}
            #endregion
            /*
            Console.Write("sozu daxil edin ");
            string name = Console.ReadLine();
            string reverse = string.Empty;
            Console.WriteLine("-----------------");
            //
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }

            if (name == reverse)
            {
                Console.WriteLine($"{name} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"{name} is not Palindrome");
            }
        //    */
            //    string s = Console.ReadLine();
            //    int beginPoint = Convert.ToInt32(Console.ReadLine()), stringLength;
            //    try
            //    {
            //        stringLength = Convert.ToInt32(Console.ReadLine());

            //    }
            //    catch
            //    {
            //        stringLength = s.Length - beginPoint;
            //    }


            //    Console.WriteLine(SubString(s, beginPoint, stringLength));
            //}
            //static string SubString(string mainWord, int beginPoint, int stringLength)
            //{
            //    string sub = "";
            //    if (stringLength == null)
            //    {
            //        for (int i = beginPoint; i < mainWord.Length; ++i)
            //        {
            //            sub += mainWord[i];
            //        }
            //        return sub;
            //    }
            //    else
            //    {
            //        for (int i = beginPoint; i < beginPoint + stringLength; ++i)
            //        {
            //            sub += mainWord[i];
            //        }
            //        return sub;
            //    };

            /*
            Console.WriteLine("Enter a Word: ");
            string str = Console.ReadLine();

            //str=str.ToLower(); 

            string str2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!str2.Contains(str[i]))
                {
                    str2 += str[i];
                }

            cs
            }
            Console.WriteLine(str2);
            */

            /*
            //Console.WriteLine(GetLenght("salam"));
        }
        
        public static int GetLenght(string z)
        {
            int count = 0;
            foreach (var item in z)
            {
                count++;
            }
            return count;
        }
        */
            // cs
            /*
            Console.WriteLine(SubString(2,"salam"));
        }
        public static string SubString(int from,string x)
        {
            string result = null;
            for (int i = from; i < x.Length; i++)
            {
                result += x[i];

            }
            return result;
        }
            */

        }
    }
}