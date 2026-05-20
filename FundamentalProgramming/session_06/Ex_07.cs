using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_07
    {
        // Bài 7: In dãy Fibonacci, in n số đầu tiên của dãy Fibonacci.

        static void Fibonacci(int n)
        {
            int a = 0, b = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");
                int c = a + b;
                a = b;
                b = c;
            }   
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao day mot so: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Day Fibonacci la: " );
            Fibonacci(n);
        }
    }
}
