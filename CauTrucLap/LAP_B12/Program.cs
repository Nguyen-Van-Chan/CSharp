using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP_B12
{
    class Program
    {
        static void Main(string[] args)
        {
            int tong;
            for (int i = 2; i <= 5000; i++)
            {
                tong = 1;
                for (int j = 2; j <= i/2; j++)
                    if (i % j == 0)
                        tong = tong + j;
                if (tong == i)
                    Console.WriteLine(i);
            }          
            Console.ReadKey();
        }
    }
}
