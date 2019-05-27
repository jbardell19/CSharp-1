using System;
using System.Collections.Generic;

namespace Gradebook
{
    class MainClass
    {
        string StudentName = " ";
        string Grades = " ";

        public static void Main(string[] args)

        {
            Dictionary<string, string[]> Gradebook = new Dictionary<string, string[]>();
            //Your program should ask the user to enter a student name, or "quit"
            Console.WriteLine("Enter a students name or quit: ");
            string StudentName = Console.ReadLine();



            //Once the student's name and grade have been entered, you should add the name and the grades (as a single String) to a dictionary(Dictionary<String,String>)

            //Steps 1, 2 and 3 should be repeated until the user enters quit for the students name.

            //Your program should then loop through the entries in the dictionary, 

            //and print out the name of the student, their lowest, highest and average grade.

            while (StudentName.ToLower() != "quit")
            {
                
                Console.WriteLine("Enter students grades seperated by spaces then hit enter: ");
                string Grades = Console.ReadLine();
                
                //Gradebook.Add(StudentName, Grades);
                //If the user enters a students name, your program should then ask the user to enter the students grades 
                //    as single string separated by spaces("100 90 78 101 45 81")
               


                //foreach (var student in Gradebook.Keys)
                //{
                    
                //}
            }

        }
    }
}
