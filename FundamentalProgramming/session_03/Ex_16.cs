using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_03
{
    internal class Ex_16
    {
        public static void Run()
        {
            // 16. Swap First and Last Characters
            string str1 = "w3resource";
            char first = str1[0];
            int l = str1.Length;
            char last = str1[l - 1];
            char temp1 = first;
            first = last;
            last = temp1;
            Console.WriteLine($"{first}{str1.Substring(1, l - 2)}{last}");
        }
    }
}
