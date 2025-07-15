using System;

namespace CSharp_Code_Examples
{
    class SimpleCalculator
    {
        // Authors: Jake Harper
        // Demonstrates basic arithmetic operations with error handling in C#

        public static void run()
        {
            try
            {
                Console.Write("Enter your first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter your second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Addition: {num1 + num2}");
                Console.WriteLine($"Subtraction: {num1 - num2}");
                Console.WriteLine($"Multiplication: {num1 * num2}");

                // Division with zero check
                if (num2 != 0)
                {
                    Console.WriteLine($"Division: {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Division: Cannot divide by zero!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numbers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
