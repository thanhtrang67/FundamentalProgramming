using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_06
{
    internal class Ex_15
    {
        // Bài 15: Sắp xếp mảng tăng dần
        static void SapXepMang(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
            }
        }
        static void InMang(int[] arr)
        {
            foreach(int i in arr)
                Console.Write(i + " ");
        }

        static void Main(string[] args)
        {
            int[] arr = { 16, 24, 5, 49, 33, 51 };
            Console.Write($"Mang sau khi sap xep: ");
            SapXepMang(arr);
            InMang(arr);    
        }
    }
}
