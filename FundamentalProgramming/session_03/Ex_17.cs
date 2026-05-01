using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_03
{
    internal class Ex_17
    {
        public static void Run()
        {
            // 17. Add First Character to Front and Back
            string str2 = "The quick brown fox jumps over the lazy dog.";
            char firstChar = str2[0];
            Console.WriteLine($"{firstChar}{str2}{firstChar}");
        }
    }
}
