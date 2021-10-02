using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapXep_B2
{
    class Program
    {
        public static int KTSNT(int n)
        {
            if (n == 1) return 1;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return 0;
            }
            return 1;
        }
        public static void SXNT(int[] a, int n)
        {
            int temp;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (KTSNT(a[i]) == 1 && KTSNT(a[j]) == 1 && a[i]>a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
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
            SXNT(mang, pt);
            Console.WriteLine("Mang sau khi sap xep cac so nguyen to: ");
            for (int i = 0; i < pt; i++)
            {
                Console.Write(mang[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
