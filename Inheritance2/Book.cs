using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    public class Book
    {
        public int Pages { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public Book(int pages, string author, int price)
        {
            Pages = pages;
            Author = author;
            Price = price;
        }
    }

    public class Fact : Book
    {
        public string Subject { get; set; }
        public Fact(int pages, string author, int price, string subject) : base(pages, author, price)
        {
            Subject = subject.ToUpper();
        }
    }
}
