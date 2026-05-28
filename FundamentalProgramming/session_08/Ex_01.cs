using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FundamentalProgramming.session_08
{
    internal class Ex_01
    {
        static void InChuoi(string s)
        {
            Console.WriteLine(s);
        }
        static int DoDaiChuoi(string s)
        {
            int len = 0;
            foreach(char c in s)
            {
                len++;
            }
            return len;
        }
        static void KyTu(string s)
        {
            foreach(char c in s)
            {
                Console.WriteLine(c);
            }
        }
        static void DaoNguocChuoi(string s)
        {
            foreach(char c in s.Reverse())
            {
                Console.WriteLine(c);
            }
        }
        static int DemSoTu(String s)
        {
            char[] sep = " ,.!?;:".ToArray();
            string[] tu = s.Split(sep,StringSplitOptions.RemoveEmptyEntries);
            return tu.Length;
        }
        /// <summary>
        /// to compare two strings without using a string library functions.
        /// </summary>
        /// <param name="s1">chuỗi cần so sánh 1</param>
        /// <param name="s2">chuỗi cần so sánh 2</param>
        /// <returns>
        /// 0: nếu 2 chuỗi bằng nhau
        /// 1: nếu s1 > s2
        /// -1: nếu s1 < s2
        /// </returns>
        static int SoSanhChuoi(string s1, string s2)
        {
            int len = s1.Length;
            if(s2.Length < len)
                len = s2.Length; 
            for(int i = 0; i < len; i++)
            {
                if (s1[i] < s2[i])
                {
                    return -1;
                }
                else if (s1[i] > s2[i])
                {
                    return 1;
                }
            }
            if (s1.Length < s2.Length)
            {
                return -1;

            }
            else if (s1.Length > s2.Length)
            {
                return 1;
            }
            return 0;
        }
        static void DemKyTu(string s, out int alphabet, out int digit, out int special)
        {
            alphabet = 0;
            digit = 0;
            special = 0;
            foreach (char c in s)
            {
                if (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z')
                    alphabet++;
                else if (c >= '0' && c <= '9')
                    digit++;
                else special++;
            }    
        }
        static void DemNguyenPhuAm(string s, out int vowel, out int consonant)
        {
            vowel = 0;
            consonant = 0;
            foreach(char c in s)
            {
                int lower = char.ToLower(c);
                if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
                    vowel++;
                else consonant++;
            }
        }
        static bool KiemTraChuoiCon(string s1, string s2)
        {
            for (int i = 0; i < s1.Length - s2.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i + j] != s2[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                    return true;
            }
            return false;
            /*if (s1.IndexOf(s2) != -1)
                return true;
            return false;*/
        }
        static int ViTriChuoiCon(string s1, string s2)
        {
            return s1.IndexOf(s2);
        }
        static void KiemTraChuCai(char c)
        {
            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
            {
                if (c >= 'A' && c <= 'Z')
                    Console.WriteLine("La chu hoa");
                else 
                    Console.WriteLine("La chu thuong");  
            }
            else
            {
                Console.WriteLine("Khong phai la chu cai");
            }
        }
        static int DemSoLanChuoiCon(string s1, string s2)
        {
            int count = 0;
            for (int i = 0; i < s1.Length - s2.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i + j] != s2[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                    count++;
            }
            return count;
        }
        static void ChenChuoiCon(ref string s1, string s2, string s3)
        {
            int pos = s1.IndexOf(s2);
            if (pos != -1)
            {
                s1 = s1.Insert(pos, s3);
            }
        }

        static void Main(string[] args)
        {
            // 1.to input a string and print it.
            Console.Write("Nhap vao day mot chuoi: ");
            string s = Console.ReadLine();
            InChuoi(s);
            // 2.to find the length of a string without using a library function.
            int dodai = DoDaiChuoi(s);
            Console.WriteLine($"Do dai cua chuoi la {dodai}");
            // 3.to separate individual characters from a string.
            Console.WriteLine("Cac ky tu trong chuoi la ");
            KyTu(s);
            // 4.to print individual characters of the string in reverse order.
            Console.WriteLine("Cac ky tu trong chuoi theo thu tu nguoc lai la ");
            DaoNguocChuoi(s);
            // 5.to count the total number of words in a string.
            int dem = DemSoTu(s);
            Console.WriteLine($"So tu trong chuoi la {dem}");
            // 6.to compare two strings without using a string library functions.
            Console.Write("Nhap vao day mot chuoi de so sanh: ");
            string str = Console.ReadLine();
            int kq = SoSanhChuoi(s, str);
            Console.WriteLine($"Ket qua so sanh: {kq}");
            // 7.to count the number of alphabets, digits and special characters in a string.
            DemKyTu(s, out int alphabet, out int digit, out int special);
            Console.WriteLine($"Trong chuoi co {alphabet} chu cai, {digit} chu so, {special} ky tu dac biet");
            // 8.to count the number of vowels or consonants in a string.
            DemNguyenPhuAm(s, out int vowel, out int consonant);
            Console.WriteLine($"Trong chuoi co {vowel} nguyen am va {consonant} phu am");
            // 9.to check whether a given substring is present in the given string.
            Console.Write("Nhap vao day chuoi chinh: ");
            string s1 = Console.ReadLine();
            Console.Write("Nhap vao day chuoi con: ");
            string s2 = Console.ReadLine();
            bool isPresent = KiemTraChuoiCon(s1, s2);
            Console.WriteLine($"Chuoi con co trong chuoi chinh: {isPresent}");
            // 10.to search for the position of a substring within a string.
            int vitri = ViTriChuoiCon(s1, s2);
            Console.WriteLine($"Vi tri cua chuoi con trong chuoi chinh: {vitri}");
            // 11.to check whether a character is an alphabet and not and if so, check for the case.
            Console.Write("Nhap vao day mot ki tu: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            KiemTraChuCai(c);
            // 12.to find the number of times a substring appears in a given string.
            int soLan = DemSoLanChuoiCon(s1, s2);
            Console.WriteLine($"Chuoi con xuat hien {soLan} lan trong chuoi chinh");
            // 13.to insert a substring before the first occurrence of a string.
            Console.Write("Nhap vao day chuoi de chen: ");
            string s3 = Console.ReadLine();
            ChenChuoiCon(ref s1, s2, s3);
            Console.WriteLine($"Chuoi sau khi chen: {s1}");
        }
    }
}
