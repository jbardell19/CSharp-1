using System;
using System.Collections.Generic;

namespace Books_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {

            BooksContext context = new BooksContext();
            Console.WriteLine("Would you like to add a book to the Inventory list? Type Y or N");
            while (Console.ReadLine() == "Y")
            {
                context.Database.EnsureCreated();
                Console.WriteLine("Enter the book title : ");
                string books = Console.ReadLine();

                Console.WriteLine("Enter the book author: ");
                string author = Console.ReadLine();

                Books newbook = new Books(books, author);
                context.books.Add(newbook);
                context.SaveChanges();
                Console.WriteLine("Book added to list.");
                Console.WriteLine("Would you like to add another book to the inventory list? Type Y or N");
            }
            Console.WriteLine("The list of books so far is: ");
            foreach (Books b in context.books)
            {
                Console.WriteLine("{0} - {1} {2}",
                     b.Id, b.Book, b.Author);
            }
        }
    }
}
