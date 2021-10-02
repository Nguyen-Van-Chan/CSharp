using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        public static void XuatMang(int[] a, int n)
        {

            Console.Write("Cac phan tu da nhap vao la: \n");

            int i;

            srand(time(NULL));

            for (i = 0; i < n; i++)
            {

                Console.Write("a[{0}] = {1} \n", i, 0 - Random() % 100);

            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            XuatMang(a, n);
        }
    }
}
