using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_03
{
    internal class Ex_09
    {
        public static void Run()
        {
            // 9. Average of Four Numbers
            Console.Write("Enter the First number: ");
            int avg1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            int avg2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Third number: ");
            int avg3 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Fourth number: ");
            int avg4 = int.Parse(Console.ReadLine());
            int average = (avg1 + avg2 + avg3 + avg4) / 4;
            Console.WriteLine($"The average of {avg1}, {avg2}, {avg3}, {avg4} is: {average}");
        }
    }
}
