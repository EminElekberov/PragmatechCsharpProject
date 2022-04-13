using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassApi.Model
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}
