using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8
{
    class Program
    {
        public static int TinhTienGio(int gbd, int gkt,int sm)
        {
            int tiengio=0;
            if (gkt <= 17)
                tiengio = 2500 * (gkt - gbd) * sm;
            else
            {
                if (gbd >= 18)
                    tiengio = 3000 * (gkt - gbd) * sm;
                else
                    tiengio = (2500 * (18 - gbd) + 3000 * (gkt - 18) + 250) * sm;
            }
            return tiengio;

        }
        static void Main(string[] args)
        {
            int gbd = 0; int gkt = 0; int sm = 0;
            do
            {
                Console.WriteLine("Nhap gio bat dau: ");
                gbd = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap gio ket thuc: ");
                gkt = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so may thue: ");
                sm = int.Parse(Console.ReadLine());
            }
            while (gbd <= 6 || gkt >= 21 || gbd >= gkt || sm < 1);
            Console.WriteLine("So tien phai tra la: {0}", TinhTienGio(gbd, gkt, sm));
            Console.ReadKey();
        }
    }
}
