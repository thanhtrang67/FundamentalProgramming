using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_04
{
    internal class Ex_02
    {
        public static void Run(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Ex01();
            Ex02();
            Ex03();
        }

        static void Ex01()
        {
            // Write a C# Sharp program to check whether a given number is even or odd.
            Console.Write("Nhập vào một số: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Số bạn nhập là số chẵn.");
            }
            else
            {
                Console.WriteLine("Số bạn nhập là số lẻ.");
            }
        }

        static void Ex02()
        {
            // Write a C# Sharp program to find the largest of three numbers.
            Console.Write("Nhập vào số thứ nhất: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ hai: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ ba: ");
            int num3 = int.Parse(Console.ReadLine());
            int max = num1;
            if (num2 > max && num2 > num3)
            {
                max = num2;
            }
            else if (num3 > max && num3 > num2)
            {
                max = num3;
            }
            Console.WriteLine($"Số lớn nhất của 3 số {num1}, {num2} và {num3} là: {max}");
        }

        static void Ex03()
        {
            //Write a C# Sharp program to accept a coordinate point in an XY coordinate
            //system and determine in which quadrant the coordinate point lies.
            Console.Write("Nhập giá trị trên trục X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập giá trị trên trục Y: ");
            int y = int.Parse(Console.ReadLine());
            switch (x, y)
            {
                case ( > 0, > 0):
                    Console.WriteLine($"Điểm ({x}, {y}) nằm ở góc phần tư thứ nhất.");
                    break;
                case ( < 0, > 0):
                    Console.WriteLine($"Điểm ({x}, {y}) nằm ở góc phần tư thứ hai.");
                    break;
                case ( < 0, < 0):
                    Console.WriteLine($"Điểm ({x}, {y}) nằm ở góc phần tư thứ ba.");
                    break;
                case ( > 0, < 0):
                    Console.WriteLine($"Điểm ({x}, {y}) nằm ở góc phần tư thứ tư.");
                    break;
                default:
                    Console.WriteLine($"Điểm ({x}, {y}) nằm trên trục hoặc tại gốc tọa độ.");
                    break;
            }
        }
    }
}
