using System;
using System.Collections.Generic;
using System.Text;

namespace task13
{
    public class CashRegister
    {
        public double TotalAmount { get; set; }
        public double Currency { get; set; }
        public int TotalSalesCount { get; set; }
        public string current { get; set; }

        public CashRegister(double totalAmount,string Current)
        {
            TotalAmount = totalAmount;
            current = Current;
        }
        public List<CashRegister> book = new List<CashRegister>();
        public void AddNewSale(double totalAmount, string currency)
        {
            if (currency!=current)
            {
                if (currency == CurrencyType.EUR.ToString())
                {
                    TotalAmount+= totalAmount * 2;
                }
                else if (currency == CurrencyType.TL.ToString())
                {
                    TotalAmount += totalAmount * 0.3;
                }
                else if (currency == CurrencyType.USD.ToString())
                {
                    TotalAmount += totalAmount * 1.7;
                }
                else
                {
                    Console.WriteLine("dogru valyuta daxil etmediniz");
                }
            }
        }
        public void RemoveSale(double totalAmount, string currency)
        {
            if (currency != current)
            {
                if (currency == CurrencyType.EUR.ToString())
                {
                    TotalAmount -= totalAmount * 2;
                }
                else if (currency == CurrencyType.TL.ToString())
                {
                    TotalAmount -= totalAmount * 0.3;
                }
                else if (currency == CurrencyType.USD.ToString())
                {
                    TotalAmount -= totalAmount * 1.7;
                }
                else
                {
                    Console.WriteLine("dogru valyuta daxil etmediniz");
                }
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
            TL
        };
    }
}
