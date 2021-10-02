using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiem_B2
{
    class Program
    {
        public static int ViTri(int[] a, int n)
        {
            int vt = 0;
            int min = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    vt = i;
                }
            }
            return vt;
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
            Console.WriteLine("Vi tri cua phan tu be nhat trong mang la: " + ViTri(mang, pt));
            Console.ReadKey();
        }
    }
}
