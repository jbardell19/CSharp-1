using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace ToDo_Items
{
    class Program
    {
        //        In your main method, you should
        //Ask the user if they want to add an item, or if they are done.
        //        If the user wants to add an item,
        //ask for description, due date, and priority.
        //create a ToDoItem representing the user's input
        //add the new instance to a list of items
        //        Repeat until the user is done entering items.
        //Loop through the items and print the details of each item to the console.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an item to go on the ToDo list or type quit.");
            string answer = Console.ReadLine().ToLower();
            List<ToDoItem> toDoList = new List<ToDoItem>();
            ToDoItem item = new ToDoItem(desc, duedate, priority);
            
            while (answer != "quit")
            {

            }
        }
    }
    class ToDoItem
    {
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Priority { get; set; }

        public ToDoItem(string desc, string duedate, string priority)
        {
            Description = desc;
            DueDate = duedate;
            Priority = priority;
        }


    }
}
