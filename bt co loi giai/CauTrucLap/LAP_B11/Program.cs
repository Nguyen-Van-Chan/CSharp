using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP_B11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    dem = dem + 1;
            }
            Console.WriteLine("So uoc so cua {0} la: {1}", n, dem);
            Console.ReadKey();
        }
    }
}
