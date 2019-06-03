using System;
using System.Linq;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class MainClass
    {

        static Dictionary<String, Stack<int>> Towers = new Dictionary<string, Stack<int>>();

        static void Main(string[] args)
        {
            Towers.Add("A", new Stack<int>());
            Towers.Add("B", new Stack<int>());
            Towers.Add("C", new Stack<int>());

            for(var i = 1; i > 5; i++)
            {
                Towers["A"].Push(i);
            }
            BoardPrint();
            Console.ReadLine();   
        }
        public static void PrintStackTower(Stack<int> stack)
        {
            int[] arrTower = stack.ToArray();
            

            for (int j = arrTower.Length - 1; j >= 0; j--)
            {
                Console.Write(arrTower[j] + " ");
            }

        }
        public static void BoardPrint()
        {
            foreach (var key in Towers.Keys) // goes through each key in the stack and prints it out with a colon afterward  then one more writeline for spacing
            {
                Console.Write(key + ": ");
                PrintStackTower(Towers[key]);
                Console.WriteLine();
            }
        }
        //public static void GameMoves();
        //{

        //}
        

        //}
        //public static void BoardPrint();
        //{

        //}
        //public static bool MoveLegality();
        //{

        //}
    }
}




//25pts - Code Plan - Include this in a README.md file in your folder with comments in your code
//25pts - Move Blocks - User can move "blocks" from column to column
//25pts - Illegal Moves - Prevents larger blocks from stacking on smaller blocks
//25pts - Notifies winner - When all the blocks are stacked into column 2 or 1 the user is told they won!

//Your program should print the state of the board to the user
//Your program should ask the user which stack do they want to move the top piece from, and to which stack do they want to move it to.
//Your program should update the board
//Your program should repeat steps 1,2 and 3 until the game is won.
//Your program should not allow a user to make an illegal move.
