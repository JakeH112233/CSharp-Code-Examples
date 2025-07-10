using System;

namespace CSharp_Code_Examples
{
    class EvenOrOdd
    {
        //Authors: Jake Harper
        //Demonstrates basic if-else conditional logic in c#

        public static void run()
        {
            Console.Write("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number") ;

            }

        }
    }
}
