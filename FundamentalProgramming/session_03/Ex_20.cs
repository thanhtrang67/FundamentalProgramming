using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_03
{
    internal class Ex_20
    {
        public static void Run()
        {
            // 20. Absolute Difference or Double It
            Console.WriteLine("Input first integer: ");
            int numC1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer: ");
            int numC2 = int.Parse(Console.ReadLine());
            int dif = Math.Abs(numC1 - numC2);
            if (numC1 > numC2)
            {
                Console.WriteLine($"{dif * 2}");
            }
        }
    }
}
