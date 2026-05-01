using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_03
{
    internal class Ex_12
    {
        public static void Run()
        {
            // 12. Repeat Number in Rows
            Console.Write("Enter the digit: ");
            int digit = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}", digit);
            Console.WriteLine("{0}{0}{0}{0}", digit);
            Console.WriteLine("{0} {0} {0} {0}", digit);
            Console.WriteLine("{0}{0}{0}{0}", digit);
        }
    }
}
