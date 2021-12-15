using System;
using System.Collections.Generic;
using System.Text;

namespace taskquiz
{
    public abstract class Person
    {
        public int Age { get; set; }
        public void Greet()
        {
            Console.WriteLine("hello");
        }
        public void Greeting()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("hello");
            }
        }
       
        public void SetAge(int age)
        {
            Console.WriteLine(age);
        }
    }
}
