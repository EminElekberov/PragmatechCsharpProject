using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adinizi girin: Yalniz soz gire bilersiniz");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();
            Account account = new Account(username,password);
            if (Account.IsUserNameValid1() &&  account.IsPasswordValid(password))
            {
                Console.WriteLine(account.No);
            }
            else
            {
                Console.WriteLine("yanlis melumat");
            }
        }
      
        }
}
