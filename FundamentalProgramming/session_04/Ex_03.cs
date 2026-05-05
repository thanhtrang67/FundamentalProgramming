using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_04
{
    internal class Ex_03
    {
        public static void Run(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Ex01();
            Ex02();
            Ex03();
            Ex04();
            Ex05();
            Ex06();
            Ex07();
            Ex08();
        }

        static void Ex01()
        {
            // Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
            Console.Write("Nhập độ dài cạnh thứ nhất: ");
            int c1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập độ dài cạnh thứ hai: ");
            int c2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập độ dài cạnh thứ ba: ");
            int c3 = int.Parse(Console.ReadLine());
            if (c1 == c2 && c2 == c3)
            {
                Console.WriteLine("Tam giác đều");
            }
            else if (c1 == c2 || c2 == c3 || c1 == c3)
            {
                Console.WriteLine("Tam giác cân");
            }
            else
            {
                Console.WriteLine("Tam giác thường");
            }
        }

        static void Ex02()
        {
            // Write a program to read 10 numbers and find their average and sum.
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhập số thứ {i + 1}: ");
                int so = int.Parse(Console.ReadLine());
                sum = sum + so;
            }
            int average = sum / 10;
            Console.WriteLine($"Tổng của 10 số là: {sum}");
            Console.WriteLine($"Trung bình của 10 số là: {average}");
        }

        static void Ex03()
        {
            // Write a program to display the multiplication table of a given integer.
            Console.Write("Nhập một số: ");
            int so = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{so} x {i} = {so * i}");
            }
        }

        static void Ex04()
        {
            //Write a program to display a pattern like triangles with a number.
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void Ex05()
        {
            //Write a program to display a pattern like a pyramid with a number like the following.
            int num = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }

            int num1 = 1;
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                // In đếm số khoảng trắng
                for (int k = 1; k <= n - i; k++)
                {
                    Console.Write(" ");
                }
                // In đếm số
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num1 + " ");
                    num1++;
                }
                Console.WriteLine();
            }
        }

        static void Ex06()
        {
            // Write a program to display the n terms of harmonic series and their
            //sum. 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5... 1 / n terms
            Console.Write("Nhập vào đây một số: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + 1.0 / i;
                Console.Write($"1/{i}");
                if (i < n)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine(" = " + sum);
        }

        static void Ex07()
        {
            // Write a program to find the ‘perfect’ numbers within a given number range.
            int n = 1000;
            for (int so = 6; so <= n; so++) // Duyệt từng số từ 6 -> n
            {
                int sum = 0;
                for (int i = 1; i <= so / 2; i++) // Duyệt từ 1 -> so/2 để tìm ước số của so
                {
                    if (so % i == 0) // Nếu i là ước số của so thì cộng nó vào tổng
                    {
                        sum = sum + i;
                    }
                }
                if (sum == so) // Nếu tổng các ước số bằng chính nó thì đó là số hoàn hảo
                {
                    Console.WriteLine("Số hoàn hảo: " + so);
                }
            }
        }

        static void Ex08()
        {
            // Write a program to determine whether a given number is prime or not.
            Console.Write("Nhập số cần kiểm tra: ");
            int so = int.Parse(Console.ReadLine());
            if (so < 2)
            {
                Console.WriteLine($"{so} không phải là số nguyên tố");
            }
            else
            {
                bool isPrime = true; //Giả sử số đó là số nguyên tố
                for (int i = 2; i <= Math.Sqrt(so); i++)
                {

                    if (so % i == 0)
                    {
                        isPrime = false;
                        break; // Nếu tìm thấy ước số nào chia hết thì không phải số nguyên tố, dừng vòng lặp
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine($"{so} là số nguyên tố");
                }
                else
                {
                    Console.WriteLine($"{so} không phải là số nguyên tố");
                }
            }
        }
    }
}
