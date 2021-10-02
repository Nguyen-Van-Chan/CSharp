using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ontap1
{
    class Program
    {
     public  struct Sinhvien
       {
         public string MSSV;
         public string Hoten;
         public string Dienthoai;
         public float diemtoan;
         public float diemly;
         public float dtb;
       }
        public static void nhap(out Sinhvien sv)
    {
        Console.Write("nhap mssv: ");
            sv.MSSV = Console.ReadLine();
            Console.Write("nhap hoten: ");
            sv.Hoten = Console.ReadLine();
            Console.Write("nhap dien thoai: ");
            sv.Dienthoai = Console.ReadLine();
            Console.Write("nhap diem toan: ");
            sv.diemtoan = int.Parse(Console.ReadLine());
            Console.Write("nhap diem ly: ");
            sv.diemly = int.Parse(Console.ReadLine());
            sv.dtb = (sv.diemtoan + sv.diemly) / 2;
    }
        public static Sinhvien[] DocSV(Sinhvien[]a)
        {
            string duonngdan = @"D:\Ontap1";
            string input = "input.txt";
            string name = Path.Combine(duonngdan, input);
            StreamReader sr = File.OpenText(name);
            string buffer;
            int i = 0;
            while((buffer = sr.ReadLine())!=null)
            {
                if (buffer != "")
                {
                    a[i].MSSV = buffer;
                    buffer = sr.ReadLine();
                    a[i].Hoten = buffer;
                    buffer = sr.ReadLine();
                    a[i].Dienthoai = buffer;
                    buffer = sr.ReadLine();
                    a[i].diemtoan = float.Parse(buffer);
                    buffer = sr.ReadLine();
                    a[i].diemly = float.Parse(buffer);
                    buffer = sr.ReadLine();
                    a[i].dtb = (a[i].diemtoan + a[i].diemly) / 2;
                }
                else i++;
            }
            return a;
        }
        public static void GhiSV(Sinhvien[]sv)
        {
            string duonngdan = @"D:\Ontap1";
            string input = "input.txt";
            string name = Path.Combine(duonngdan, input);
            StreamWriter sw = File.CreateText(name);
            for (int i = 0; i < sv.Length; i++)
            {
                sw.WriteLine(sv[i].MSSV);
                sw.WriteLine(sv[i].Hoten);
                sw.WriteLine(sv[i].Dienthoai);
                sw.WriteLine(sv[i].diemtoan);
                sw.WriteLine(sv[i].diemly);
                sw.WriteLine();
            }
            sw.Close();
        }
        public static void GhiSV2(Sinhvien[] sv)
        {
            string duonngdan2 = @"D:\Ontap1";
            string output = "output.txt";
            string ten = Path.Combine(duonngdan2, output);
            StreamWriter sw = File.CreateText(ten);
            for (int i = 0; i < sv.Length; i++)
            {
                sw.WriteLine(sv[i].MSSV);
                sw.WriteLine(sv[i].Hoten);
                sw.WriteLine(sv[i].Dienthoai);
                sw.WriteLine(sv[i].diemtoan);
                sw.WriteLine(sv[i].diemly);
                sw.WriteLine(sv[i].dtb);
                sw.WriteLine();
            }
            sw.Close();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            Sinhvien[] sv = new Sinhvien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh vien thu {0} la: ", i + 1);
                nhap(out sv[i]);
            }
            GhiSV(sv);
            Console.WriteLine("ghi thanh cong");
            DocSV(sv);
            GhiSV2(sv);
            Console.WriteLine("Tao thanh cong!");
            Console.ReadKey();        
        }
    }
}
