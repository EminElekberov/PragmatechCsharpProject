using System;

namespace taskquiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.Greeting();
            st.ShowAge(21);
            st.Study();
            st.Greet();
            Teacher tc = new Teacher();
            tc.Explaain();
        }
    }
}
