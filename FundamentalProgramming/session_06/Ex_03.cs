using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_03
    {
        // Bài 3: Tìm số lớn nhất trong ba số
        static int Tim_Max(int a, int b, int c)
        {
            int max = a;
            if (b > max && b > c)
                max = b;
            if (c > max && c > b)
                max = c;
            return max;
            // Cách khác: return Math.Max(a,Math.Max(b,c));
        }
        static void Main(string[] args)
        {
            int kq = Tim_Max(5, 10, 3);
            Console.WriteLine($"So lon nhat trong ba so 5, 10, 3 la: {kq}");
        }
    }
}
