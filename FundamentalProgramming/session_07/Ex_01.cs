using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FundamentalProgramming.session_07
{
    internal class Ex_01
    {
        /// <summary>
        /// Sinh ngẫu nhiên n phần tử của mảng
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        static void phatsinh_mang(int[] a, int n)
        {
            Random rnd = new Random();
            for(int i = 0; i < n; i++)
                a[i] = rnd.Next(0, 100);
        }
        static void In_mang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write($"{a[i]} ");
            Console.WriteLine();
        }
        // 1.to calculate the average value of array elements.
        static double Avg(int[] arr)
        {
            double sum = 0, a = 0;
            foreach (int i in arr)
                sum += i;
            a = sum / arr.Length;
            return a;    
        }
        // 2.to test if an array contains a specific value.
        static bool Value(int[] arr, int x)
        {
            foreach (int i in arr)
            {
                if (i == x)
                    return true;
            }
            return false;
        }
        // 3.to find the index of an array element.
        static int Index(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == x)
                    return i;
            return -1;
        }
        // 4.to remove a specific element from an array.
        //Tìm phần tử cần xóa, nếu tìm thấy trả về true, nếu không tìm thấy trả về false
        static bool xoa_phantu(int[] arr, ref int n, int x)
        {
            for(int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    for(int j = i; j < n-1; j++)
                    {
                        arr[j] = arr[j+1];
                    }
                    n--;
                    return true;
                }
            }
            return false;
        }
        // 5.to find the maximum and minimum value of an array.
        static void Max_Min(int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];
            foreach(int i in arr)
            {
                if (i > max)
                    max = i;
                if (i < min)
                    min = i;
            }
        }
        // 6.to reverse an array of integer values.
        static void Dao_phantu(int[] arr, ref int n)
        {
            int temp;
            for (int i = 0; i < n/2; i++)
            {
                temp = arr[i];
                arr[i] = arr[n - 1 - i];
                arr[n - 1 - i] = temp;
            }
        }
        // 7.to find duplicate values in an array of values.
        static void Dem_trung(int[] arr, ref int n)
        {
            for(int i = 0; i< n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] == arr[i])
                        Console.Write(arr[i] + " ");
                }
            }
        }
        // 8.to remove duplicate elements from an array.
        static void Xoa_trung(int[] arr, ref int n)
        {
            for(int i = 0; i < n; i++)
            {
                int j = i + 1;
                while( j < n)
                {
                    if (arr[i] == arr[j])
                    {
                        for (int k = j; k < n - 1; k++)
                            arr[k] = arr[k + 1];
                        n--;
                    }
                    else j++;        
                }
            }
        }
       
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            phatsinh_mang(arr, n);
            In_mang(arr, n);
            
            double tb = Avg(arr);
            Console.WriteLine($"Gia tri trung binh cua mang la {tb}");

            int x = 19;
            bool kq1 = Value(arr, x);
            if(kq1)
                Console.WriteLine($"Mang co chua gia tri {x}");
            else
                Console.WriteLine($"Mang khong chua gia tri {x}");

            int index = Index(arr, x);
            Console.WriteLine(index);

            Console.Write("Nhap phan tu can xoa: ");
            int y = int.Parse(Console.ReadLine());
            bool kq2 = xoa_phantu(arr, ref n, y);
            if (!kq2)
                Console.WriteLine("Khong tim thay phan tu can xoa");
            else
                Console.Write("Mang sau khi xoa: ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i]+ " ");
            Console.WriteLine();

            Max_Min(arr, out int max, out int min);
            Console.WriteLine($"Gia tri lon nhat cua mang la {max}");
            Console.WriteLine($"Gia tri nho nhat cua mang la {min}");

            Dao_phantu(arr, ref n);
            Console.Write("Mang sau khi dao nguoc:");
            for(int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            Console.Write("Phan tu bi lap la ");
            Dem_trung(arr, ref n);
            Console.WriteLine();

            Console.WriteLine("Sau khi xoa phan tu bi trung: ");
            Xoa_trung(arr, ref n);
            for(int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");  
        }
    }
}
