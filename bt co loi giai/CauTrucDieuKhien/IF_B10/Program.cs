using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_B10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ngay: ");
            int ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam: ");
            if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                Console.WriteLine("Nam {0} la nam nhuan", nam);
            else
                Console.WriteLine("Nam {0} khong la nam nhuan", nam);
            Console.ReadKey();
        }
    }
}
