using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public static bool ktsnt(int n)
        {
            if (n == 1)
            {
                return true;
            }
            if (n == 0)
            {
                return false;

            }
            for (int i = 2; i < n; i++)

                if (n % i == 0)
                    return false;
            return true;
        }
        public static int tong(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (ktsnt(i))
                    tong = tong + a[i];
            }
            return tong;

        }
        static void Main(string[] args)
        {
            Console.Write("nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("nhap phan tu thu {0} ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("tong cac so o vi tri nguyen to la {0}", tong(a, n));
            Console.ReadKey();

        }
    }
}
