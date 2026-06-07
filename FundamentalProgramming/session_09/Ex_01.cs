using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming.session_09
{
    internal class Ex_01
    {
        static void TaoFile(string TenFile)
        {
            if (!File.Exists(TenFile))
            {
                File.Create(TenFile).Close();
                Console.WriteLine(Path.GetFullPath(TenFile));
            }
            else
            {
                Console.WriteLine("File da ton tai");
            }
        }
        static void XoaFile(string TenFile)
        {
            if (File.Exists(TenFile))
            {
                File.Delete(TenFile);
                Console.WriteLine("Da xoa File");
            }
            else
            {
                Console.WriteLine("File khong ton tai");
            }
        }
        static void TaoFileVaThemText(string TenFile)
        {
            using (StreamWriter sw = new StreamWriter(TenFile))
            {
                sw.WriteLine("Hello World");
            }
            // File.WriteAllText(TenFile, NoiDung);
            Console.WriteLine("Da tao File va them noi dung");
        }
        static void TaoFile_DocText(string TenFile)
        {
            using (StreamWriter sw = new StreamWriter(TenFile))
            {
                sw.WriteLine("Hello World!");
            }
            using (StreamReader sr = new StreamReader(TenFile))
            {
                string s = sr.ReadToEnd();
                Console.WriteLine("Noi dung trong file: " + s);
            }
        }
        static void VietMangChuoi(string tenFile)
        {
            if (!File.Exists(tenFile))
            {
                File.Create(tenFile).Close();
            }
            string[] name = { "Nguyen Van A", "Le Thi B", "Tran Van C" };
            using (StreamWriter sw = new StreamWriter(tenFile))
            {
                foreach(string s in name)
                {
                    sw.WriteLine(s);
                }
            }    
        }
        static void ThemTextVaoFile(string TenFile)
        {
            if (File.Exists(TenFile))
            {
                using (StreamWriter sw = new StreamWriter(TenFile, true))
                {
                    sw.WriteLine("Ly Van D");
                }
            }
            else
            {
                Console.WriteLine("File khong ton tai");
            }
            // File.AppendAllText(TenFile, NoiDung);
        }
        static void TaoCopyVaDoc(string tenFile)
        {
            string copyFile = "copy_" + tenFile;
            if (File.Exists(tenFile))
            {
                File.Copy(tenFile, copyFile, true);
                Console.WriteLine("Da copy file");
                using (StreamReader sr = new StreamReader(copyFile))
                {
                    string s = sr.ReadToEnd();
                    Console.WriteLine("Noi dung trong file copy: \n" + s);
                }
            }
            else
            {
                Console.WriteLine("File khong ton tai");
            }
        }
        static void DiChuyenFile(string tenFile)
        {
            string newFile = "new_" + tenFile;
            if (File.Exists(tenFile))
            {
                if (File.Exists(newFile))
                {
                    File.Delete(newFile);
                }
                File.Move(tenFile, newFile);
                Console.WriteLine("Da di chuyen file");
            }
            else
            {
                Console.WriteLine("File khong ton tai");
            }
        }
        static void DocDongDau(string tenFile)
        {
            if (File.Exists(tenFile))
            {
                using (StreamReader sr = new StreamReader(tenFile))
                {
                    string s = sr.ReadLine(); // Doc dong dau tien trong file
                    if(s != null)
                    {
                        Console.WriteLine("Dong dau tien trong file: " + s);
                    }
                    else
                        Console.WriteLine("File rong");
                }
            }
            else
            {
                Console.WriteLine("File khong ton tai");
            }
        }
        static void DocDongCuoi(string tenFile)
        {
            if (File.Exists(tenFile))
            {
                using (StreamReader sr = new StreamReader(tenFile))
                {
                    string lastLine = null;
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        lastLine = line; // Luu dong cuoi cung doc duoc vao bien lastLine
                    }
                    if (lastLine != null)
                    {
                        Console.WriteLine("Dong cuoi cung trong file: " + lastLine);
                    }
                    else
                        Console.WriteLine("File rong");
                }
            }
            else
            {
                Console.WriteLine("File khong ton tai");
            }   
        }
        static void DocNDongCuoi(string tenFile, int n)
        {
            if (File.Exists(tenFile))
            {
                string[] dong = File.ReadAllLines(tenFile);
                if(n > dong.Length) 
                {
                    Console.WriteLine("File khong du dong");
                    return;
                }
                for(int i = dong.Length - n; i < dong.Length; i++)
                {
                    Console.WriteLine(dong[i]); 
                }
            }
            else
            {
                Console.WriteLine("File khong ton tai");
            }
        }
        static void DocDongBatKy(String tenFile, int m)
        {
            if (File.Exists(tenFile))
            {
                string[] dong = File.ReadAllLines(tenFile);
                if (m > 0 && m <= dong.Length)
                {
                    Console.WriteLine(dong[m - 1]);
                }
                else
                    Console.WriteLine("So dong khong hop le");
            }
            else
            {
                Console.WriteLine("File khong ton tai");
            }
        }
        static int DemSoDong(string tenFile)
        {
            if (File.Exists(tenFile))
            {
                int dem = 0;
                using (StreamReader sr = new StreamReader(tenFile))
                {
                    while (sr.ReadLine() != null)
                    {
                        dem++;
                    }
                    return dem;
                }
            }
            else
            {
                Console.WriteLine("File khong ton tai");
                return 0;
            }
        }
        static void InCauTrucThuMuc(string thumuc)
        {
            if (Directory.Exists(thumuc))
            {
                string[] dirs = Directory.GetDirectories(thumuc);
                string[] files = Directory.GetFiles(thumuc);
                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                }
                Console.WriteLine("Các file trong " + thumuc + ":");
                foreach (string file in files)
                {
                    Console.WriteLine("\t" + file);
                }
            }
            else
            {
                Console.WriteLine("Thu muc khong ton tai");
            }
        }
        static void ThongKeKyTuVaSo(string tenFile)
        {
            if (File.Exists(tenFile))
            {
                string text = File.ReadAllText(tenFile);
                int kytu = 0, so = 0;
                foreach(char c in text)
                {
                    if (char.IsLetter(c))
                    {
                        kytu++;
                    }
                    else if (char.IsDigit(c))
                    {
                        so++;
                    }
                }
                Console.WriteLine("Số ký tự trong file: " + kytu);
                Console.WriteLine("Số chữ số trong file: " + so);
            }
            else
            {
                Console.WriteLine("File khong ton tai");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // 1.to create a blank file on the disk.
            TaoFile("data.txt");
            Console.WriteLine("1.Đã tạo file trống trên ổ đĩa");
            // 2.to remove a file from the disk.
            XoaFile("data.txt");
            Console.WriteLine("2.Đã xóa file từ ổ đĩa");
            // 3.to create a file and add some text.
            TaoFileVaThemText("data.txt");
            Console.WriteLine("3.Đã tạo file và thêm chữ");
            // 4.create a text file and read it.
            TaoFile_DocText("data.txt");
            Console.WriteLine("4.Đã tạo file có chữ và đọc nội dung");
            // 5.to create a file and write an array of strings to the file.
            VietMangChuoi("data.txt");
            Console.WriteLine("5.Đã tạo file và viết mảng chuỗi");
            // 6.to append some text to an existing file.
            ThemTextVaoFile("data.txt");
            Console.WriteLine("6.Đã thêm chữ vào file có sẵn");
            // 7.to create and copy the file to another name and display the content.
            TaoCopyVaDoc("data.txt");
            Console.WriteLine("7.Đã tạo bản sao file và đọc nội dung");
            // 8.create a file and move it into the same directory with another name.
            DiChuyenFile("data.txt");
            Console.WriteLine("8.Đã di chuyển file");
            // 9.read the first line of a file.
            DocDongDau("new_data.txt");
            Console.WriteLine("9.Đã đọc dòng đầu tiên của file");
            // 10.to create and read the last line of a file.
            DocDongCuoi("new_data.txt");
            Console.WriteLine("10.Đã đọc dòng cuối cùng của file");
            // 11.create and read the last n lines of a file.
            Console.Write("Nhập vào số dòng cuối của file muốn đọc: ");
            int n = int.Parse(Console.ReadLine());
            DocNDongCuoi("new_data.txt", n);
            Console.WriteLine("11.Đã đọc n dòng cuối cùng của file");
            // 12.to read a specific line from a file.
            Console.Write("Nhập vào dòng muốn đọc: ");
            int m = int.Parse(Console.ReadLine());
            DocDongBatKy("new_data.txt", m);
            Console.WriteLine("12.Đã đọc dòng cụ thể của file");
            // 13.to count the number of lines in a file.
            int soDong = DemSoDong("new_data.txt");
            Console.WriteLine("Số dòng trong file: " + soDong);
            Console.WriteLine("13.Đã đếm số dòng trong file");
            // 14.To print the structure of specific folder (include files)
            string thumuc = @"C:\Users\Dell\source\repos\FundamentalProgramming";
            InCauTrucThuMuc(thumuc);
            Console.WriteLine("14.Đã in cấu trúc thư mục");
            // 15.Read a text file, then statistic the appearance of characters and numbers.
            ThongKeKyTuVaSo("new_data.txt");
            Console.WriteLine("15.Đã thống kê ký tự và số trong file");
        }
    }
}


