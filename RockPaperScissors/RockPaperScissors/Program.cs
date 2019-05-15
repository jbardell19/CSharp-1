using System;
using System.Linq;

namespace RockPaperScissors
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Rock, Paper, Scissors!  ");
            Console.WriteLine("Please enter 0 for Rock");
            Console.WriteLine("Please enter 1 for Paper: ");
            Console.WriteLine("Please enter 2 for Scissors: ");
            //takes input from user and assigns it to guess variable
            string Guess = Console.ReadLine();
            //guess variable is lowered to all lowercase
            int Guess2 = Convert.ToInt32(Guess);
            RockPaperScissor(Guess2);
            
        }

        public static void RockPaperScissor(int Guess2)
        {
            // new random method for generating a number
            Random generator = new Random();
            //creates a number 0, 1 or 2
            int RandomNumber = generator.Next(0, 3);


            if (Guess2 == 0 && RandomNumber == 0)
            {
                Console.WriteLine("It's a tie both the computer and you chose Rock!");
                if (Guess2 == 1 && RandomNumber == 0)
                {
                     Console.WriteLine("You win! Paper beats rock!");                    
                }
                else if (Guess2 == 2 && RandomNumber == 0)
                {
                    Console.WriteLine("Sorry you lose.  Computer chose rock.  Rock beats scissors");
                }
            }
            else if (Guess2 == 1 && RandomNumber == 1)
            {
                Console.WriteLine("It's a tie both the computer and you chose Paper!");
                if (Guess2 == 0 && RandomNumber == 1)
                {
                    Console.WriteLine("Computer chose paper you lose.");
                }


            }
            else if (Guess2 == 2 && RandomNumber == 2)
            {
                Console.WriteLine("It's a tie both the computer and you chose Scissors");
                if (Guess2 == 2 && RandomNumber == 0)
                {
                    Console.WriteLine("You lose.  R");
                }
                else if (Guess2 == 2 && RandomNumber == 0)
                {
                    Console.WriteLine("Sorry you lose.  Computer chose rock.  Rock beats scissors");
                }
            }

        }
    }
}
