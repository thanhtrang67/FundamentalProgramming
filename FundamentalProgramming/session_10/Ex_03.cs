using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_10
{
    internal class Ex_03
    {
        static void TimMaxMin(int[] a, out int max, out int min)
        {
            max = a[0];
            min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
        }

        static void Main(string[] args)
        {
            // Bài 3: Tìm số lớn nhất và nhỏ nhất
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (s.Length != n)
            {
                Console.WriteLine("So luong phan tu khong khop!");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            TimMaxMin(a, out int max, out int min);
            Console.WriteLine($"{max} {min}");
        }
    }
}
