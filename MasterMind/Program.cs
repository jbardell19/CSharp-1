using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Program
    {
        static string[] secret = new string[2];
        static string[] colorArray = new string[] { "Red", "Yellow", "Blue" };
        static bool gameOver = false;

        static void Main(string[] args)
        {
            //1. Generate Random Secret
            Random rnd = new Random();
            // Generate two random indices to get two random colors from the ColorArray
            // and store them in the secret array

            // YOUR TASK:
            // CONVERT THE FOLLOWING CODE INTO A "FOR" LOOP
            for (int i = 0; i < 21; i++)
            { 
            int randomIndex = rnd.Next(0, 2);
            secret[0] = colorArray[randomIndex];
            randomIndex = rnd.Next(0, 2);
            secret[1] = colorArray[randomIndex];
            }
            // CONVERT THE CODE ABOVE INTO A "FOR" LOOP

            // When the game is not finished
            // We will repeat the following tasks
            while (gameOver == false)
            {
                // 2. Ask user to enter a guess

                Console.WriteLine("Enter your guess [Color1 Color2]: ");
                string[] guess = Console.ReadLine().Split(' '); // We can ignore the data validation

                // 3. Check if the user's guess is correct
                if (guess[0] == secret[0] && guess[1] == secret[1]) // user's guess is correct
                {
                    Console.WriteLine("You won!");
                    gameOver = true; // Set gameOver to be true so the "while" loop will finish
                }
                // user's guess is not correct
                // now we need to give the user some hint
                // the format of hint is FirstDigit-SecondDigit
                // the FirstDigit stands for the number of colors correctly guessed
                // the SecondDigit stands for the number of position correctly guessed
                else
                {
                    int correctColorCount = 0;
                    int correctPositionCount = 0;

                    // 3.1 Generate the first digit

                    // YOUR TASK
                    // Convert the following code into a "for" loop
                    // Use .Contains function to replace the comparison
                    for (int i = 0; i < 5; i++)
                    { 
                    if (guess[0] == secret[0] || guess[0] == secret[1])
                    {
                        correctColorCount++;
                    }
                    if (guess[1] == secret[1] || guess[1] == secret[0])
                    {
                        correctColorCount++;
                    }
                    }
                    // Convert the code above into a "for" loop

                    // 3.2 Generate the second digit

                    // YOUR TASK
                    // Convert the following code into a "for" loop
                    for (int i = 0; i <5; i++)
                    { 
                    if (guess[0] == secret[0])
                    {
                        correctPositionCount++;
                    }
                    if (guess[1] == secret[1])
                    {
                        correctPositionCount++;
                    }
                    }
                    // Convert the code above into a "for" loop

                    // 3.3 Output the hint to the user
                    // YOUR TASK
                    // Fill out the blank with the hint generated above in the correct format
                    Console.WriteLine("Your hint is: " + correctColorCount + " " + correctPositionCount);

                    // 4. Tell the "while" loop to continue
                    // YOUR TASK
                    // What value should you assign to which variable so that the "while" loop
                    // will continue?


                }

            }
            Console.Read();

        }



    }

}



















//using System;
//using System.Collections;
//using System.Collections.Generic;

//namespace MasterMind
//{
//    class MainClass
//    {
//        public static void Main(string[] args)
//        {

//            Color();


//        }
//        public static void Color()
//        {
//            // new random method for generating a number
//            Random generator = new Random();
//            //creates a number 0, 1 or 2
//            System.Collections.Generic.List<string> Colors = new List<string> { "Red", "Green", "Blue" };
//            var ColorOne = generator.Next(Colors.Count);
//            var ColorTwo = generator.Next(Colors.Count);
//            Console.WriteLine((string)Colors[ColorOne]);
//            Console.WriteLine((string)Colors[ColorTwo]);


//            Console.ReadKey();
//        }
//    }
//}




//The program should select 2 colors at random from(Red, Yellow and Blue). The colors can repeat.

//The program should then prompt the user for their guess.


//The program should then print a hint to the user if they did not guess correctly:

//"0-0" if the user did not guess the correct colors at all
//"1-0" if they guessed one of the colors correctly but not at the correct position
//"0-1" if they guessed one of the colors correctly at the correct position
//"2-0" if they guessed both colors correctly but at the wrong positions