using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
   public class Group
    {
        private static int _id = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        private List<Student> _student;
        public Group(string name)
        {
            Id = _id;
            _id++;
            this.Name = name;
            _student = new List<Student>();

        }
        public void AddStudent(Student student)
        {
            _student.Add(student);
        }
        public void DeleteStudent(Student student)
        {
            _student.Remove(student);
        }

        public List<Student> GetAllStudent() => _student; 
        public override string ToString()
        {
            return Name;
        }
    }
}
