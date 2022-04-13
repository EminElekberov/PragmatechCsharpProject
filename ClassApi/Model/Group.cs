using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassApi.Model
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
