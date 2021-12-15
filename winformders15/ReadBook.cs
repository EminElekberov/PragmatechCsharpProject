using System;
using System.Collections.Generic;
using System.Text;

namespace winformders15
{
    class ReadBook
    {
        public string ReadyBook { get; set; }
        public string PageNO { get; set; }
        public string Genre { get; set; }
        public override string ToString()
        {
            return ReadyBook+" "+PageNO+" "+Genre;
        }
        public ReadBook(string readyBook,string genre,string pageNo)
        {
            ReadyBook = readyBook;
            PageNO = pageNo;
            Genre = genre;
        }
    }
}
