using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP_B6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu cao h: ");
            int h = int.Parse(Console.ReadLine());
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
