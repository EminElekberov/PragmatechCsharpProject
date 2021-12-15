using System;
using System.Collections.Generic;
using System.Text;

namespace task6
{
    static class met
    {
        public static List<Student> list = new List<Student>();
        public static List<Group> group = new List<Group>();
        public static void createStudent(string name,string surname)
        {
            list.Add(new Student(name, surname));
        }
        public static void newGroup(string grpname,int capacity)
        {
            group.Add(new Group(capacity,grpname));
        }
        public static void showStudent()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static void showGroup()
        {
            foreach (var item in group)
            {
                Console.WriteLine(item.groupName);
            }
        }
        public static void ClassLenght(string className)
        {
            foreach (var item in group)
            {
                if (item.groupName==className)
                {
                    Console.WriteLine(item.groupName);
                }
            }
        }
    }
}
