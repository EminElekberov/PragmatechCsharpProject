using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_task27_.Helper
{
    public class Cb_Type
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public float Price { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
