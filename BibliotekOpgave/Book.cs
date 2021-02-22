using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekOpgave
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Released { get; set; }

        public Book(string title, string author, int pages, int released)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Released = released;
        }

        public Book() { }
    }
}
