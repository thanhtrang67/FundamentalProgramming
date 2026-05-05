using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_04
{
    internal class Ex_01
    {
        public static void Run(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Ex01();
            Ex02();
            Ex03();
            Ex04();
            Ex05();
        }

        static void Ex01()
        {
            // Write a C# Sharp program that takes two numbers as input and
            //performs an operation(+, -, *, x,/) on them and displays the result of that operation.
            Console.Write("Nhập số thứ nhất: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập phép toán (+, -, *, x, /): ");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
                    break;
                case "-":
                    Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
                    break;
                case "x":
                case "*":
                    Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine("Không thể chia cho 0");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
                    }
                    break;
            }
        }

        static void Ex02()
        {
            // Write a C# Sharp program to display certain values of the function x = y2 +2y + 1(using integer numbers for y, ranging from - 5 to + 5).
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"y = {y}, x = {x}");
            }
        }

        static void Ex03()
        {
            // Write a C# Sharp program that takes distance and time (hours, minutes,
            //seconds) as input and displays speed in kilometers per hour(km / h) and
            //miles per hour(miles/ h).
            Console.WriteLine("Nhập khoảng cách (km): ");
            double distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập thời gian (giờ): ");
            double hours = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập thời gian (phút): ");
            double minutes = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập thời gian (giây): ");
            double seconds = double.Parse(Console.ReadLine());
            double totalHours = hours + (minutes / 60) + (seconds / 3600);
            double speedKmh = distance / totalHours;
            double distanceMiles = distance * 0.621371; // 1 km = 0.621371 miles
            double speedMph = distanceMiles / totalHours;
            Console.WriteLine($"Vận tốc: {speedKmh:F2} km/h hoặc {speedMph:F2} miles/h");
        }

        static void Ex04()
        {
            // Write a C# Sharp program that takes the radius of a sphere as input and
            //calculates and displays the surface and volume of the sphere. V = 4 / 3 * π * r ^ 3.
            Console.WriteLine("Nhập bán kính của hình cầu: ");
            double radius = double.Parse(Console.ReadLine());
            double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
            double volume = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Diện tích bề mặt: {surfaceArea:F2}");
            Console.WriteLine($"Thể tích: {volume:F2}");
        }

        static void Ex05()
        {
            // Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
            Console.WriteLine("Nhập một ký tự: ");
            char ch = Console.ReadKey().KeyChar;
            char c = char.ToLower(ch); // Chuyển ký tự về chữ thường để dễ so sánh
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine($"\n'{ch}' là nguyên âm.");
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine($"\n'{ch}' là một chữ số.");
            }
            else
            {
                Console.WriteLine($"\n'{ch}' là một ký tự khác.");
            }
        }
    }    
}

