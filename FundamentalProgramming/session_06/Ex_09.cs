using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_09
    {
        // Bài 9: Tính lũy thừa
        static double TinhLuyThua(Double x, int y)
        {
            double LuyThua = 1;
            for(int i = 1; i <= y; i++)
            {
                LuyThua = LuyThua * x;
            }
            return LuyThua;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao co so x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so mu y: ");
            int y = int.Parse(Console.ReadLine());
            double kq = TinhLuyThua(x, y);
            Console.WriteLine($"Luy thua cua {x}^{y} la {kq}");
        }
    }
}
