using System;
using System.Collections.Generic;

namespace ToDoList___CheckPoint2
{

    public class App
    {

        ItemRepository repo;
        public App()

        {
            repo = new ItemRepository();
            
        }
        public void Start()
        {
            //display menu
            string action = ConsoleUtils.DisplayMenu();

            ////Process user requests/actions
            while (action != "Q")
            {
                //l
                if (action == "L")
                {
                    repo.GetToDoItems();
                    List<ToDoItem> list = repo.GetToDoItems();
                    ConsoleUtils.PrintToDoItems(list);
                }
                //a
                if (action == "A")
                {
                    Console.WriteLine("Add a description: ");
                    string Description = Console.ReadLine();
                    Console.WriteLine("Enter a status for the item: ");
                    string Status = Console.ReadLine();
                    Console.WriteLine("Enter a due date for the item: ");
                    DateTime DueDate = Convert.ToDateTime(Console.ReadLine());
                    repo.AddItem(Description, Status, DueDate);
                }
                //u
                if (action == "U")
                {
                    Console.WriteLine("What is the Id of the item you want to update: ");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the Description you want to update for the item: ");
                    string Description = Console.ReadLine();
                    Console.WriteLine("What is the Status you want to update for the item: ");
                    string Status = Console.ReadLine();
                    Console.WriteLine("What is the Due Date you want to update for the item: ");
                    DateTime DueDate = Convert.ToDateTime(Console.ReadLine());
                    repo.UpdateItem(Id, Description, Status, DueDate);
                }
                //d
                if (action == "D")
                {
                    Console.WriteLine("what is the Id of the list item to delete: ");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    repo.DeleteItem(Id);
                }
                //q
                
            }
        }
        }
    }

