using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_14
    {
        // Bài 14: Tính tổng các chữ số của một số nguyên
        static int TongCacChuSo(int n)
        {
            int tong = 0;
            while(n > 0)
            {
                tong += n % 10;
                n /= 10;    
            }
            return tong;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap cac chu so: ");
            int n = int.Parse(Console.ReadLine());
            int tong = TongCacChuSo(n);
            Console.WriteLine($"Tong cac chu so la {tong}");
        }
    }
}
