using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_B9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kiemtra = true;
            Console.WriteLine("Nhap ngay: ");
            int ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());
            if (thang > 0 || thang <= 12)
            {
                if (thang == 2)
                    if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                        if (ngay < 1 || ngay > 30)
                            kiemtra = false;
                if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
                    if (ngay < 1 || ngay > 31)
                        kiemtra = false;
                if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                    if (ngay < 1 || ngay > 30)
                        kiemtra = false;
            }
            else
                kiemtra = false;
            if (nam < 0)
                kiemtra = false;
            if (kiemtra)
                Console.WriteLine("Ngay vua nhap la: {0}/{1}/{2} la hop le", ngay, thang, nam);
            else
                Console.WriteLine("Ngay vua nhap khong hop le");
            Console.ReadKey();
        }
    }
}
