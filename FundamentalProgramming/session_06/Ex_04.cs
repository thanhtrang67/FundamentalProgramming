using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_04
    {
        // Bài 4: Tính giai thừa của một số
        static long TinhGiaiThua(int n)
        {
            int giai_thua = 1;
            for (int i = 1; i <= n; i++)
                giai_thua *= i;
            return giai_thua;
        }
        static void Main(string[] args)
        {
            long kq = TinhGiaiThua(6);
            Console.WriteLine($"Giai thua cua 6 la: {kq}");
        }
    }
}
