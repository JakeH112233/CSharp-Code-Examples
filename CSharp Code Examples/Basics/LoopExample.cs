using System;

namespace CSharp_Code_Examples
{
    class LoopExample
    {
        //Authors: Jake Harper
        //Demonstrates basic looping of integers until 10 in c#

        public static void run()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
