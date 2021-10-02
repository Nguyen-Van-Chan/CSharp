using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9
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

        static void Main(string[] args)
        {
            int dem = 0;
            Console.WriteLine("Nhap so phan tu cua mang: ");
            int pt = int.Parse(Console.ReadLine());
            int[] mang = new int[pt];
            
            for (int i = 0; i < pt; i++)
            {
                Console.WriteLine("Phan tu thu {0}: ", i + 1);
                mang[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < pt; i++)
            {
                if (KTSNT(mang[i]) == 1 && mang[i] < n)
                {
                    dem++;
                    Console.Write(mang[i] + "\t");
                }
            }
            if(dem==0)
                Console.WriteLine("Khong co so nguyen to nao < {0}",n);
            Console.ReadKey();
        }
    }
}
