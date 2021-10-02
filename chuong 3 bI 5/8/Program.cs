using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int bdt, ktt, smt, tien;// bdt =  bat dau thue, ktt =  ket thuc thue, smt =  so may thue, tien =  tong so tien
            tien = 0;
            do
            {
                Console.Write("Nhap gio bat dau thue = ");
                bdt = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap gio ket thuc thue = ");
                ktt = Convert.ToInt32(Console.ReadLine());
            } while (((bdt < 6) || (bdt > 21)) || ((ktt < 6) || (ktt > 21)) || (bdt > ktt));
            do
            {
                Console.Write("nhap so may thue = ");
                smt = Convert.ToInt32(Console.ReadLine());
            } while (smt < 1);
            if (ktt <= 17)
                tien = 2500 * (ktt - bdt) * smt;
            else
            {
                if (bdt >= 18)
                    tien = 3000 * (ktt - bdt) * smt;
                else if (bdt < 18)
                   tien = (2500 * (18 - bdt) + 3000 * (ktt - 18) + 250) * smt;
            }
            Console.Write("Tien = {0}(Dong)", tien);
            Console.ReadKey();
        }
    }
}
