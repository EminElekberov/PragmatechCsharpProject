using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task29.Models
{
    public class Book
    {
        public static List<BooksItem> books = new List<BooksItem>
        {
            new BooksItem{Id=1,Title="In Search of Lost Time",Link="1.jpeg"},
            new BooksItem{Id=2,Title="Ulysses ",Link="2.jpeg"},
            new BooksItem{Id=3,Title="Don Quixote ",Link="3.jpeg"},
            new BooksItem{Id=4,Title="One Hundred Years of Solitude ",Link="4.jpeg"},
            new BooksItem{Id=5,Title="The Great Gatsby",Link="5.jpeg"},
            new BooksItem{Id=6,Title="Moby Dick",Link="6.jpeg"}
        };
        public static List<BooksItem> GetBooks() => books;
    }
    public class BooksItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
