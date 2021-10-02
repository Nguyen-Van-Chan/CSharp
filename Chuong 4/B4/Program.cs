using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random rnd = new Random();
            int rn = rnd.Next(-100, -1);
            a[0] = rn;
            for (int i = 1; i < n; i++)
            {
                do
                {
                    rn = rnd.Next(-100, -1);
                    if (rn >= a[i - 1])
                        a[i] = rn;
                }
                while (rn < a[i - 1]);

            }
            for (int j = 0; j < n; j++)
                Console.Write(a[j] + "\t");
            Console.ReadKey();
        }
    }
}
