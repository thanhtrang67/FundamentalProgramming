using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_05
{
    internal class Ex_01
    {
        /// <summary>
        /// Write a C# function to find the maximum of three numbers.
        /// </summary>
        /// <param name="a">first params</param>
        /// <param name="b">second params</param>
        /// <param name="c">third params</param>
        /// <returns>số lớn nhất trong 3 số</returns>
        static int Max3(int a, int b, int c)
        {
            int max = a;
            if (b > max && b > c)
                max = b;
            else if (c > max && c > b)
                max = c;
            return max;
        }
        
        static void Main1(string[] args)
        {
            int a = 9, b = 13, c = 6;
            int result = Max3(a, b, c);
            Console.WriteLine($"Max of {a}, {b}, and {c} is {result}");
        }

        // Improve the next version that accept at least 1 parameter.
        static int Max3_V2(params int[]a) 
        {
            int max = a[0];
            foreach (int x in a)
                if (x > max)
                    max = x;
            return max;
        }
        static void Main(string[] args)
        {
            int m1 = Max3_V2(9, 12, 20);
            int m2 = Max3_V2(1, 2, 3);
            Console.WriteLine(m1);
            Console.WriteLine(m2);
        }   
    }
}
