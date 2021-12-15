using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[2];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("adinizi girin: ");
                string fullname = Console.ReadLine();
                Console.WriteLine("Qrup nomrenizi girin: ");
                string groupNo = (Console.ReadLine());
                Console.WriteLine("yasinizi girin: ");
                int age= Convert.ToInt32(Console.ReadLine());

                Student student = new Student(fullname,groupNo,age);
                students[i] = student;
                Console.WriteLine($"telebe dogulmusdur  {Student.GetBirthYear(student)}");
                
            }
            Console.WriteLine("sinfin adini girin");
            string className = Console.ReadLine();
            Console.WriteLine($"qrupda {ClassLenght(className,students)} nefer var ");
            Student.ShowStudent(className,students);
        }
        //sagirdlerin umumi sayini gosderen
        
        public static int ClassLenght(string groupNo, Student[] student)
        {
            int len = 0;
            foreach (var item in student)
            {
                if (item.GroupNo== groupNo)
                {
                    len++;
                }
            }
            return len;
        }
       
    }
}
