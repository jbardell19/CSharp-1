using System;
using System.Linq;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class MainClass
    {

        static Dictionary<String, Stack<int>> Towers = new Dictionary<string, Stack<int>>();
        public static int StackCounter = 0;
        static void Main(string[] args)
        {
            Towers.Add("A", new Stack<int>());
            Towers.Add("B", new Stack<int>());
            Towers.Add("C", new Stack<int>());

            for(var i = 4; i > 0; i--)
            {
                Towers["A"].Push(i);
            }
            while (Towers["B"].Count != 4 || Towers["C"].Count != 4)
            {
                BoardPrint();//Reprints the board after move
                GameMoves();
            }
            Console.ReadLine();   
        }
        public static void BoardPrint()
        {
            foreach (var key in Towers.Keys) // goes through each key in the stack and prints it out with a colon afterward then one more writeline for spacing
            {
                Console.Write(key + ": ");
                PrintStackTower(Towers[key]);
                Console.WriteLine();
            }
        }
        //Function to move from one tower to another; ask user then push pop not to be confused with puddin pop
        public static void GameMoves()
        {
            Console.WriteLine("Which tower do you want to move from? Please choose A B or C");
            string StarterStack = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Which tower do you want to move to? Please choose A B or C");
            string DestStack = Console.ReadLine();
            Console.WriteLine();
            if (AbleToMove(StarterStack, DestStack))
            {
                //Move to the DestinationStack
                Towers[DestStack].Push(Towers[StarterStack].Peek());
                Towers[DestStack].Pop();

            }
            //for each move, need to remove from current stack add to new stack 

        }
        public static void PrintStackTower(Stack<int> stack)
        {
            int[] TowerArray = stack.ToArray();
            // new int[] TowerArray for the stack


            for (int i = TowerArray.Length - 1; i >= 0; i--)
            {
                Console.Write(TowerArray[i] + " ");
            }

        }
        //Below checks if you are able to make the move
        public static bool AbleToMove(string Starter, string Dest) // This checks if you can make the move or not.  You cannot put a bigger one on a smaller one.
        {
            if (Towers[Starter].Count != 0 && (Towers[Dest].Count == 0 || Towers[Starter].Peek() < Towers[Dest].Peek()))
            {
                return true;
            }
            else
            {
                Console.WriteLine("You cannot make that move.");
                return false;
            }
        }
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
