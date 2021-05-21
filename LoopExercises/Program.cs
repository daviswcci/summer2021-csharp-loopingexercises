using System;

namespace LoopExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= -5; i--) // decreases from 5 until -5
            {
                if (i != 0) //ignores the middle line when we print no stars
                {
                    for (int k = 0; k < 5 - Math.Abs(i); k++) // prints an increasing number of spaces which then decreases after i = 0
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 2 * Math.Abs(i); j++) // prints a decreasing number of stars which then increases after i = 0
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            while (true) //while loop to allow for repeating inputs
            {
                Console.WriteLine("Enter a number:");
                string input = Console.ReadLine();
                int number;
                if (int.TryParse(input, out number))
                { // this code runs if our input is a number
                    int result = 1;
                    for (int i = number; i > 0; i--)
                    {
                        result *= i; // multiplies our result by i
                    }
                    Console.WriteLine(result);
                    break;
                }
                else
                { // this code runs if our input is not a number
                    Console.WriteLine("That's not a number! Try Again!");
                }
            }
        }
    }
}
