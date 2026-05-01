using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_03
{
    internal class Ex_19
    {
        public static void Run()
        {
            // 19. Sum or Triple Sum of Integers
            Console.WriteLine("Input first integer: ");
            int numB1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer: ");
            int numB2 = int.Parse(Console.ReadLine());
            int sum = numB1 + numB2;
            if (numB1 == numB2)
            {
                Console.WriteLine($"{sum * 3}");
            }
        }
    }
}
