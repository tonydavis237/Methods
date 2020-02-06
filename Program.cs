/*
 * Author: Anthony Davis
 * Date: 02/06/2020
 * Description: Program used to write a method asking for user to input their name and responds with a greeting message
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
            Greet_User(name);
        }

        // Method that takes the users input and greets them
        private static void Greet_User(string input)
        {
            
            int count = 0;
            Boolean check = false;
            string str = input.Replace(" ", String.Empty);
            while (count < str.Length)
            {
                // Looks at the characters in string to see if they are true
                if (Char.IsLetter(str, count) == false)
                {
                    Console.WriteLine("Your input is not in the parameters of a correct name");
                    Console.WriteLine("Please press any key to exit the program and try again");
                    count = str.Length;
                    check = true;
                }
                else
                {
                    count++;
                }
            }

            if (check == false)
            {
                Console.WriteLine("Hello " + input + "!");
            }
        }
    }
}
