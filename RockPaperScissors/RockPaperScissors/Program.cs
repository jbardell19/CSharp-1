using System;
using System.Linq;

namespace RockPaperScissors
{
    class Program
    {
        private static string rock;
        private static string scissors;
        private static string paper;

        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Rock, Paper, Scissors!  ");
            Console.WriteLine("Please enter Rock, Paper or Scissors: ");
            //takes input from user and assigns it to guess variable
            string Guess = Console.ReadLine();
            //guess variable is lowered to all lowercase
            string Guess2 = Guess.ToLower();
            
            RockPaperScissor(Guess2);
            
        }


        public static string RockPaperScissor(string Guess2)
        {
            // new random method for generating a number
            Random generator = new Random();
            //creates a number 0, 1 or 2
            int RandomNumber = generator.Next(0, 3);
            //converts the RandomNumber to a string for comparison
            string RandomNumber2 = Convert.ToString(RandomNumber);
            int Player;
            Console.WriteLine(Player);
            // if/else statements that convert the players guess to a string
            if (Guess2 == rock)
            {
                Player = 0;
                return Convert.ToString(Player);
                if (RandomNumber2 == Guess2)
                {
                    Console.WriteLine("It is a tie!");
                }
            }
            if (Guess2 == scissors)
            {
                Player = 1;
                return Convert.ToString(Player);
            }
            if (Guess2 == paper)
            {
                Player = 2;
                return Convert.ToString(Player);
            }
            else
            {
                Player = -1;
                return Convert.ToString(Player);
            }
            C
        }
    }
}
