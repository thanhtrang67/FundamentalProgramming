using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_10
{
    internal class Ex_06
    {
        static void DaoNguocMang(int[] a, int n)
        {
            for(int i = 0; i < n/2; i++) 
            {
                int temp = a[i];
                a[i] = a[n - 1 - i];
                a[n - 1 - i] = temp;  
            } 
        }
        static void Main(string[] args)
        {
            // Bài 6: Đảo ngược mảng (Không dùng mảng phụ)
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if(s.Length != n) 
            {
                Console.WriteLine("So luong phan tu khong khop");
                return;
            }
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            DaoNguocMang(a, n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
