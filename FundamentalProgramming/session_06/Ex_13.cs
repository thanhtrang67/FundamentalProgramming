using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_13
    {
        // Bài 13: Tìm giá trị nhỏ nhất trong mảng
        static int TimMin(int[] arr)
        {
            int min = arr[0];
            foreach (int i in arr)
                if (i >= min)
                    min = i;
            return min;           
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 5, 8, 2, 9 };
            int min = TimMin(arr);
            Console.WriteLine($"Gia tri nho nhat trong mang la {min}");
        }
    }
}
