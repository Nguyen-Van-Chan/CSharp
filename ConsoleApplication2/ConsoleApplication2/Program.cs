using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static int sum(int n)
        {
            int tong = 0;
            for (int i = 0; i <= n; i++)
                tong += i;

            return tong;
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap n ");
            int n = int.Parse(Console.ReadLine());
          
                Console.WriteLine(sum(n));
            Console.ReadKey();
        }
    }
}
