using System;
using System.Collections.Generic;


namespace ToDoList___CheckPoint2
{
    public class ConsoleUtils
    {
        // WriteLines to display a menu
        public static string DisplayMenu()
        {
            Console.WriteLine("ToDo App.  Choose an option to continue: ");
            Console.WriteLine("L to list item");
            Console.WriteLine("A to add item");
            Console.WriteLine("U to update item");
            Console.WriteLine("D to delete item");
            Console.WriteLine("Q to quit the program;");
            Console.WriteLine("Choose your option: "); 
           string action = Console.ReadLine().ToUpper();
            return action;
        }
        // Requests item information and returns it
        public static string AskForItemInfo()
        {
            Console.WriteLine("Please enter the item for the list: ");
            string UserItemInfo = Console.ReadLine();
            return UserItemInfo;
        }
        // Prints the items
        public static void PrintToDoItems(List<ToDoItem> list)
        {
            foreach(ToDoItem item in list)
            {
                Console.WriteLine($"{item.Id} - {item.Description} - {item.Status} - {item.DueDate}");
            }
        }
        //Asks user for the list item ID and returns it
        public static int GetItemId()
        {
            Console.WriteLine("Enter the ID of the item: ");
            string userInput = Console.ReadLine();
            int ItemId = int.Parse(userInput);
            return ItemId;

            //TODO: 

        }
        
        }
        
    }

