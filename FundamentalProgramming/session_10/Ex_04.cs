using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_10
{
    internal class Ex_04
    {
        static void DemChanLe(int[] a, out int chan, out int le)
        {
            chan = 0; le = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    chan++;
                }
                else
                {
                    le++;
                }
            }
        }
        
        static void Main(string[] args)
        {
            // Bài 4: Đếm số chẵn và số lẻ
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
            DemChanLe(a, out int chan, out int le);
            Console.WriteLine($"{chan} {le}");
        }
    }
}
