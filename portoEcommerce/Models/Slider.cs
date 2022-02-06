using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Porto_ecommerce_30_.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string TrendWord { get; set; }
        public string Discount { get; set; }
        public string ClothType{get;set;}
        public int Price { get; set; }
        public string Image { get; set; }
    }
}
