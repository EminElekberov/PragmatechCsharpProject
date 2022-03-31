using System;
using System.Collections.Generic;
using System.Text;

namespace task6
{
    class Student
    {
        public string Name;
        public string Surname;
        public static int No=0;

        public Student(string name,string surname)
        {
            Name = name;
            Surname = surname;
            No++;
        }


       
        //public  void CreateNewStudents(string name, string surname)
        //{
        //    if (dictionary.ContainsKey(name))
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine($"{name} is exist");
        //        Console.ForegroundColor = ConsoleColor.White;

        //    }
        //    else
        //    {
               
        //        dictionary.Add(name, surname);
        //        Console.WriteLine($"{name} ile {surname} elave olundu");
        //    }
            
        //}
        //public void NewGroup(string groupName,string capacity)
        //{
        //    Console.WriteLine("nece telebe qeydiyyatdan kecireceksiniz");
        //    CapacityLenght();
        //    if (true)
        //    {
        //        dictionary.Add(groupName, capacity);
        //    }
        //    else
        //    {
        //        Console.WriteLine("max telebe sayini kecdinzi");
        //    }
        //}
        //public void ShowStudent()
        //{
        //    foreach (var item in dictionary)
        //    {
        //        Console.WriteLine(item.Key);
        //    }
        //}
        //public void ShowGroup()
        //{
        //    foreach (var item in dictionary)
        //    {
        //        Console.WriteLine(item.Value);
        //    }
        //}
        //public void ClassLenght(string groupNo, Student[] student)
        //{
        //    foreach (var item in student)
        //    {
        //        if (item.Group == groupNo)
        //        {
        //            Console.WriteLine(item.Name);
        //        }
        //    }
        //}
        

    }
}
