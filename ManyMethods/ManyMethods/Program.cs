using System;

namespace ManyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Hello();
            Addition();
            CatDog();
            oddEvent();
            inches();
            echo();
            killGrams();
            date();
            age();
            guess();

        }
        static void Hello() // Prints out a greeting and ask the user their name.Then responds with a "Bye Bob!" (replacing Bob with the name entered)
        {
            Console.WriteLine("Hello!  What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Bye " + name);
        }
        static void Addition() // A method that ask the user for 2 numbers and prints out their sum
        {
            Console.WriteLine("Please enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int added = num1 + num2;
            Console.WriteLine("The two numbers added together are: " + added);
        }

        static void CatDog() // A method that ask the user if they prefer cats or dogs, and either "Barks" or "Meows" back depending on what they entered.
        {
            Console.WriteLine("Do you prefer cats or dogs? ");
            string answer = Console.ReadLine();
            if (answer == "cats")
            {
                Console.WriteLine("MEOW!");
            }
            if (answer == "dogs")
            {
                Console.WriteLine("WOOF!!!");
            }

        }
        static void oddEvent()
        { // A method that asks the user for a number, and prints out if it is odd or even
            Console.WriteLine("Enter a Number: ");
            var answer = Convert.ToInt32(Console.ReadLine());
            if (answer % 2 == 0)
            {
                Console.WriteLine("That number is even");

            }
            else
            {
                Console.WriteLine("That number is odd");
            }
        }
        static void inches() { // A method that ask the user for a height in feet and returns the height converted to inches
            Console.WriteLine("Enter a height in feet: ");
            int answer = Convert.ToInt32(Console.ReadLine());
            int ConvertedHeight = answer * 12;
            Console.WriteLine("The height you entered in inches is: " + ConvertedHeight);
        }

        static void echo() { // A method that ask the user for a word then prints it 3 times, first in all caps, then 2 more time in all lower case
            Console.WriteLine("Enter a word: ");
            string answer = Console.ReadLine();
            Console.WriteLine(answer.ToUpper());
            Console.WriteLine(answer.ToLower());
            Console.WriteLine(answer.ToLower());

        }

        static void killGrams() { // A method that ask the user for a weight in pounds, then converts it to killograms
            Console.WriteLine("Enter a weight to convert it to killograms: ");
            float answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The weight in Killograms is: " + (answer / 2.2));

        }
        static void date() { //  A method that prints out the current date
            Console.WriteLine("You want the date?!?!?! ");
            DateTime aDay = DateTime.Now;
            Console.WriteLine(aDay.ToString("dddd, dd MMMM yyyy"));

        }
        static void age() { // A method that asks the user their birth year, and print out their age
            Console.WriteLine("What is your birth year: ");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " + (2019 - answer) + " years old");
        }
        static void guess() { // A method that ask the user to guess a word, and print out 'CORRECT!!' if the word is "chsarp", otherwise prints out 'WRONG!!'
            Console.WriteLine("Guess a word: ");
            string answer = Console.ReadLine();
            if (answer == "csharp")
                Console.WriteLine("CORRECT!!");
            else
            {
                Console.WriteLine("WRONG!");
            }

        
        }
    }

}
