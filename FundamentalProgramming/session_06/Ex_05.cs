using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_05
    {
        // Bài 5: Đảo ngược chuỗi ký tự
        static string DaoNguocChuoi(string input)
        {
            char[] char_arr = input.ToCharArray();
            Array.Reverse(char_arr);
            return new string(char_arr);
        }
        static void Main(string[] args)
        {
            string input = "Hello, World!";
            string kq = DaoNguocChuoi(input);
            Console.WriteLine($"Chuoi sau khi dao nguoc: {kq}");
        }
    }
}
