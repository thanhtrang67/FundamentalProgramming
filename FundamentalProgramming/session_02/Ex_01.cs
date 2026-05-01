using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_02
{
    internal class Ex_01
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Đổi độ C sang độ F và K
            Console.Write("Nhập vào số độ C: ");
            float celsius = float.Parse(Console.ReadLine());
            float fahrenheit = (celsius * 9 / 5) + 32;
            float kelvin = celsius + 273;
            Console.WriteLine($"{celsius}°C = {fahrenheit}°F\n{celsius}°C = {kelvin}K");
            // Tính diện tích bề mặt và thể tích hình cầu
            Console.Write("Nhập vào bán kính của hình cầu: ");
            float radius = float.Parse(Console.ReadLine());
            float surface = 4 * (float)Math.PI * (float)Math.Pow(radius, 2);
            float volume = (4f / 3) * (float)Math.PI * (float)Math.Pow(radius, 3);
            Console.WriteLine($"Diện tích bề mặt của hình cầu là {surface}\nThể tích của hình cầu là {volume}");
            // Tính kết quả các phép tính
            Console.Write("Nhập vào số thứ nhất: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ hai: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            int quotient = num1 / num2;
            int remainder = num1 % num2;
            Console.WriteLine($"Kết quả phép tính:\n" +
                $"{num1} + {num2} = {sum}\n" +
                $"{num1} - {num2} = {difference}\n" +
                $"{num1} x {num2} = {product}\n" +
                $"{num1} / {num2} = {quotient}\n" +
                $"{num1} % {num2} = {remainder}");
        }
    }
}
