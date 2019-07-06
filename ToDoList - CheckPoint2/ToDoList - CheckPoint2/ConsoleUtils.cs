using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace ToDoList___CheckPoint2
{
    public class ConsoleUtils
    {
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
        public enum UserChoice{
            ListItem,
            AddItem,
            UpdateItem,
            DeleteItem,
            Quit
        }

        

        public static string AskForItemInfo()
        {
            Console.WriteLine("Please enter the item for the list: ");
            string UserItemInfo = Console.ReadLine();
            return UserItemInfo;
        }
        public static void PrintToDoItems(List<ToDoItem> list)
        {
            foreach(ToDoItem item in list)
            {
                Console.WriteLine($"{item.Id} - {item.Description} - {item.Status} - {item.DueDate}");
            }
        }
        public static int GetItemId()
        {
            Console.WriteLine("Enter the ID of the item: ");
            string userInput = Console.ReadLine();
            int ItemId = int.Parse(userInput);
            return ItemId;

            //TODO: 

        }
        public static void Quit()
        {
            Application.Exit();
        }
        public ConsoleUtils()
        {
        }
    }
}
