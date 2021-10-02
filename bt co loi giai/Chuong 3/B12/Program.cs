using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12
{
    class Program
    {
        public static int UCLN(int a, int b)
        {
            if (a == 0 || b == 0)
                return a + b;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        public static int BCNN(int a, int b)
        {
            int max;
            int bcnn = 0;
            if (a > b)
                max = a;
            else max = b;
            for (int i = max; i < a * b; i=i+max)
                if (i % a == 0 && i % b == 0)
                { bcnn = i; break; }
            return bcnn;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("UCLN cua {0} va {1} la: {2}", a, b, UCLN(a, b));
            Console.WriteLine("BCNN cua {0} va {1} la: {2}", a, b, BCNN(a, b));
            Console.ReadKey();
        }
    }
}
