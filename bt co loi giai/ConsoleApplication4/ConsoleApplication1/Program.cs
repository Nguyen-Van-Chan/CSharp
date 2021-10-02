using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static int TimMax(int[] a, int n)
        {

            int i, vtmax = 0;
            int max = a[0];
            for (i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    vtmax = i;
                }
            }
            return vtmax;
        }
        static void Main(string[] args)
        {
            Console.Write(" So luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i=0;i<n;i++)
            {
                Console.Write(" Phan tu thu {0}: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(" Vi tri phan tu lon nhat la: " + TimMax(a,n));
            Console.ReadKey();
            
        }
    }
}
