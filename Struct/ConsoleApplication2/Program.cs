using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public struct SinhVien
        {
            public int mssv;
            public string hoten;
            public int namsinh;
            public double diemtoan;
            public double diemly;
            public double diemhoa;
            public double dtb;
        }
        public static void NhapTTSV(out SinhVien sv)
        {
            Console.WriteLine("Nhap MSSV: ");
            sv.mssv = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Ho ten: ");
            sv.hoten = Console.ReadLine();
            Console.WriteLine("Nhap Nam sinh: ");
            sv.namsinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem toan: ");
            sv.diemtoan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ly: ");
            sv.diemly = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem hoa: ");
            sv.diemhoa = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem trung binh: ");
            sv.dtb = double.Parse(Console.ReadLine());
        }
        public static void XuatTTSV(SinhVien sv)
        {
            Console.WriteLine("MSSV: " + sv.mssv);
            Console.WriteLine("Ho ten: " + sv.hoten);
            Console.WriteLine("Nam sinh: " + sv.namsinh);
            Console.WriteLine("Diem toan: " + sv.diemtoan);
            Console.WriteLine("Diem ly: " + sv.diemly);
            Console.WriteLine("Diem hoa: " + sv.diemhoa);
            Console.WriteLine("Diem tb: " + sv.dtb);
        }
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            Console.WriteLine("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            SinhVien[] mangsSV = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh vien thu {0} la: ", i + 1);
                NhapTTSV(out mangsSV[i]);
            }
            //XuatTTSV(sv);
            SapXepDanhSachLopTangDan(mangsSV, n);
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("----- Sinh vien thu {0} ----", j + 1);
                XuatTTSV(mangsSV[j]);
            }
            Console.ReadKey();
        }
        public static void SapXepDanhSachLopTangDan(SinhVien[] sv,int n)
        {
            SinhVien temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if(sv[i].dtb > sv[j].dtb)
                    {
                        temp = sv[i];
                        sv[i] = sv[j];
                        sv[j] = temp;
                    }
                }
            }
        }
    }
}

