using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP_B10
{
    class Program
    {
        static void Main(string[] args)
        {
            //a*b=ucln(a,b)*bcnn(a,b)
            Console.WriteLine("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int t1 = a, t2 = b;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            Console.WriteLine("UCLN cua hai so a va b la: {0}", a);
            Console.WriteLine("BCNN cua hai so a va b la: {0}", (t1 * t2) / a);
            Console.ReadKey();
        }
    }
}
