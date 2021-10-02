using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xoa1
{
    class Program
    {
        public static void XoaVTLe(int[] a, ref int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (i % 2 != 0)
                    a[i] = a[i + 1];
                n--;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu cua mang: ");
            int pt = int.Parse(Console.ReadLine());
            int[] mang = new int[pt];
            for (int i = 0; i < pt; i++)
            {
                Console.WriteLine("Phan tu thu {0}: ", i);
                mang[i] = int.Parse(Console.ReadLine());
            }
            XoaVTLe(mang, ref pt);
            Console.WriteLine("Mang sau khi thay xoa vi tri le: ");
            for (int i = 0; i < pt; i++)
            {
                Console.Write(mang[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
