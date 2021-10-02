using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void snt(int n)
        {
            int ngto = 1;
            if (n == 1)
                Console.Write(ngto);
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    ngto = 1;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            ngto = 0;
                        }
                    }
                    if (ngto == 1)
                        Console.Write("\t" + i);
                }
            }
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap n: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0);
            Console.Write("Cac so nguyen to la: ");
            snt(n);
            Console.ReadKey();
        }
    }
}
