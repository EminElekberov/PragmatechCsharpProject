using System;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1 
            Console.WriteLine("daxil edeceyiniz valyutalar \n " +
                "USD \n" +
                "EUR \n" +
                "TL");
            string valuate = Console.ReadLine();
            Console.WriteLine("meblegi girin ");
            double salary = Convert.ToDouble(Console.ReadLine());
            ValutaExchanger.Exchange(valuate, salary);
            Console.WriteLine("-----------------");

            #endregion
            //Console.WriteLine("daxil edeceyiniz valyutalar \n " +
            //    "USD \n" +
            //    "EUR \n" +
            //    "TL");
            //string check = Console.ReadLine();
            //double valuate = Convert.ToDouble(Console.ReadLine());
            //CashRegister cash = new CashRegister(50,"USD");
            //cash.AddNewSale(valuate, check);
            //Console.WriteLine(cash.TotalAmount);
        }
    }
}
