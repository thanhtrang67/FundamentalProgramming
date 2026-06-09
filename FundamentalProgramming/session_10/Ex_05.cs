using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_10
{
    internal class Ex_05
    {
        static int TimViTri(int[] a, int x)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            // Bài 5: Tìm kiếm một số trong mảng
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if(s.Length != n)
            {
                Console.WriteLine("So luong phan tu khong khop!");
                return;
            }
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            int x = int.Parse(Console.ReadLine());
            int vitri = TimViTri(a, x);
            Console.WriteLine(vitri);
        }
    }
}
