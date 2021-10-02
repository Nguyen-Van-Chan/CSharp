using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tk13
{
    class Program
    {
        public static void Swap(int[] a, int n)
        {
            int vtMax = 0;
            int vtMin = 0;
            int Max = 0;
            int Min = 0;
            for (int i = 1; i < n; i++)
            {
                if (a[vtMax] < a[i])
                    vtMax = i;
                if (a[vtMin] > a[i])
                    vtMin = i;
            }
            Max = a[vtMax];
            Min = a[vtMin];
            a[vtMax] = Min;
            a[vtMin] = Max;
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
            Swap(mang, pt);
            Console.WriteLine("Mang sau khi thay doi vi tri Min Max la: ");
            for (int i = 0; i < pt; i++)
            {
                Console.Write(mang[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
