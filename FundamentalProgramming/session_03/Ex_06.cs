using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_03
{
    internal class Ex_06
    {
        public static void Run()
        {
            // 6. Multiply Three Numbers
            Console.Write("Input the first number to multiply: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            int a3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a1} x {a2} x {a3} = {a1 * a2 * a3}");
        }
    }
}
