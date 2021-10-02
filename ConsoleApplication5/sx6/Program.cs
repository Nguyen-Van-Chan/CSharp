using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sx6
{
    class Program
    {
        public static void ChuyenSo(int[] a, int n)
        {
            int j = 0, temp;
            for (int i = 0; i < n; i++)
            {
                if (a[i] <= 0)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    j++;
                }
            }
        }
        public static void SapXep(int[] a, int n)
        {
            int temp;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] < 0 && a[j] < 0 && a[i] < a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                    if (a[i] > 0 && a[j] > 0 && a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
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
            ChuyenSo(mang, pt);
            SapXep(mang, pt);
            Console.WriteLine("Mang sau khi sap xep: ");
            for (int i = 0; i < pt; i++)
            {
                Console.Write(mang[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
