using System;

namespace CSharp_Code_Examples
{
    class Calculator
    {
        //Authors: Jake Harper
        //Demonstrates basic arithmetic operations in c#

        public static void run()
        {
            Console.Write("Enter your first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Addition: {num1 + num2}");
            Console.WriteLine($"Subtraction: {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1 * num2}");
            Console.WriteLine($"Division: {num1 / num2}");
        }
    }
}
