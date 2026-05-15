using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_05
{
    internal class Ex_02
    {
        /// <summary>
        /// Write a C# function to calculate the factorial of a number (a non-negative integer).
        /// The function accepts the number as an argument.
        /// </summary>
        /// <param name="n">số nguyên dương</param>
        /// <returns>Tính giai thừa của n</returns>
        static long CalculateFactorial(int n)
        {
            long gt = 1;
            for (long i = 1; i <= n; i++)
                gt *= i;
            return gt;
        }
        static void Main(string[] args)
        {
            int n = 5;
            long gt = CalculateFactorial(n);
            Console.WriteLine($"{n}! = {gt}");
        }
        
    }
}
