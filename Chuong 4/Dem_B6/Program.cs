using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dem_B6
{
    class Program
    {
        public static int KTSHT(int n)
        {
            int S = 0;
            for(int i=1;i<n;i++)
            {
                if (n % i == 0)
                    S = S + i;
            }
            if (S == n)
                return 1;
            else
                return 0;
        }
        public static int DemSHT(int[] a,int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (KTSHT(a[i]) == 1)
                    dem++;
            }
            return dem;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu cua mang: ");
            int pt = int.Parse(Console.ReadLine());
            int[] mang = new int[pt];
            for (int i = 0; i < pt; i++)
            {
                Console.WriteLine("Phan tu thu {0}: ", i + 1);
                mang[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Co {0} so hoan thien trong mang.", DemSHT(mang, pt));
            Console.ReadKey();
        }
    }
}
