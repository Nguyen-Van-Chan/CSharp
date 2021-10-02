using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public struct SinhVien
        {
            public int MaSo;
            public string HoTen;
            public double DiemToan;
            public double DiemLy;
            public double DiemVan;
        }
        public static void NhapSV(out SinhVien sv)
        {
            Console.WriteLine("Nhap MSSV: ");
            sv.MaSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Ho ten: ");
            sv.HoTen = Console.ReadLine();
            Console.WriteLine("Nhap diem toan: ");
            sv.DiemToan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ly: ");
            sv.DiemLy = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem van: ");
            sv.DiemVan = double.Parse(Console.ReadLine());

        }
        public static void XuatSV(SinhVien sv)
        {
            Console.WriteLine("MSSV: "+sv.MaSo);
            Console.WriteLine("Ho ten: "+sv.HoTen);
            Console.WriteLine("Diem toan: "+sv.DiemToan);
            Console.WriteLine("Diem ly: "+sv.DiemLy);
            Console.WriteLine("Diem van: "+sv.DiemVan);
        }
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            NhapSV(out sv);
            XuatSV(sv);
            Console.ReadKey();
        }
    }
}
