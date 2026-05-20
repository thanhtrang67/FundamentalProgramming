using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_17
    {
        // Bài 17: Tìm ước chung lớn nhất (UCLN)
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Hay nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            int kq = UCLN(a, b);
            Console.WriteLine($"Uoc chung lon nhat cua {a} va {b} la {kq}");
        }
    }
}
