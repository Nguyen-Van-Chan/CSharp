using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B13
{
    class Program
    {
        public static float NghichDaoNGT(int n)
        {
            float tong = 0;
            for(int i = 1; i <= n; i++)
            {
                tong = tong +(float) 1 / i;
            }
            return tong;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong nghich dao cua {0}! la: {1}", n, NghichDaoNGT(n));
            Console.ReadKey();
        }
    }
}
