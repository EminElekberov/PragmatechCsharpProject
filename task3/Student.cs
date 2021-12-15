using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    class Student
    {
        public string Fullname;
        public string GroupNo;
        public int age;
        public Student(string fullname,string groupNo,int Age)
        {
            this.Fullname = fullname;
            this.GroupNo = groupNo;
            this.age = Age;
        }
        public static int  GetBirthYear(Student student)
        {
            return DateTime.Now.Year - student.age;
            //DateTime currentDateTime = DateTime.Now;
            //int result = currentDateTime.Year;
            //int res = result - age;
            //Console.WriteLine($"siz {res} tarixinde anadan olmusuz");
        }
        public static void ShowStudent(string groupNo,Student[] student)
        {
            foreach (var item in student)
            {
                if (item.GroupNo==groupNo)
                {
                    Console.WriteLine(item.Fullname);
                }
                
            }
        }
    }
}
