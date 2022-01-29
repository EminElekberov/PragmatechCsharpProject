using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRepeat
{
    public class Medicine
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public Medicine(string name, int price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
    }
}
