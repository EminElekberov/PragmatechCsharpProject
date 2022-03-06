using System;

namespace task7_OOP_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Console.WriteLine("Passwordu daxil edin");
            //string pass = Console.ReadLine();
            //Console.WriteLine("emaili daxil edin");
            //string email = Console.ReadLine();

            //User user = new User(email,pass);
            //user.ShowInfo();
            //user.PasswordChecker(pass);
            //Console.WriteLine("bitdi");
            //Console.WriteLine("-----------------");
            #endregion
            int date = Convert.ToInt32(Console.ReadLine());
            //int dt=Convert.ToInt32(DateTime.Now.Day+date);
            // Console.WriteLine("sizin kartiniz son isdiafde muddeti"+dt);
            Console.WriteLine(DateTime.Now.AddDays(date));
            //
        }
        public static void Check(string pass)
        {
            
        }
    }
}
