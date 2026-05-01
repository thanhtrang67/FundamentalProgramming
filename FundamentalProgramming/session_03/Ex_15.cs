using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_03
{
    internal class Ex_15
    {
        public static void Run()
        {
            // 15. Remove Character by Index
            string str = "w3resource";
            Console.WriteLine(str.Remove(1, 1));
            Console.WriteLine(str.Remove(9, 1));
            Console.WriteLine(str.Remove(0, 1));
        }
    }
}
