using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex__8
    {
        // Bài 8: Đếm số lượng nguyên âm trong chuỗi
        static int DemNguyenAm(string s)
        {
            int count = 0;
            foreach(char c in s)
            {
                char k = char.ToLower(c);
                if (k == 'a' || k == 'u' || k == 'e' || k == 'i' || k == 'o')
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot chuoi: ");
            string s = Console.ReadLine();
            int kq = DemNguyenAm(s);
            Console.WriteLine($"So luong nguyen am trong chuoi la {kq}");
        }
    }
}
