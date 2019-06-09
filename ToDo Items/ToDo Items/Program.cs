using System;
using System.Collections.Generic;
using System.Linq;

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
            }
        }
    class ToDoItems
    {
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Priority { get; set; }

        public ToDoItems(string description, string duedate, string priority)
        {
            Description = description;
            DueDate = duedate;
            Priority = priority;
        }
    }

}

