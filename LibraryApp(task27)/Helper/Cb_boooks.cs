using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_task27_.Helper
{
   public class Cb_boooks
    {
        public int Id;
        public string FullName;
        public double Price { get; set; }
        public override string ToString()
        {
            return FullName;
        }
    }
}
