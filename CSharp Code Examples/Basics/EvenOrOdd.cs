using System;

namespace CSharp_Code_Examples
{
    class EvenOrOdd
    {
        // Authors: Jake Harper
        // Checks if a number is even or odd with full input validation

        public static void run()
        {
            Console.Write("Please enter an integer: ");
            string? input = Console.ReadLine();  

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error: No input received");
                return;
            }

            // Checks that the input is an integer
            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is an even number");
                }
                else
                {
                    Console.WriteLine($"{number} is an odd number");
                }
            }
            else
            {
                Console.WriteLine("Invalid input: Please enter an integer");
            }
        }
    }
}

