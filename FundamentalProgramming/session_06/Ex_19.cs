using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_19
    {
        // Bài 19: Kiểm tra năm nhuận
        static bool KiemTraNamNhuan(int year)
        {
            if (year % 400 == 0)
                return true;
            if (year % 4 == 0 && year % 100 != 0)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nam: ");
            int year = int.Parse(Console.ReadLine());
            bool kq = KiemTraNamNhuan(year);
            if(kq)
                Console.WriteLine($"{year} la nam nhuan");
            else
                Console.WriteLine($"{year} khong la nam nhuan");
        }
    }
}
