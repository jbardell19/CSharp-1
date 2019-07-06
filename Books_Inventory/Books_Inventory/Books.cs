using System;
using System.Collections.Generic;
using System.Text;

namespace Books_Inventory
{
    public class Books
    {
        public int Id { get; private set; }
        public String Book { get; set; }
        public String Author { get; set; }
        public Books(String book, String author)
        {
            this.Book = book;
            this.Author = author;
        }
    }
}
