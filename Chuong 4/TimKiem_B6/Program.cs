using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiem_B6
{
    class Program
    {
        public static int ViTriAm(int[] a, int n)
        {
            int vt = -1;           
            for (int i = 0; i < n; i++)
            {
                if ((a[i]) < 0)
                {
                    vt = i;
                    break;
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
            Console.WriteLine("Vi tri cua phan tu am dau tien: {0}", ViTriAm(mang, pt));
            Console.ReadKey();
        }
    }
}
