using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_03
{
    internal class Ex_08
    {
        public static void Run()
        {
            // 8. Multiplication Table
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number} * 0 = {number * 0}\n" +
                $"{number} * 1 = {number * 1}\n" +
                $"{number} * 2 = {number * 2}\n" +
                $"{number} * 3 = {number * 3}\n" +
                $"{number} * 4 = {number * 4}\n" +
                $"{number} * 5 = {number * 5}\n" +
                $"{number} * 6 = {number * 6}\n" +
                $"{number} * 7 = {number * 7}\n" +
                $"{number} * 8 = {number * 8}\n" +
                $"{number} * 9 = {number * 9}\n" +
                $"{number} * 10 = {number * 10}");
        }
    }
}
