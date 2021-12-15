using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    class Account
    {
        public int No;
        public string Username;
        public string Password;
        static int id;
        public Account(string username,string password)
        {
            Username = username;
            Password = password;
            No = ++id;
        }

        
         public static bool IsUserNameValid1()
        {
            char ch = Convert.ToChar(Console.ReadLine());
            if (Char.IsLetterOrDigit(ch))
            {
                return true;
            }
            return false;
        }
        public bool IsPasswordValid(string password)
        {
            bool Uppercase = password.Any(char.IsUpper);
            bool Lowercase = password.Any(char.IsLower);
            byte score = 0;
            string st = Console.ReadLine();
            if (password.Length >= 8 && password.Length <= 25)
            {
                if (Char.IsSymbol(Convert.ToChar(st)))
                {
                    return true;
                }
            }
            if (Uppercase)
            {
                score++;
                Console.WriteLine("Uppercase test passed.");
            }
            else
            {
                Console.WriteLine("Uppercase test failed.");
            }

            if (Lowercase)
            {
                score++;
                Console.WriteLine("Lowercase test passed.");
            }
            else
            {
                Console.WriteLine("Lowercase test failed.");
            }


            return false;
        }
    }
}
