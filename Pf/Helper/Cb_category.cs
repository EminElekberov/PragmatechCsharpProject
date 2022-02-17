using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pf.Helper
{
   public class Cb_category
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        public string SizeMl { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
