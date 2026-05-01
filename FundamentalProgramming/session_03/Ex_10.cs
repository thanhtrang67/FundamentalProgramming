using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_03
{
    internal class Ex_10
    {
        public static void Run()
        {
            // 10. Specified Formula with Three Numbers
            Console.Write("Enter first number - ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number - ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter third number - ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine($"Result of specified numbers {x}, {y} and {z}, (x+y)*z = {(x + y) * z} and x*y + y*z = {x * y + y * z}");
        }
    }
}
