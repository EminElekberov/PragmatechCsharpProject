using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRepeat
{
    public class Group : Student
    {
        #region
        // public string GroupName { get; set; }
        // public static int no = 100;
        //private readonly List<Student> students = new List<Student>();
        // public int Capacity=5;
        // public Group(int capacity, string grpName)
        // {
        //     Capacity = capacity;
        //     GroupName = grpName;
        //     no++;

        // }
        // public void AddStudent(string name,string surname)
        // {
        //     if (students.Count< Capacity)
        //     {
        //         students.Add(new Student(name, surname));
        //     }
        //     else
        //     {
        //         Console.WriteLine("yes/no ");
        //         string select = Console.ReadLine();
        //         switch (select)
        //         {
        //             case "yes":
        //                 students.Add(new Student(name, surname));
        //                 break;
        //             default:
        //                 break;
        //         }
        //     }
        // }
        #endregion
        public string FUllname { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }

        public override bool PasswordChecker(string pass)
        {
            bool a = false;
            char[] ch = pass.ToCharArray();
            if (pass.Length>=8)
            {
                foreach (var item in ch)
                {
                    if (item>=65 && item<=90)
                    {
                        a = true;
                    }
                    else
                    {
                        a=false;
                    }
                }
                if (a)
                {
                    Console.WriteLine("Sifre Dogrudur");
                }
                else
                {
                    Console.WriteLine("sifer yanlisdir");
                }
            }
            else
            {
                Console.WriteLine("Sifre duzgun deyil");
            }
            return false;
        }
    }
}
