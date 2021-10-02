using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP_B8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu cao h: ");
            int h = int.Parse(Console.ReadLine());
            int m = h, n = h;
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= 2 * h - 1; j++)
                {
                    if (j >= m && j <= n)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                m--;
                n++;
                Console.WriteLine();                
            }
            Console.ReadKey();
        }
    }
}
