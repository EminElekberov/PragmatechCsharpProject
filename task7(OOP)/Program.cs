using System;

namespace task7_OOP_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passwordu daxil edin");
            string pass = Console.ReadLine();
            Console.WriteLine("emaili daxil edin");
            string email = Console.ReadLine();
            
            User user = new User(email,pass);
            user.ShowInfo();
            user.PasswordChecker(pass);
            Console.WriteLine("bitdi");
        }
    }
}
