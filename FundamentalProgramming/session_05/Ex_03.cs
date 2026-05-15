using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_05
{
    internal class Ex_03
    {
        /// <summary>
        /// Write a C# function to check if a number is prime. The function accepts the number as an argument and returns true if the number is prime, otherwise false.
        /// </summary>
        /// <param name="n">số cần kiểm tra</param>
        /// <returns>true nếu là số nguyên tố, false nếu không phải</returns>
        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;   
        }
        static void Main(string[] args)
        {
            int m = 11;
            bool kq = IsPrime(m);
            if(kq)
                Console.WriteLine($"{m} la so nguyen to");
            else
                Console.WriteLine($"{m} khong phai so nguyen to");

        }
    }
}
