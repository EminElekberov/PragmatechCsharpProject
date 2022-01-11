using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    public class Student
    {
        private static int _id=1;
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string name,string surname)
        {
            id = _id;
            _id++;
            this.Name = name;
            this.Surname = surname;
        }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
