using System;
namespace ToDoList___CheckPoint2
{
    public class ConsoleUtils
    {
        public static string DisplayMenu()
        {
            string menu = @"ToDo App.  Choose an option to continue: 
        L to list item
        A to add item
        U to update item
        D to delete item
        Q to quit the program;
        Choose your option: ";
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
        public ConsoleUtils()
        {
        }
    }
}
