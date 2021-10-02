using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bai1
{
    class Program
    {
        public struct sinhvien
        {
            public string mssv, hoten, tenhp;
            public double diemqt, diemthi, diemtk;
            public char xeploai;
        }
        public static void nhapsv(out sinhvien sv)
        {
            Console.Write("nhap mssv: ");
            sv.mssv = Console.ReadLine();
            Console.Write("nhap ho ten: ");
            sv.hoten = Console.ReadLine();
            Console.Write("nhap ten hoc phan: ");
            sv.tenhp = Console.ReadLine();
            Console.Write("nhap diem qua trinh: ");
            sv.diemqt = float.Parse(Console.ReadLine());
            Console.Write("nhap diem thi: ");
            sv.diemthi = float.Parse(Console.ReadLine());
            sv.diemtk = (sv.diemqt * 0.4) + (sv.diemthi * 0.6);
            if (sv.diemtk >= 8.5)
                sv.xeploai = 'A';
            else if (sv.diemtk > 7)
                sv.xeploai = 'B';
            else if (sv.diemtk > 5.5)
                sv.xeploai = 'C';
            else if (sv.diemtk > 4)
                sv.xeploai = 'D';
            else
                sv.xeploai = 'F';
        }
     
        //public static sinhvien[] docsv(sinhvien[] a)
        //{
        //    string duonngdan2 = @"D:\Ontap1";
        //    string output = "output2.txt";
        //    string ten = Path.Combine(duonngdan2, output);
        //    StreamReader sr = File.OpenText(ten);
        //    string buffer;
        //    int i = 0;
        //    while ((buffer = sr.ReadLine()) != null)
        //    {
        //        if (buffer != "")
        //        {
        //            a[i].mssv = buffer;
        //            buffer = sr.ReadLine();
        //            a[i].hoten = buffer;
        //            buffer = sr.ReadLine();
        //            a[i].tenhp = buffer;
        //            buffer = sr.ReadLine();
        //            a[i].diemqt = double.Parse(buffer);
        //            buffer = sr.ReadLine();
        //            a[i].diemthi = double.Parse(buffer);
        //            buffer = sr.ReadLine();
        //            a[i].diemtk = (a[i].diemqt * 0.4) + (a[i].diemthi * 0.6);              
        //        }
        //        else i++;
        //    }
        //    return a;
        //}
        //public static void sapxep(sinhvien[] sv, int n)
        //{
        //    sinhvien temp;
        //    for (int i = 0; i < n; ++i)
        //    {
        //        for (int j = i + 1; j < n; ++j)
        //        {
        //            if (sv[i].mssv > sv[j].mssv)
        //            {
        //                temp = sv[i];
        //                sv[i] = sv[j];
        //                sv[j] = temp;
        //            }
        //        }
        //    }
        //}
 
        
        public static void GhiSV2(sinhvien [] sv)
        {
            string duonngdan2 = @"D:\Ontap1";
            string output = "output2.txt";
            string ten = Path.Combine(duonngdan2, output);
            StreamWriter sw = File.CreateText(ten);
            {
                //int i;
                //if (sv[i].xeploai == 'A')
                    for (int i = 0; i < sv.Length; i++)
                    {
                        if (sv[i].xeploai == 'A')
                        {
                            sw.WriteLine(sv[i].mssv);
                            sw.WriteLine(sv[i].hoten);
                            sw.WriteLine(sv[i].tenhp);
                            sw.WriteLine(sv[i].diemqt);
                            sw.WriteLine(sv[i].diemthi);
                            sw.WriteLine(sv[i].diemtk);
                            sw.WriteLine(sv[i].xeploai);
                            sw.WriteLine();
                        }
                    }
            }
            sw.Close();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            sinhvien[] sv = new sinhvien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap sinh vien thu {0}", i + 1);
                nhapsv(out sv[i]);
            }
            GhiSV2(sv);
            //docsv(sv);
            Console.WriteLine("Ghi thanh cong!");
            Console.ReadKey();
        }
    }
}
