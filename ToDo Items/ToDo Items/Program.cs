using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
=======
using System.Linq;
using System.Collections.Generic;
using System.Threading;
>>>>>>> 1065d8cbf6674cf61f710f1e7f59ba13bf30764e

namespace ToDo_Items
{
    class Program
    {

        // new Dictionary with a string as the first item and a List as the second item
            Dictionary<string, List<ToDoItems>> FullToDoList = new Dictionary<string, List<ToDoItems>>();
            static List<ToDoItems> ToDoList = new List<ToDoItems>();
            public static void Main(string[] args)
            {
                

                while (Console.ReadLine().ToLower() != "quit")
                {
                    Console.WriteLine("Do you want to enter a ToDoList item?  If no type  'quit' ");
                    // User enters list items according to prompts
                    Console.WriteLine("Enter the item description: ");
                    string Description = Console.ReadLine();
                    Console.WriteLine("When is the due date?");
                    string DueDate = Console.ReadLine();
                    Console.WriteLine("Enter the priority level as low, normal or high: ");
                    string Priority = Console.ReadLine();
                    ToDoList.Add(new ToDoItems(Description, DueDate, Priority));

                }

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
    class ToDoItems
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



        public ToDoItems(string description, string duedate, string priority)
        {
            Description = description;
            DueDate = duedate;
            Priority = priority;
        }
    }

}


