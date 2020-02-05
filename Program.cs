/*
 * Author: Anthony Davis
 * Date: 02/06/2020
 * Description:
 */
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user for their name
            Console.WriteLine("Please enter your name ");

            // Creating a string variable from the users input
            string name = Console.ReadLine();

            // Calling greet user method
            greet_User(name);
        }

        // Method that takes the users input and greets them
        private static void greet_User(string input)
        {
            // Create integer variable for a whileloop count
            int i = 0;

            // Boolean used to check if user correctly inputed information
            Boolean check = false;

            // While loop to go through the user input to check for integer
            while (i < input.Length)
            {
                // Looks at the characters in string to see if they are true
                if (Char.IsNumber(input, i) == true)
                {
                    Console.WriteLine("Your input is not in the parameters of a correct name");
                    Console.WriteLine("Please press any key to exit the program and try again");
                    i = input.Length;
                     check = true;

                }
                else
                {
                    i++;
                }
            }
            // Show greeting display if there is no valid input
            if (check == false)
            {
                Console.WriteLine("Hello " + input + "!");
            }
        }
    }
}
