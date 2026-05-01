using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_03
{
    internal class Ex_14
    {
        public static void Run()
        {
            // 14. Celsius to Kelvin and Fahrenheit
            Console.WriteLine("Enter the amount of celsius: ");
            float celsius = float.Parse(Console.ReadLine());
            float fahrenheit = (celsius * 9 / 5) + 32;
            float kelvin = celsius + 273f;
            Console.WriteLine("Kelvin = " + kelvin);
            Console.WriteLine("Fahrenheit = " + fahrenheit);
        }
    }
}
