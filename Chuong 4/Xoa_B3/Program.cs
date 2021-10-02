using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xoa_B3
{
    class Program
    {
        public static void XoaPTBeHonX(int[] a, ref int n,int x)
        {
            for (int i = 0; i < n; i++)
                if (a[i] < x)
                {
                    for (int j = i; j < n-1; j++)
                        a[j] = a[j + 1];
                    n--;
                    i--;
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
            Console.WriteLine("Nhap vao X: ");
            int x = int.Parse(Console.ReadLine());
            XoaPTBeHonX(mang, ref pt, x);
            Console.WriteLine("Mang sau khi xoa cac pt be hon {0}: ",x);
            for (int i = 0; i < pt; i++)
            {
                Console.Write(mang[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
