using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_07
{
    internal class Ex_02
    {
        //Requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 10 so nguyen: ");
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
                arr[i] = int.Parse(Console.ReadLine());
            BubbleSort(arr);
            Console.WriteLine("Mang sau khi sap xep");
            for (int i = 0; i < 10; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
