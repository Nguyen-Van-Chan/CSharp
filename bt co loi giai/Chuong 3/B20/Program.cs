using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B20
{
    class Program
    {
        public static int check(int n)
        {
            int val1 = 9;
            int val2;
            while (n > 0)
            {
                val2 = n % 10;
                if (val2 >= val1) return 1; // không phải tăng dần
                n = n / 10;
                val1 = val2;
            }
            return 0; // tăng dần
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            if (check(n) == 0)
                Console.WriteLine("N tang dan ");
            else
                Console.WriteLine("N khong tang dan ");
            Console.ReadKey();
        }
    }
}
