using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
      public static  void xuatmang(int[] a,int n)
      {
            Console.Write("Cac phan tu da nhap vao la:\n");
            int i;
            for(i=0; i<n; i++)
            {
               Console.Write("a[{0}] = 0\n",i);
            }
      }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] at = new int[n];
            xuatmang(at, n);
            Console.ReadKey();
        }
    }
}

