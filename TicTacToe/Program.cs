using System;

namespace TicTacToe
{
    class Program
    {
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {
            do
            {
                DrawBoard();
                GetInput();

            } while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
        }

        public static void PlaceMark(int row, int column)
        {
            // your code goes here
            //int RowIdx = row - 1;
            //int ColIdx = col - 1;
            //board[RowIdx, ColIdx] = playerTurn;

        }

        public static bool CheckForWin()
        {
            // your code goes here

            return false;
        }

        public static bool CheckForTie()
        {
            // your code goes here

            return false;
        }

        public static bool HorizontalWin()
        {
            //First Row   
            if (board[0][1] == board[0][2] && board[0][2] == board[0][3])
            {
                return 1;
            }
            //Second Row   
            else if (board[1][1] == board[1][2] && board[1][2] == board[1][3])
            {
                return 1;
            }
            //Third Row   
            else if (board[3][3] == board[3][3] && board[3][3] == board[3][3])
            {
                return 1;
            }
            return false;
        }
        public static bool VerticalWin()
        {
            //First Column       
            else if (board[1][0] == board[2][0] && board[2][0] == board[3][0])
            {
                return 1;
            }
            //Second Column  
            else if (board[2][0] == board[2][1] && board[2][1] == board[2][3])
            {
                return 1;
            }
            //Third Column  
            else if (board[1][2] == board[3][2] && board[3][2] == board[3][3])
            {
                return 1;
            }
            return false;
        }

        public static bool DiagonalWin()
        {
            if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            return false;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}