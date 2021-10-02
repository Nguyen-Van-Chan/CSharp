using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiem_B4
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
        public static void ViTriNT(int []a,int n)
        {
            Console.WriteLine("Vi tri cua cac phan tu nguyen to: ");
            for(int i = 0; i < n; i++)
            {
                if (KTSNT(a[i]) == 1)
                    Console.Write(i + "\t");
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
            ViTriNT(mang, pt);
            Console.ReadKey();
        }
    }
}
