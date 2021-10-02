using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        struct thongtin
        {
            public int maso;
            public string hoten;
            public double dtb;
        }
        public static void nhapttt(out thongtin tt)
        {
            Console.Write("Nhap ma so:");
            tt.maso = int.Parse(Console.ReadLine());
            Console.Write("nhap ho ten: ");
            tt.hoten = Console.ReadLine();
            Console.Write("Nhap diem trung binh: ");
            tt.dtb = float.Parse(Console.ReadLine());
        }
        public static void ketqua(thongtin tt)
        {
            if (tt.dtb > 5)
                Console.WriteLine("Dat");
            else
                Console.WriteLine("Khong dat");
        }
        public static thongtin diemtbmax(thongtin[] tt, int n)
        {
            double max = tt[0].dtb;
            int vitri = 0;
            for (int i = 0; i < n; i++)
            {
                if (tt[i].dtb > max)
                {
                    max = tt[i].dtb;
                    vitri = i;
                }
            }
            return tt[vitri];
        }
        public static double dtbmax(thongtin []tt,int n)
        {
            double max = tt[0].dtb;
            for (int i = 0; i < n; i++)
            {
                if ((tt[i].dtb >max))
                {
                    max = tt[i].dtb;

                }
            }
            return max;
        }
        public static void xuat(thongtin tt)
        {
            Console.WriteLine("Ma so la: " + tt.maso);
            Console.WriteLine("Ho va ten la: " + tt.hoten);
            Console.WriteLine("Diem trung binh la: " + tt.hoten);
            Console.WriteLine();
        }
        public static int dem(thongtin[] tt, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (tt[i].dtb > 5)
                {
                    dem++;
                }
            }
            return dem;

        }
        public static void nhapn(thongtin[] tt, int n)
        {
            Console.WriteLine("--------------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu {0}: ", i + 1);
                nhapttt(out tt[i]);
            }
            Console.WriteLine("----------------------");
        }
        public static void sapxep(thongtin[] tt, int n)
        {
            thongtin temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (tt[i].dtb > tt[j].dtb)
                    {
                        temp = tt[i];
                        tt[i] = tt[j];
                        tt[j] = temp;

                    }
                }
            }
        }

        public static void xeploai(thongtin[] tt, int n)
        {
            Console.WriteLine("\n____________________________________\n");
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("\nXep loai cua SV thu %d la: ", i + 1);
                ketqua(tt[i]);
            }
            Console.WriteLine("\n____________________________________\n");
        }
        public static void xuatn(thongtin[] tt, int n)
        {
            Console.WriteLine("--------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thong tin sinh vien thu" + i + 1);
                xuat(tt[i]);
            }
            Console.WriteLine("--------------------------");
        }
        static void Main(string[] args)
        {
            int n;
            bool daNhap = false;
    do
    {
        Console.WriteLine(("\nNhap so luong SV: "); 
        n = int.Parse(Console.ReadLine());
    }
    while(n <= 100);
            thongtin[]tt = new thongtin [n];
    while(true)  
    {
        int a;
            Console.WriteLine("******************************************\n");
            Console.WriteLine("**    CHUONG TRINH QUAN LY SINH VIEN    **\n");
            Console.WriteLine("**      1. Nhap du lieu                 **\n");
            Console.WriteLine("**      2. Xuat danh sach sv            **\n");
            Console.WriteLine("**      3. Ket qua cac sv               **\n");
            Console.WriteLine("**      4. Diem trung binh lon nhat     **\n");
            Console.WriteLine("**      5. So luong sv ket qua dat      **\n");
            Console.WriteLine("**      6. Ghi file                     **\n");
            Console.WriteLine("**      7. Thoat chuong trinh           **\n");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("**       Nhap lua chon cua ban          **\n");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Ban da chon nhap du lieu");
                    nhapn(tt,n);
                    Console.WriteLine("Ban da nhap thanh cong");
                    daNhap = true;
                    Console.WriteLine("Bam phim bat ky de tiep tuc!");
                    a = Convert.ToInt32(Console.ReadLine());
                break;
                case 2:
                    if(daNhap)
                    {
                   Console.WriteLine("Ban da chon xuat DS sinh vien!");
                    xuatn(tt,n);
                }
                    else
                    {
                    Console.WriteLine("Nhap DS SV truoc!!!!");
                    }
                    Console.WriteLine("Bam phim bat ky de tiep tuc!");
                    a = Convert.ToInt32(Console.ReadLine());
                break;
                case 3:
                    if(daNhap)
                    {
                   Console.WriteLine("Ban da chon xuat ket qua cac sv!");
                    xeploai(tt,n);
                }
                    else
                    {
                    Console.WriteLine("Nhap DS SV truoc!!!!");
                    }
                    Console.WriteLine("Bam phim bat ky de tiep tuc!");
                    a = Convert.ToInt32(Console.ReadLine());
                break;
               case 4:
                    if(daNhap)
                    {
                   Console.WriteLine("Ban da chon xuat diem trung binh lon nhat!");
                    diemtbmax(tt,n);
                }
                    else
                    {
                    Console.WriteLine("Nhap DS SV truoc!!!!");
                    }
                    Console.WriteLine("Bam phim bat ky de tiep tuc!");
                    a = Convert.ToInt32(Console.ReadLine());
                break;
                case 5:
                    if(daNhap)
                    {
                   Console.WriteLine("Ban da chon xuat so luong sv ket qua dat!");
                    Console.WriteLine("So sinh vien ket qua dat la:!"+dem(tt,n));
                }
                    else
                    {
                    Console.WriteLine("\nNhap DS SV truoc!!!!");
                    }
                    Console.WriteLine("\nBam phim bat ky de tiep tuc!");
                    a = Convert.ToInt32(Console.ReadLine());
                break;
                case 6:
                    if(daNhap)
                    {
                   Console.WriteLine("Ban da chon ghi file!");
                   
                }
                    else
                    {
                    Console.WriteLine("\nNhap DS SV truoc!!!!");
                    }
                    Console.WriteLine("\nBam phim bat ky de tiep tuc!");
                    a = Convert.ToInt32(Console.ReadLine());
                break;
            }

        }
        }
    }
}
