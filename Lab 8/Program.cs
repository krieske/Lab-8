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


            string[] studentNames = { "William C", "Samantha", "Patrick", "Chris S", "Zac" };
            string[] favoriteFood = { "meat in general", "pizza", "hot wings", "spaghetti", "steak" };
            string[] hometown = { "Detroit City", "Clawson", "Detroit City", "West Bloomfield", "Fayetteville" };

            string playAgain = "yes";

            while ((playAgain == "yes") || (playAgain == "y"))
            {
                Console.WriteLine("Please pick a number 1-5 to learn about a student!");


                int x = GetNumWithinRange();

                Console.WriteLine($"That is {studentNames[x - 1]}! Type 'hometown' or 'favorite food' to learn more!");
                //string foodOrCity = ValidateFoodCity();

                // Add code to get hometown or fav. food! 

                string food = ValidateFoodCity();
                if ((food == "food") || (food == "favorite food"))
                {
                    Console.WriteLine($"{studentNames[x - 1]}'s favorite food is {favoriteFood[x - 1]}.");
                }
                else if ((food == "city") || (food == "hometown"))
                {
                    Console.WriteLine($"{studentNames[x - 1]}'s hometown is {hometown[x - 1]}.");
                }

                Console.WriteLine($"Type 'hometown' or 'favorite food' to learn more!");

                string city = ValidateFoodCity();
                if ((city == "city") || (city == "hometown"))
                {
                    Console.WriteLine($"{studentNames[x - 1]}'s hometown is {hometown[x - 1]}.");
                }
                else if ((city == "food") || (city == "favorite food"))
                {
                    Console.WriteLine($"{studentNames[x - 1]}'s favorite food is {favoriteFood[x - 1]}.");
                }


                Console.WriteLine("Would you like to learn aboutsomeone else(yes/no)?");
                playAgain = Console.ReadLine();
            }
            Console.WriteLine("Ok! Goodbye!");
            Console.ReadLine();

        }

        public static int ValidateUserInput()
        {

            bool valid = false;
            int num = 0;
            while (!valid)
            {
                try
                {

                    num = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (FormatException f)
                {
                    Console.WriteLine("You did not enter a number.");

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error");

                }
            }
            return num;
        } // validates 1-5 in array w/ exception handling
        // finished

        public static int GetNumWithinRange()
        {
            int min = 1;
            int max = 5;

            int num = ValidateUserInput();
            while ((num > max) || (num < min))
            {
                Console.WriteLine("Please pick a number between 1 and 5.");
                num = ValidateUserInput();
            }
            return num;
        } // validates the 1-5 int is in range
        // finished

        public static string ValidateUserString()
        {
            bool valid = false;
            string input = "";
            while (!valid)
            {
                try
                {

                    input = Console.ReadLine();
                    valid = true;
                }
                catch (FormatException f)
                {
                    Console.WriteLine("You did not enter a valid response.");

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error");

                }
            }
            return input;
        }// validates input for food/city w/ exception handling


        public static string ValidateFoodCity()
        {
            string input = Console.ReadLine().ToLower();

            // input = ValidateUserString();
            while ((input != "food") && (input != "favorite food") && (input != "hometown") && (input != "city"))
            {
                Console.WriteLine("Please pick either 'favorite food' or 'hometown'.");
                input = ValidateUserString();
            }
            
            return input;
        }
    }

}
