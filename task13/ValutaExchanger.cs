using System;
using System.Collections.Generic;
using System.Text;

namespace task13
{
    public static class ValutaExchanger
    {
        public static void Exchange(string currencyType, double salary)
        {
            Dictionary<string, double> Curencies = new Dictionary<string, double>();
           
               Curencies.Add(currencyType, salary);
               
            foreach (var item in Curencies)
            {
                if (item.Key == CurrencyType.EUR.ToString())
                {
                    Console.WriteLine("EURO deyeri"+salary * 2);
                }
                else if (item.Key == CurrencyType.TL.ToString())
                {
                    Console.WriteLine("Tl deyeri"+salary * 0.3);
                }
                else if (item.Key == CurrencyType.USD.ToString())
                {
                    Console.WriteLine("dollar deyeri " + salary * 1.7);
                }
                else
                {
                    Console.WriteLine("dogru valyuta daxil etmediniz");
                }
            }
        }
        public enum CurrencyType
        {
            USD,
            EUR,
            TL
        };
    }
}
