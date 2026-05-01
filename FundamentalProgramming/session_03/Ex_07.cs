using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_03
{
    internal class Ex_07
    {
        public static void Run()
        {
            // 7. Arithmetic Operations
            Console.Write("Input the first number: ");
            int numA = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numA} + {numB} = {numA + numB}\n" +
                $"{numA} - {numB} = {numA - numB}\n" +
                $"{numA} * {numB} = {numA * numB}\n" +
                $"{numA} / {numB} = {numA / numB}\n" +
                $"{numA} % {numB} = {numA % numB}");
        }
    }
}
