using System;

namespace CSharp_Code_Examples
{
    class TemperatureConverter
    {
        //Authors: Jake Harper
        //Converts Celsius to Fahrenheit in c#

        public static void run()
        {
            Console.Write("Please enter a temperature in Celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9/5) + 32;
            Console.WriteLine($"{celsius}°C is {fahrenheit}°F");
        }
    }
}
