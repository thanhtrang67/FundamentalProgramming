using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_10
{
    internal class Ex_07
    {
        static bool KiemTraDoiXung(int[] a, int n)
        {
            for(int i = 0; i< n/2; i++)
            {
                if (a[i] != a[n - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            // Bài 7: Kiểm tra mảng đối xứng
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if(s.Length != n)
            {
                Console.WriteLine("So phan tu khong khop");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            bool kq = KiemTraDoiXung(a, n);
            if (kq)
            {
                Console.WriteLine("YES");
            }
            else
                Console.WriteLine("NO");
        }
    }
}
