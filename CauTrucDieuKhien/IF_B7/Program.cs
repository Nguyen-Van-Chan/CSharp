using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_B7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so n gom 3 chu so: ");
            int n = int.Parse(Console.ReadLine());
            int tram = n / 100;
            int chuc = n / 10 % 10;
            int donvi = n % 100 % 10;
            Console.WriteLine(tram + " " + chuc + " " + donvi);
            if (tram > chuc)
            {
                if (tram > donvi)
                    Console.WriteLine("So lon nhat la {0}, nam o hang tram", tram);
                else
                    Console.WriteLine("So lon nhat la {0}, nam o hang don vi", donvi);
            }
            else if (chuc > donvi)
                Console.WriteLine("So lon nhat la {0}, nam o hang chuc", chuc);
            else
                Console.WriteLine("So lon nhat la {0}, nam o hang don vi", donvi);

            Console.ReadKey();
        }
    }
}
