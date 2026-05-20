using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_12
    {
        // Bài 12: Chuyển đổi nhiệt độ
        static double CelsiusToFahrenheit(double c)
        {
            double f = (c * 1.8) + 32;
            return f;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao do C: ");
            double c = double.Parse(Console.ReadLine());
            double f = CelsiusToFahrenheit(c);
            Console.WriteLine($"{c} do C = {f} do F");
        }
    }
}
