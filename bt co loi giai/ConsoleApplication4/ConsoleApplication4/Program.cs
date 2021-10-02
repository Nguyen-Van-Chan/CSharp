using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu cua mang: ");
            int pt = int.Parse(Console.ReadLine());
            int[] mang = new int[pt];
            Random rnd = new Random();
            for (int i = 0; i < pt; i++)
            {              
                mang[i] = rnd.Next(1,30);
            }
            for(int i = 0; i < pt; i++)
            {
                Console.WriteLine(mang[i]+"\t");

            }
            Console.ReadKey();
        }
    }
}
