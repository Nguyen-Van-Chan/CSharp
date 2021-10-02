using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_B12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so KM di: ");
            double km = double.Parse(Console.ReadLine());
            double tien = 0;
            if (km <= 1)
                tien = 5000;
            else if (km < 30)
                tien = (km/0.2)*1000;
            else
                tien =30*5000 + (km - 30) * 3000;
            Console.WriteLine("So tien phai tra la: {0}", tien);
            Console.ReadKey();
        }
    }
}
