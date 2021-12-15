using System;
using System.Collections.Generic;
using System.Text;

namespace winformders15
{
    class Book
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Trim().Length > 3)
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("kitabin adini dogru girin");
                };
            }
        }
        public int Isbn { get; set; }
        public string Type { get; set; }
        public string FullNameBook { get { return Type + " " + Name + " " + Isbn; } }
    }
}
