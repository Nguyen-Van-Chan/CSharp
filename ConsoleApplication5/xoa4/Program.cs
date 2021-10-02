using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xoa4
{
    class Program
    {
        public static int TimPTGanXNhat(int[] a, int n, int x)
        {
            int min = Math.Abs(a[0] - x);
            for (int i = 1; i < n; i++)
            {
                int temp = Math.Abs(a[i] - x);
                if (temp < min)
                    min = temp;
            }
            return min;
        }
        public static void Xoa(int[] a, ref int n, int x)
        {

            int min = TimPTGanXNhat(a, n, x);
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(a[i] - x) == min)
                {
                    for (int j = i; j < n - 1; j++)
                        a[j] = a[j + 1];
                    n--;
                    i--;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu cua mang: ");
            int pt = int.Parse(Console.ReadLine());
            int[] mang = new int[pt];
            for (int i = 0; i < pt; i++)
            {
                Console.WriteLine("Phan tu thu {0}: ", i);
                mang[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhap X: ");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Mang sau khi xoa cac phan tu gan {0} nhat: ", X);
            Xoa(mang, ref pt, X);
            for (int i = 0; i < pt; i++)
            {
                Console.Write(mang[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
