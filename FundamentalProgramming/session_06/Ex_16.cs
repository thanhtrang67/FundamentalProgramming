using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_16
    {
        // Bài 16: Xóa ký tự trùng lặp
        static string XoaTrungLap(string s)
        {
            string kq = "";
            foreach (char c in s)
                if (!kq.Contains(c))
                    kq += c;
            return kq;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot chuoi: ");
            string s = Console.ReadLine();
            string kq = XoaTrungLap(s);
            Console.WriteLine($"Sau khi xoa ky tu trung lap: {kq}");

        }
    }
}
