using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_01
    {
        // Bài 1: Tính tổng hai số nguyên
        static int Tinh_tong(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int kq = Tinh_tong(6,14);
            Console.WriteLine($"Tong cua 6 va 14 la: {kq}");
        }
    }
}
