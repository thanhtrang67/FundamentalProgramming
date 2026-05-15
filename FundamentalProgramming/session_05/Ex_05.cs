using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_05
{
    internal class Ex_05
    {
        /// <summary>
        /// Write a C# function to check whether a number is "Perfect" or not. 
        /// Then print all perfect number that less than 1000.
        /// </summary>
        /// <param name="n">Số cần kiểm tra</param>
        /// <returns>Kiểm tra số đó là số hoàn hảo hay không và in các số hoàn hảo nhỏ hơn 1000</returns>
        static bool IsPerfect(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0)
                    sum += i;
            if (sum == n)
                return true;
            return false;
        }
        static void PrintPerfectNumbers(int n)
        {
            for(int i = 1; i < n; i++)
                if(IsPerfect(i))
                    Console.Write($"{i}, ");
        }
        static void Main(string[] args)
        {
            int n = 6;
            if(IsPerfect(n))
                Console.WriteLine($"{n} la so hoan hao");
            else
                Console.WriteLine($"{n} khong phai so hoan hao");
            int m = 1000;
            Console.Write($"Cac so hoan hao nho hon {m} la ");
            PrintPerfectNumbers(m);
        }
    }
}
