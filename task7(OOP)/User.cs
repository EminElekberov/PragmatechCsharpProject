using System;
using System.Collections.Generic;
using System.Text;

namespace task7_OOP_
{
    class User:Account
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        


        public User(string email,string password)
        {
            Email = email;
            Password = password;
        }

        public User()
        {

        }
        public override void ShowInfo()
        {
            Console.WriteLine("adi girin");
            Console.WriteLine("----------------------");
            string name = Console.ReadLine();
            Console.WriteLine("adi " + name);
            Console.WriteLine("----------------------");

            Console.WriteLine("emaili " + Email);
        }

        public override bool PasswordChecker(string pass)
        {
            bool a = false;
            bool b = false;
            int change;
            if (pass.Length > 8)
                {
                for (int i = 0; i < pass.Length; i++)
                {
                     change = Convert.ToInt32(pass[i]);
                    
                    if (change > 64 && change < 91)
                    {
                        a = true;
                    }
                     else if (change > 97 && change < 123)
                    {
                        b = true;
                    }
                }
                if (a && b)
                {
                    Console.WriteLine("sifreni dogru girdiniz");
                    return true;
                }
                else
                {
                    Console.WriteLine("yanlisdir");
                }
                }
                else
                {
                    Console.WriteLine("password en az 8 simvoldan ibaret olmalidir ve butun herfler boyukle olmalidir");
                }
            
            return false;
        }
    }
}
