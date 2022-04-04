using System;
using System.Collections.Generic;
using System.Text;

namespace taskquiz
{

    class Student:Person
    {
        public void Study()
        {
            Console.WriteLine("I am studing");
        }
        public void ShowAge(int age)
        {
            Console.WriteLine($"my age is{age}");
        }
    }
}
