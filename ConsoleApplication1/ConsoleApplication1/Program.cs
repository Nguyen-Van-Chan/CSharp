using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap n");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= m; i++)
            {
                for (int j=0; j <= n; j++)
                    Console.Write("*");
                 Console.Write("\n");
            
            }

                    Console.ReadKey();
        }
    }
}
