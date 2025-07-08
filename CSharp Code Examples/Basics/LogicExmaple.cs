using System;

namespace CSharp_Code_Examples
{
    class LogicExample 
    {
        //Authors: Jake Harper
        //Demonstrates basic if-else conditional logic in C#

        public static void run()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
}
