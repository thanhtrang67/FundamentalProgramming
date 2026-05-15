using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FundamentalProgramming.session_05
{
    internal class Ex_06
    {
        /// <summary>
        /// Write a C# function to check whether a string is a pangram or not.
        /// </summary>
        /// <param name="str">Một chuỗi</param>
        /// <returns>Chuỗi đó có phải là pangram không</returns>
        static bool IsPangram(string str)
        {
            bool[] visited = new bool[26];
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    char lower = char.ToLower(c);
                    int index = lower - 'a';
                    if (visited[index] == false)
                    {
                        visited[index] = true;
                        count++;
                    }
                }     
            }
           if (count == 26)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao day mot chuoi: ");
            string str = Console.ReadLine();
            if (IsPangram(str))
            {
                Console.WriteLine("Day la mot pangram.");
            }
            else
            {
                Console.WriteLine("Day khong phai la mot pangram.");
            }
        }
    }
}
