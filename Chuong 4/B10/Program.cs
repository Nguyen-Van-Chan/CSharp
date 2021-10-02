using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10
{
    class Program
    {
        public static int KTCP(int n)
        {
            int x =(int) Math.Sqrt(n);
            if (x * x == n)
                return 1;
            else
                return 0;
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
            for (int i = 0; i < pt; i++)
                if (i % 2 != 0 && KTCP(mang[i]) == 1)
                    Console.WriteLine("SCP: {0} Tai vi tri: {1}", mang[i], i);
            Console.ReadKey();
        }
    }
}
