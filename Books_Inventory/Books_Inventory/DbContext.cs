using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Collections.Generic;
using Books_Inventory;

class BooksContext : DbContext
{

    // This property corresponds to the table in our database
    public DbSet<Books> books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // get the directory the code is being executed from
        DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

        // get the base directory for the project
        DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

        // add 'students.db' to the project directory
        string DatabaseFile = Path.Combine(ProjectBase.FullName, "books.db");

        // to check what the path of the file is, uncomment the file below
        //Console.WriteLine("using database file :"+DatabaseFile);

        optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
    }
}