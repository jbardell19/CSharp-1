using System;
namespace ToDoList___CheckPoint2
{
    public class ConsoleUtils
    {
        public void DisplayMenu()
        {
            string menu = @"ToDo App.  Choose an option to continue: 
        L to list item
        A to add item
        U to update item
        D to delete item
        Q to quit the program";



        }
        public enum UserChoice{
            ListItem,
            AddItem,
            UpdateItem,
            DeleteItem,
            Quit
        }
        public ConsoleUtils()
        {
        }
    }
}
