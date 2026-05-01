using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_03
{
    internal class Ex_18
    {
        public static void Run()
        {
            // 18. Check Positive and Negative Pair
            Console.WriteLine("Input first integer: ");
            int numA1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer: ");
            int numA2 = int.Parse(Console.ReadLine());
            if ((numA1 < 0 && numA2 > 0) || (numA1 > 0 && numA2 < 0))
            {
                Console.WriteLine("True");
            }
        }
    }
}
