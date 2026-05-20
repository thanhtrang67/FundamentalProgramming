using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_18
    {
        // Bài 18: Chuyển đổi hệ thập phân sang nhị phân
        static string DecimalToBinary(int n)
        {
            string kq = "";
            while(n > 0)
            {
                kq = (n % 2) + kq;
                n = n / 2;
            }
            return kq;
        }
        static void Main(string[] args)
        {
            int n = 10;
            string kq = DecimalToBinary(n);
            Console.WriteLine($"Chuyen {n} he thap phan sang nhi phan thanh {kq}");
        }

    }
}
