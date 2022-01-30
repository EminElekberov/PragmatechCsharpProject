using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRepeat
{
    public class CashRegister
    {
        #region
        //public static void Exchange(string type, double price)
        //{
        //    Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();
        //    keyValuePairs.Add(type, price);
        //    foreach (var item in keyValuePairs)
        //    {
        //        if (item.Key == CurrencyType.EUR.ToString())
        //        {
        //            Console.WriteLine(price * 2);
        //        }
        //        else if (item.Key == CurrencyType.Tl.ToString())
        //        {
        //            Console.WriteLine(price * 0.14);
        //        }
        //        else if (item.Key == CurrencyType.USD.ToString())
        //        {
        //            Console.WriteLine(price * 1.7);
        //        }
        //        else
        //        {
        //            Console.WriteLine("this is not exists");
        //        }
        //    }
        //}
        #endregion

        public double Totalamount { get; set; }
        public double Currency { get; set; }
        public int TotalSalesCount = 0;
        public string current { get; set; }
        public CashRegister(double toatlamount, string Current)
        {
            Totalamount = toatlamount;
            current = Current;

        }
    }
    public enum PaymentType
    {
        Card,
        Cash
    }
    public enum CurrencyType
    {
        USD,
        EUR,
        Tl
    }
}
