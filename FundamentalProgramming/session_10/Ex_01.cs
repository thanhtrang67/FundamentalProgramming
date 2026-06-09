using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_10
{
    internal class Ex_01
    {
        //BÀI TẬP MẢNG 1 CHIỀU

        static void XuatMang(int[] a)
        {
            for(int i = 0; i < a.Length; i++) 
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            /* Bài 1: Nhập và xuất mảng */
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (s.Length != n)
            {
                Console.WriteLine("Số lượng phần tử không khớp!");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            XuatMang(a);
        }
    }
}
