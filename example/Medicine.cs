using System;
using System.Collections.Generic;
using System.Text;

namespace example
{
    public class Medicine
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public static double _totalInCome { get; set; }
        public Medicine()
        {

        }
        public Medicine(string name, int price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
    }
}
