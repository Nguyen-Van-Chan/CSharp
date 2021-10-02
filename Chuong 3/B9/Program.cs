using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9
{
    class Program
    {
        public static int TinhTien(int giovao, int giora)
        {
            int tien = 0;
            if (giora <= 12)
                tien = (giora - giovao) * 6000;
            else
            {
                if (giovao >= 12)
                    tien = (giora - giovao) * 7500;
                else
                    tien = (12 - giovao) * 6000 + (giora - 12) * 7500;
            }
            return tien;
        }
        static void Main(string[] args)
        {
            int gv = 0; int gr=0;
            do
            {
                Console.WriteLine("Nhap gio vao: ");
                gv = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap gio ra: ");
                gr = int.Parse(Console.ReadLine());
            }
            while (gv <= 6 || gr >= 18 || gv > gr);
            Console.WriteLine("Tien luong la: " + TinhTien(gv, gr));
        }
    }
}
