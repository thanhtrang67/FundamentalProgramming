using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_03
{
    internal class Ex_05
    {
        public static void Run()
        {
            // 5. Swap Two Numbers
            Console.Write("Input the First number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the Second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After swapping:\n" +
                "First number: " + num1 + "\nSecond number: " + num2);
        }
    }
}
