using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_07
{
    internal class Ex_03
    {
        //Request a sentence from the user, then ask to enter a word. Search if the word appears in the phrase using the linear search algorithm.

        static string LinearSearch(string[] arr, string x)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == x)
                    return x;
            return null;
        }

        static string[] tao_mang(string cau)
        {
            string[] word = cau.Split(' ');
            return word;
        }   
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap mot cau: ");
            string cau = Console.ReadLine();
            Console.WriteLine("Nhap mot tu: ");
            string tu = Console.ReadLine();
            string[] arr = tao_mang(cau);
            string kq = LinearSearch(arr, tu);
            if(kq != null)
                Console.WriteLine($"Tu '{tu}' duoc tim thay trong cau.");
            else
                Console.WriteLine($"Tu '{tu}' khong duoc tim thay trong cau.");
        }
    }
}
