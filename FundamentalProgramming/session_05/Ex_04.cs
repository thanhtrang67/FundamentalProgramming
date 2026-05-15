using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_05
{
    internal class Ex_04
    {
        /// <summary>
        /// Write a C# function to print
        /// 1. all prime numbers that less than a number(enter prompt keyboard).
        /// 2. the first N prime numbers
        /// </summary>
        /// <param name="n">số cần kiểm tra</param>
        /// <returns>số nguyên tố nhỏ hơn n và n số nguyên tố đầu tiên</returns>
        static void PrintFirstNPrime(int n)
        {
            for (int i = 2; i < n; i++)
                if(IsPrime(i))
                    Console.Write($"{i}, ");      
        }
        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            for (int j = 2; j <= Math.Sqrt(n); j++)
                if (n % j == 0)
                    return false;
            return true;
        }
        static int CountPrime(int n)
        {
            int count = 0;
            for (int i = 2; i < n; i++)
                if (IsPrime(i))
                    count++;
            return count;
        }
        static void Main(string[] args)
        {
            int n = 100;       
            PrintFirstNPrime(n);
            Console.WriteLine();
            int kq = CountPrime(n);
            Console.WriteLine($"So luong so nguyen to nho hon {n} la {kq}"); 
        }
    }
}
