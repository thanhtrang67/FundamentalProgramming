using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_06
    {
        // Bài 6: Kiểm tra số nguyên tố
        static bool KiemTraNguyenTo(int n)
        {
            if (n <= 1)
                return false;
            for (int i = 2; i < Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            int m = 11;
            bool kq = KiemTraNguyenTo(m);
            if(kq)
                Console.WriteLine($"{m} la so nguyen to");
            else
                Console.WriteLine($"{m} khong phai la so nguyen to");
        }

    }
}
