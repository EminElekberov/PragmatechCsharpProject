using System;
using System.Collections.Generic;
using System.Text;

namespace task6
{
    class Group
    {
        public  int Capacity=5;
        public  string groupName;
        public static int No = 100;
        string x;
        public List<Student> student = new List<Student>();
        public Group(int capacity,string grpName)
        {
            Capacity = capacity;
            groupName = grpName;
            No++;
            x = groupName.Substring(1);

        }
       public void AddStudent(string name, string surname)
        {
            if (student.Count<Capacity)
            {
                student.Add(new Student(name,surname));
            }
            else
            {
                Console.WriteLine("yes/no ");
                string select = Console.ReadLine();
                switch (select)
                {
                    case "yes":
                        student.Add(new Student(name,surname));
                        break;
                    default:
                        break;
                }
            }
        }
       
    }
}
