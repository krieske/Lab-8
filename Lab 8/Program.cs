using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // TO DO LIST:

            // UPDATE. method for exception handling/try catch on unacceptable inputs (string, int, null)
            // UPDATE. method for validation of user input # 1-5
            // UPDATE. method for validation for user input "food" "hometown"
            // call exception handling method in "foodcity method" to check input
            // loop for continuing asking about other 1-5 people 
            // ask if they want to play again

            // create array


         /*   string[] studentNames = { "person1", "person2", "person3", "person4", "person5" };
            string[] favoriteFood = { "food1", "food2", "food3", "food4", "food5" };
            string[] hometown = { "city1", "city2", "city3", "city4", "city5" };

            string playAgain = "yes";

            while (playAgain == "yes")
            {
                Console.WriteLine("Please pick a number 1-5 to learn about a student!");
                string studentNum = Console.ReadLine();
                studentNum = ValidateUserInput(studentNum);

                int x = int.Parse(studentNum);
                x = GetNumWithinRange(x);

                Console.WriteLine($"That is {studentNames[x - 1]}! Type 'hometown' or 'favorite food' to learn more!");
                Console.ReadLine();


                Console.WriteLine("Would you like to learn aboutsomeone else?")
            }
            Console.WriteLine("Ok! Goodbye!");
            Console.ReadLine();

        }

        public static string ValidateUserInput(string input)
        {

            try
            {
                int num = int.Parse(input);
            }
            catch (FormatException f)
            {
                Console.WriteLine("You did not enter a number.");
                return "0";
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
                return "0";
            }

            return input;
        } // validates user input, try-catch

        public static int GetNumWithinRange(int num)
        {
            int min = 1;
            int max = 5;

            while ((num > max) || (num < min))
            {
                Console.WriteLine("Please pick a number between 1 and 5.");
            }
            return num;
        }
            // finished

            /*public static string ValidateUserString()
            {
                string input = Console.ReadLine();

                while (input == null || !Regex.IsMatch(input, @"^\d{1,2}$"))
                {
                    Console.WriteLine("Please enter a valid number.");
                    input = Console.ReadLine();
                }
                return input;
            }// validates user input for food/city

            public static string ValidateStrRange()
            {
                string input = Console.ReadLine();

                while (input == null || !Regex.IsMatch(input, @"^\d{1,2}$"))
                {
                    Console.WriteLine("Please enter a valid number.");
                    input = Console.ReadLine();
                }
                return input;
            }// validates a-z range

            public static string ValidateFoodCity()
            {
                string input = Console.ReadLine();

                while (input == null || !Regex.IsMatch(input, @"^\d{1,2}$"))
                {
                    Console.WriteLine("Please enter a valid number.");
                    input = Console.ReadLine();
                }
                return input;
            }// needs loop, call validate string to ensure no exceptions thrown, null, etc */
        }

}
