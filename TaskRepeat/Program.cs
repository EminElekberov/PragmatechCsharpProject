using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //    Student[] students = new Student[2];
            //    for (int i = 0; i < students.Length; i++)
            //    {
            //        Console.WriteLine("adinizi girin: ");
            //        string fullname = Console.ReadLine();
            //        Console.WriteLine("Qrup nomrenizi girin: ");
            //        string groupNo = (Console.ReadLine());
            //        Console.WriteLine("yasinizi girin: ");
            //        int age = Convert.ToInt32(Console.ReadLine());
            //        Student student = new Student(fullname, groupNo, age);
            //        students[i] = student;
            //        Console.WriteLine($"telebe dogulmusdur{Student.GetBirthYear(student)}");
            //    }
            //    Console.WriteLine("qrup nomresini daxil edin");
            //    string number = Console.ReadLine();
            //    Console.WriteLine($"daxil edilen qurp nomersindeki teleberlerin sayi {CheckClass(number,students)}");
            //    ShowStudents(number, students);
            //}
            //public static int  CheckClass(string groupnu,Student[] students)
            //{
            //    int lene=0;
            //    foreach (var item in students)
            //    {
            //        if (groupnu==item.Groupno)
            //        {
            //            lene++;
            //        }
            //    }
            //    return lene;
            //}
            //public static void ShowStudents(string groupNumber ,Student[] students)
            //{
            //    foreach (var item in students)
            //    {
            //        if (groupNumber==item.Groupno)
            //        {
            //            Console.WriteLine(item.FullName);
            //        }
            //    }
            //}
            #endregion

            //string s = "EMin";
            //char[] ch = s.ToCharArray();
            //for (int i = 0; i < ch.Length; i++)
            //{
            //    Console.WriteLine(ch[i]);
            //}

            #region 2
            //Console.WriteLine("adinizi girin: Yalniz soz gire bilersiniz");
            //string username = Console.ReadLine();
            //Console.WriteLine("Please enter your password");
            //string password = Console.ReadLine();
            //Student account = new Student(username, password);
            //Student.IsUserNameValid(account);
            #endregion

            #region
            //    Console.OutputEncoding = System.Text.Encoding.UTF8;
            //    Dictionary<string, string> dictionary = new Dictionary<string, string>();
            //    START:
            //    for (int i = 1; i < 3; i++)
            //    {
            //        Console.WriteLine("Hörmətli istifadəçi! Zəhmət olmasa ölkə adı qeyd edin");
            //        string country = Console.ReadLine();
            //        Console.WriteLine("Hörmətli istifadəçi! Zəhmət olmasa paytaxt  adı qeyd edin");
            //        string village = Console.ReadLine();
            //        dictionary.Add(country, village);
            //        foreach (var item in dictionary)
            //        {
            //            Console.WriteLine(item.Key+" "+item.Value);
            //        }
            //    }
            //    Console.WriteLine("olkenin  adini daxil edin");
            //    string selectCountry = Console.ReadLine();
            //    foreach (var item in dictionary)
            //    {
            //        if (item.Key==selectCountry)
            //        {
            //            Console.WriteLine(item.Value);
            //        }
            //        if (selectCountry=="all")
            //        {
            //            Console.WriteLine(item.Value);
            //        }
            //        else
            //        {
            //            Console.WriteLine("adi dogru girnin zehmet olmasa");
            //        }
            //    }
            //    Console.WriteLine("helede soz daxil edilsinmi? (y/n)");
            //    if (Console.ReadKey().Key == ConsoleKey.Y)
            //    {
            //        goto START;
            //    }
            //}
            #endregion
            //Group group = new Group();
            //string s = Console.ReadLine();
            //group.PasswordChecker(s);
            //Console.ReadKey();
            Student st = new Student("Domation", "Road", 25);
            Student st2 = new Student("Nofel", "Salahov", 22);
            st.Counter();
            Console.WriteLine("-----------------");
            st2.Counter();
        }
        #region
        //List<Student> students = new List<Student>();
        //List<Group> groups = new List<Group>();
        //public void CreateStudents()
        //{
        //    Console.WriteLine("adi daxil edin");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("soyadi daxil edin");
        //    string surname = Console.ReadLine();
        //    students.Add(new Student(name, surname));
        //}
        //public void GroupCreate()
        //{
        //    Console.WriteLine("qrup adini daxil edin");
        //    string groupnumber = Console.ReadLine();
        //    Console.WriteLine("capacityni girin");
        //    int capacity = Convert.ToInt32(Console.ReadLine());
        //    groups.Add(new Group(capacity, groupnumber));
        //}
        //public void ShowStudents()
        //{
        //    foreach (var item in students)
        //    {
        //        Console.WriteLine(item.Name+" "+item.Surmame);
        //    }
        //}
        //public void showGroup()
        //{
        //    foreach (var item in groups)
        //    {
        //        Console.WriteLine(item.GroupName);
        //    }
        //}
        //public void AddGroupStudents()
        //{
        //    Student student = null;
        //    Group group = null;
        //    Console.WriteLine("group omresini daxil edin zehmet olmasa");
        //    string groupNumber = Console.ReadLine();
        //    Console.WriteLine("telebe nomesini daxil edin");
        //    string studentNumber = Console.ReadLine();
        //    foreach (var item in groups)
        //    {
        //        if (item.GroupName==groupNumber)
        //        {
        //            group = item;
        //            break;
        //        }
        //    }
        //}
        //public void ClassLenght()
        //{
        //    foreach (var item in groups)
        //    {

        //    }
        //}
        #endregion

    }
    
}
