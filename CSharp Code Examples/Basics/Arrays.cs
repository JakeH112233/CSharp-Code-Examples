using System;

namespace CSharp_Code_Examples
{
    class Arrays
    {
        //Authors: Jake Harper
        //Demonstrates basic arrays using a foreach loop in c#

        public static void run()
        {
            string[] fruits = { "Apple", "Banana", "Cherry", "Date" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
