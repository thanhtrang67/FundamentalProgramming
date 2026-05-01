using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_03
{
    internal class Ex_11
    {
        public static void Run()
        {
            // 11. Print Age Message
            Console.Write("Enter your age - ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"You look older than {age}");
        }
    }
}
