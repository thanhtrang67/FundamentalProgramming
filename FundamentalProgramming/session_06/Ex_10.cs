using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_10
    {
        // Bài 10: Tính điểm trung bình của mảng
        static double TinhTrungBinh(int[] arr)
        {
            double tong = 0;
            foreach (int i in arr)
                tong = tong + i;
            return tong / arr.Length;
        }
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 6, 7 };
            double tb = TinhTrungBinh(arr);
            Console.WriteLine($"Diem trung binh cua 4,5,6,7 la {tb}");
        }
    }
}
