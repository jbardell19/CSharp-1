using System;
using System.Collections;
using System.Collections.Generic;

namespace MasterMind
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Color();


        }
        public static void Color()
        {
            // new random method for generating a number
            Random generator = new Random();
            //creates a number 0, 1 or 2
            System.Collections.Generic.List<string> Colors = new List<string> { "Red", "Green", "Blue" };
            var ColorOne = generator.Next(Colors.Count);
            var ColorTwo = generator.Next(Colors.Count);
            Console.WriteLine((string)Colors[ColorOne]);
            Console.WriteLine((string)Colors[ColorTwo]);


            Console.ReadKey();
        }
    }
}




//The program should select 2 colors at random from(Red, Yellow and Blue). The colors can repeat.

//The program should then prompt the user for their guess.


//The program should then print a hint to the user if they did not guess correctly:

//"0-0" if the user did not guess the correct colors at all
//"1-0" if they guessed one of the colors correctly but not at the correct position
//"0-1" if they guessed one of the colors correctly at the correct position
//"2-0" if they guessed both colors correctly but at the wrong positions