using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_02
    {
        // Bài 2: Kiểm tra số chẵn lẻ
        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            if (KiemTraChan(n))
                Console.WriteLine($"{n} la so chan");
            else 
                Console.WriteLine($"{n} la so le");      
        }
    }
}
