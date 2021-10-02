using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demso
{
    class Program
    {
        public static void DemSo(int[] a, int n)
        {
            int soAm = 0;
            int soDuong = 0;
            for (int i = 0; i < n; i++)
                if (a[i] > 0)
                    soDuong++;
                else
                    soAm++;
            Console.WriteLine("So phan tu am: {0}, so phan tu duong: {1}", soAm, soDuong);
        }
        static void Main(string[] args)
        {
            Console.Write(" So luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write(" Phan tu thu {0}: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            DemSo(a, n);
            Console.ReadKey();
        }
    }
}
