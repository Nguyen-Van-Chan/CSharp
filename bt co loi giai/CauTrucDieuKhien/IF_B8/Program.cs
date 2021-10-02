using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_B8
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
            int temp;
            if(tram > chuc)
            {
                temp = tram;
                tram = chuc;
                chuc = temp;
            }
            if (tram > donvi)
            {
                temp = tram;
                tram = donvi;
                donvi = temp;
            }
            if (chuc > donvi)
            {
                temp = chuc;
                chuc = donvi;
                donvi = temp;
            }
            Console.WriteLine("Thu tu sau khi sap xep: {0} {1} {2}", tram, chuc, donvi);
            Console.ReadKey();
        }
    }
}
