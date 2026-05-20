using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_11
    {
        // Bài 11: Kiểm tra chuỗi đối xứng (Palindrome)
        static string DaoNguocChuoi(string input)
        {
            char[] char_arr = input.ToCharArray();
            Array.Reverse(char_arr);
            return new string (char_arr);
        }
        static bool Kiemtradoixung(string s, string input)
        {
            if (s == input)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot chuoi: ");
            string input = Console.ReadLine();
            string s = DaoNguocChuoi(input);
            bool kq = Kiemtradoixung(s, input);
            if(kq)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
