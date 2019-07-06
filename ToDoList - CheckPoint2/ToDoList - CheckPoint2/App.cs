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
            while (action != "q")
            {
                //l
                if (action == "l")
                {
                    repo.GetToDoItems();
                    List<ToDoItem> list = repo.GetToDoItems();
                    ConsoleUtils.PrintToDoItems(list);
                }
                //a
                if (action == "a")
                {
                    //consoleutils.
                }
                //u
                if (action == "u")
                {
                    //consoleutils.
                }
                //d
                if (action == "d")
                {

                }
                //q
                if (action == "q")
                {

                }
            }
        }
        }
    }

