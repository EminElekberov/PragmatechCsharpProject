using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace winformTask18
{
    public class Student
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Trim().Length > 2)
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("ozune dogru ad sec");
                };
            }
        }
        public string Surname { get; set; }
        private string _email;
        private List<Student> students = new List<Student>();
        public string FullNamek { get { return Name + " " + Surname; } }
        public override string ToString()
        {
            return $"{Name} {Surname} {Email}";
        }
        public List<Student> GetAlLStudent() => students;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(value);
                    _email = value;
                }
                catch (Exception)
                {

                    throw new Exception("dogru email girin");
                }
            }
        }

    }
}
