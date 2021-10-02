using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS
{
    class Program
    {
        public struct PhanSo
        {
            public int TuSo;
            public int MauSo;
        }
        public static int UCLN(int a,int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        public static PhanSo RutGonPS(PhanSo ps)
        {
            int n = UCLN(ps.TuSo, ps.MauSo);
            ps.TuSo = ps.TuSo / n;
            ps.MauSo = ps.MauSo / n;
            return ps;
        }
        public static void NhapPS(out PhanSo ps)
        {
            Console.Write("Nhap tu so: ");
            ps.TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            ps.MauSo = int.Parse(Console.ReadLine());
        }
        public static void XuatPS(PhanSo ps)
        {
            Console.WriteLine(ps.TuSo+"/"+ps.MauSo);
        }
        public static PhanSo TongHaiPS(PhanSo ps1, PhanSo ps2)
        {
            PhanSo kq;
            kq.MauSo = ps1.MauSo * ps2.MauSo;
            kq.TuSo = ps1.TuSo * ps2.MauSo + ps2.TuSo * ps1.MauSo;
            return kq;
        }
        public static PhanSo HieuPS(PhanSo ps1, PhanSo ps2)
        {
            PhanSo kq;
            kq.TuSo = ps1.TuSo * ps2.MauSo - ps2.TuSo * ps1.MauSo;
            kq.MauSo = ps1.MauSo * ps2.MauSo;
            return kq;
        }
        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            NhapPS(out ps1);
            Console.Write("Phan so thu nhat la: ");
            XuatPS(ps1);
            NhapPS(out ps2);
            Console.Write("Phan so thu hai la: ");
            XuatPS(ps2);
            Console.Write("Tong hai phan so nay la: ");
            XuatPS(RutGonPS(TongHaiPS(ps1, ps2)));
            Console.Write("Hieu hai phan so nay la: ");
            XuatPS(RutGonPS(HieuPS(ps1, ps2))); 
            Console.ReadKey();
        }
    }
}
