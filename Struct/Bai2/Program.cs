using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        public struct Sach
        {
            public int MaSach;
            public string TieuDe;
            public int NXB;
            public int GiaBan;
        }
        public static Sach XuatBanLauNhat(Sach[] mangsach,int n)
        {
            int min =mangsach[0].NXB;
            int vitri = 0;
            for(int i = 1; i < n; i++)
            {
                if(mangsach[i].NXB<min)
                {
                    min = mangsach[i].NXB;
                    vitri = i;
                }
            }
            return mangsach[vitri];
        }
        public static void NhapSach(out Sach s)
        {
            Console.Write("Nhap Ma sach: ");
            s.MaSach = int.Parse(Console.ReadLine());
            Console.Write("Nhap tieu de: ");
            s.TieuDe = Console.ReadLine();
            Console.Write("Nhap nam xuat ban: ");
            s.NXB = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia ban: ");
            s.GiaBan = int.Parse(Console.ReadLine());
        }
        public static void XuatSach(Sach s)
        {
            Console.WriteLine();
            Console.WriteLine("Ma sach: " + s.MaSach);
            Console.WriteLine("Tieu de: " + s.TieuDe);
            Console.WriteLine("Nam xuat ban: " + s.NXB);
            Console.WriteLine("Gia ban: " + s.GiaBan);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong sach: ");
            int n = int.Parse(Console.ReadLine());
            Sach[] mangSach = new Sach[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Quyen sach thu {0} la: ", i + 1);
                NhapSach(out mangSach[i]);
            }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Quyen sach thu {0} la: ", i + 1);
                XuatSach(mangSach[i]);
            }
            Console.WriteLine("Quyen sach duoc xuat ban lau nhat la: ");
            XuatSach(XuatBanLauNhat(mangSach, n));
            Console.WriteLine("--------------------");
            Console.WriteLine("Gia ban trung binh cac cuon sach duoc nhap la: {0}", GiaTrungBinhCacCuonSach(mangSach, n));
            Console.ReadKey();
        }
        public static double GiaTrungBinhCacCuonSach (Sach[] sach,int n)
        {
            int tonggiacaccuonsach = 0;

            for (int i = 0; i < n; i++)
            {
                tonggiacaccuonsach += sach[i].GiaBan;
            }
            return (double) tonggiacaccuonsach/n;
        }
    }
}
