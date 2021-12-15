using System;
using System.Collections.Generic;
using System.Text;

namespace winform17
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
                    throw new Exception("adini dogru gir");
                };
            }
        }
        public string GroupNo { get; set; }
        public string Surname { get; set; }
        public string FullNamek { get { return Name + " " + Surname; } }
        public override string ToString()
        {
            return Name+ " "+Surname;
        }
    }
}
