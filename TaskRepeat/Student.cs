using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRepeat
{
   public  class Student
    {
        #region 1
        //public string FullName { get; set; }
        //public string Groupno { get; set; }
        //public int Age { get; set; }
        //public Student(string fulname,string group,int age)
        //{
        //    FullName = fulname;
        //    Groupno = group;
        //    Age = age;
        //}
        //public static int GetBirthYear(Student student)
        //{
        //    return DateTime.Now.Year - student.Age;
        //}
        #endregion

        #region 2
        //public static int NO;
        //public string UserName { get; set; }
        //public string Password { get; set; }
        //public Student(string username, string password)
        //{
        //    UserName = username;
        //    Password = password;
        //}
        //public static bool IsUserNameValid(Student student)
        //{
        //    bool a = false;
        //    string s = student.UserName;
        //    char[] ch = s.ToCharArray();
        //    for (int i = 0; i < ch.Length; i++)
        //    {
        //        if (i>=65 && i<=90)
        //        {
        //            a = true;
        //        }
        //        else
        //        {
        //            a = true;
        //        }
        //    }
        //    if (a)
        //    {
        //        Console.WriteLine("sifreni dogru girdiniz");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("yanlisdir");
        //    }
        //    return false;
        //}
        #endregion

        //
        //

        #region
        //public static int No = 0;
        //public string Name { get; set; }
        //public string Surmame { get; set; }
        //public Student(string name,string surname)
        //{
        //    Name = name;
        //    Surmame = surname;
        //    No++;
        //}
        #endregion

        //public abstract bool PasswordChecker(string pass);
        //public virtual void Show()
        //{
        //    Console.WriteLine("abstarct method");
        //}

        public string Name { get; set; }
        public string Surname { get; set; }
        public int age { get; set; }
        public static int Number;
        public Student(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            this.age = age;
            Number++;
        }
        public void Counter()
        {
            Console.WriteLine($" {this.Number} defe instance edildi.");
        }
    }
}
