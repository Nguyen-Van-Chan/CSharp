using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tk9_14
{
    class Program
    {
        public static void InPt(int[] a, int n, int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] < x)
                    Console.Write(a[i] + "\t");
            }
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
            Console.WriteLine("Nhap so X: ");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Cac phan tu < X: ");
            InPt(mang, pt, X);
            Console.ReadKey();
        }
    }
}
