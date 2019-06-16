using System;
using System.Collections.Generic;
using System.Linq;


namespace ToDo_Items
{
    class Program
    {

        
        public static void Main(string[] args)
        {
            // new Dictionary with a string as the first item and a List as the second item
            Dictionary<string, List<ToDoItems>> FullToDoList = new Dictionary<string, List<ToDoItems>>();
            List<ToDoItems> ToDoList = new List<ToDoItems>();

            string response = Console.ReadLine().ToLower();
            Console.WriteLine("Do you want to enter a ToDoList item?  If no type  'quit' ");
            // User enters list items according to prompts

            while (response != "quit")
            {
                
                Console.WriteLine("Enter the item description: ");
                string Description = Console.ReadLine();
                Console.WriteLine("When is the due date?");
                string DueDate = Console.ReadLine();
                Console.WriteLine("Enter the priority level as low, normal or high: ");
                string Priority = Console.ReadLine();
                ToDoList.Add(new ToDoItems(Description, DueDate, Priority));
                response = Console.ReadLine();
                
            }
            foreach (ToDoItems item in ToDoList)
            {
                Console.WriteLine(item.toDoList());
            }
            

            //        In your main method, you should
            //Ask the user if they want to add an item, or if they are done.
            //        If the user wants to add an item,
            //ask for description, due date, and priority.
            //create a ToDoItem representing the user's input
            //add the new instance to a list of items
            //        Repeat until the user is done entering items.
            //Loop through the items and print the details of each item to the console.
          
                
            }
    class ToDoItems
        {
            public string Description { get; set; }
            public string DueDate { get; set; }
            public string Priority { get; set; }

            public ToDoItems(string desc, string duedate, string priority)
            {
                Description = desc;
                DueDate = duedate;
                Priority = priority;
            }
            public string toDoList()
            {
                return (Description + " " + DueDate + " " + Priority);
            }

        }

    }
}


