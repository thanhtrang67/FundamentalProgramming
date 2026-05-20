using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_20
    {
        // Bài 20: Đếm số từ trong câu
        static int DemSoTu(string sentence)
        {
            string[] tu = sentence.Split(' ');
            return tu.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap mot cau: ");
            string sentence = Console.ReadLine();
            int tu = DemSoTu(sentence);
            Console.WriteLine($"So luong tu co trong cau la {tu}");
        }
    }
}
