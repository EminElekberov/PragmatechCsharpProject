using System;
using System.Collections.Generic;
using System.Text;

namespace task6
{
     static class Methods
    {
        public static List<Student> list = new List<Student>();
        public static List<Group> group = new List<Group>();

        public static void CreateStudents()
        {
            Console.WriteLine("adini daxil ed");
            string nm = Console.ReadLine();
            Console.WriteLine("soyadi daxil et");
            string srm = Console.ReadLine();
            list.Add(new Student(nm, srm));
        }
        public static void NewGroup()
        {
            Console.WriteLine("group nomresinin daxil edin");
            string groupName = Console.ReadLine();
            Console.WriteLine("capacityni girin");
            int capacity = Convert.ToInt32(Console.ReadLine());
            group.Add(new Group(capacity, groupName));
        }
        public static void ShowStudents()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }
        }
        public static void ShowGroup()
        {
            foreach (var item in group)
            {
                Console.WriteLine(item.groupName);
            }
        }
        public static void AddGroupStudent()
        {
            Console.WriteLine("group omresini daxil edin zehmet olmasa");
            string groupNumber = Console.ReadLine();
            Console.WriteLine("telebe nomesini daxil edin");
            string studentNumber = Console.ReadLine();
            if (groupNumber!=null && studentNumber!=null)
            {
                foreach (var item in group)
                {
                    if (item.groupName == groupNumber)
                    {
                        foreach (var it in list)
                        {
                            if (it.Name == studentNumber)
                            {
                                Console.WriteLine("bu adda telebe qeydiyyatdan kecmisdir");
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                
               
            }
            
        }
        public static void ClassLenght()
        {
            Console.WriteLine("sinifin adini daxil edin");
            string className = Console.ReadLine();
            for (int i = 0; i < group.Count; i++)
            {
                if (group[i].groupName == className)
                {
                    Console.WriteLine(group[i].groupName);
                    for (int j = 0; j < group[i].student.Count; j++)
                    {
                        Console.WriteLine(group[i].student[j].Name);
                    }
                }
            }
        }
        public static void SystemExit()
        {
            System.Environment.Exit(0);
        }
    }
}
