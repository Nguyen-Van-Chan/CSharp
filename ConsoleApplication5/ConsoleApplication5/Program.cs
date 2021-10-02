using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        public static void XoaMax(int[] a, ref int n)
        {
            int max = a[0];
            int vtmax=0;
            for (int i = 0; i < n; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                    vtmax = i;
                }
            }
            for(int i = vtmax; i < n - 1; i++)
            {
                a[i] = a[i + 1];
            }
            n--;
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
            XoaMax(mang, ref pt);
            Console.WriteLine("Mang sau khi xoa phan tu lon nhat: ");
            for (int i = 0; i < pt; i++)
            {
                Console.Write(mang[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
