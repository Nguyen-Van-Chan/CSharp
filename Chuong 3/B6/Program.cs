using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6
{
    class Program
    {
        public static int DemSoHoanThien(int n)
        {
            int tong;
            int dem = 0;
            for (int i = 2; i <= n; i++)
            {
                tong = 1;
                for (int j = 2; j <= i / 2; j++)
                    if (i % j == 0)
                        tong = tong + j;
                if (tong == i)
                    dem++;
            }
            return dem;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Co {0} so hoan thien nho hon {1}.", DemSoHoanThien(n), n);
            Console.ReadKey();
        }
    }
}
