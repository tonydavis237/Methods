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
            Console.WriteLine("Please enter your name");

            // Creating a string variable from the users input
            string name = Console.ReadLine();

            char[] array1 = name.ToCharArray();

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] <= 9 || array1[i] >= 0)
                {
                    Console.WriteLine("Please input a name that fall within the correct parameters");
                    Console.WriteLine("Press any key to exit the program and try again");
                }
                else
                {
                    // Calling greet user method
                    greet_User(name);
                }
            }
        }
        // Method that takes the users input and greets them
        private static void greet_User (string input)
        {
            Console.WriteLine("Hello " + input + "!");
        }
    }
}
