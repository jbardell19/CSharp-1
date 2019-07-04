using System;
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
                    ConsoleUtils.PrintToDoItems();
                }
                //A
                if (action == "A")
                {

                }
                    //U
                    if(action == "U")
                {

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
}
