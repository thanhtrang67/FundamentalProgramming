using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_10
{
    internal class Ex_02
    {
        static double TinhTong(double[] a)
        {
            double tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i];
            }
            return tong;
        }
        static double TinhTrungBinhCong(double[] a, double tong)
        {
            return tong / a.Length;
        }
        static void Main(string[] args)
        {
            // Bài 2: Tính tổng và trung bình cộng
            int n = int.Parse(Console.ReadLine());
            double [] a = new double[n];
            string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if(s.Length != n)  
            {
                Console.WriteLine("So luong phan tu khong khop");
                return;
            }
            for(int i = 0; i < n; i++)
            {
                a[i] = double.Parse(s[i]);
            }
            double tong = TinhTong(a);
            double tb = TinhTrungBinhCong(a, tong);
            Console.WriteLine($"{tong:F2} {tb:F2}");
        }
    }
}
