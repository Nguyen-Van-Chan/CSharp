using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiem_B1
{
    class Program
    {
        public static int ViTri(int[] a, int n, int x)
        {
            for (int i = 0; i <n; i--)
            {
                if (a[i] == x)
                {
                    return i;                    
                }
            }
            return -1;
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
            Console.WriteLine("Nhap so X: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("So {0} xuat hien cuoi cung o vi tri {1}", x, ViTri(mang, pt, x));
            Console.ReadLine();
        }
    }
}
