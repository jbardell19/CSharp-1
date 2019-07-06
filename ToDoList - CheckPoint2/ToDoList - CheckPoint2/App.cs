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

            //Process user requests/actions
            while (action != "Q")
            {
                    //L
                    if (action == "L")
                {
                    repo.GetToDoItems();
                    List<ToDoItem> list = repo.GetToDoItems();
                    ConsoleUtils.PrintToDoItems(list);
                }
                //A
                if (action == "A")
                {
                    //ConsoleUtils.
                }
                 //U
                    if(action == "U")
                {
                    //ConsoleUtils.
                }
                    //D
                    if(action == "D")
                {
                    
                }
                    //Q
                    if(action =="Q")
                {

                }
            }
            }
        }
    }

