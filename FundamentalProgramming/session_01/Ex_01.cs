using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FundamentalProgramming.session_01
{
    internal class Ex_01
    {

        public static void Run()
        {
            // 1. to Add / Sum Two Numbers.
            int a = 9 + 12;
            Console.WriteLine($"9 + 12 = {a}");
            // 2. to Swap Values of Two Variables.
            int b = 4, c = 10;
            Console.WriteLine($"Truoc khi hoan doi: b = {b}, c = {c}");
            int temp = b;
            b = c;
            c = temp;
            Console.WriteLine($"Sau khi hoan doi: b = {b}, c = {c}");
            // 3. to Multiply two Floating Point Numbers
            float d = 3.5f, e = 2.0f;
            float result = d * e;
            Console.WriteLine($"{d} * {e} = {result}");
            // 4. to convert feet to meter
            float feet = 10.0f;
            float meters = feet * 0.3048f;
            Console.WriteLine($"{feet} feet = {meters} meters");
            // 5. to convert Celsius to Fahrenheit and vice versa
            float celsius = 25.0f;
            float fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
            float fah = 30.0f;
            float cel = (fah - 32) * 5 / 9;
            Console.WriteLine($"{fah}°F = {cel}°C");
            // 6. to find the Size of data types
            Console.WriteLine($"Size of float is {sizeof(float)} bytes");
            Console.WriteLine($"Size of long is {sizeof(long)} bytes");
            // 7. to Print ASCII Value (tip: read character, print number of this char)
            char character = 'A';
            int asciiValue = character;
            Console.WriteLine($"Gia tri ASCII cua {character} la {asciiValue}");
            // 8. to Calculate Area of Circle
            float radious = 5.0f;
            float area = (float)(Math.PI * Math.Pow(radious, 2));
            Console.WriteLine($"Dien tich hinh tron co ban kinh {radious} la {area}");
            // 9. to Calculate Area of Square
            float side = 4.0f;
            float areaSquare = (float)(Math.Pow(side, 2));
            Console.WriteLine($"Dien tich hinh vuong co canh {side} la {areaSquare}");
            // 10. to convert days to years, weeks and days
            int totalDays = 400;
            int years = totalDays / 365;
            int remainingDays = totalDays % 365;
            int weeks = remainingDays / 7;
            int days = remainingDays % 7;
            Console.WriteLine($"{totalDays} ngay = {years} nam, {weeks} tuan, {days} ngay");
        }
    }
}
