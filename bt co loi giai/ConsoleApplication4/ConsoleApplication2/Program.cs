using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static int Sum(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
                if (a[i] % 2 == 0)
                {
                    tong = tong + a[i];
                }
            return tong;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write(" Phan tu thu {0}: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(" Tong cac phan tu la: " + Sum(a, n));
            Console.ReadKey();
        }
    }
}
