using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP_B5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu dai: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    if (i == 0 || j == 0 || i == m - 1 || j == n - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
