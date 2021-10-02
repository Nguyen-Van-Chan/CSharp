using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_B14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot so bat ky: ");
            int n = int.Parse(Console.ReadLine());
            if (Math.Sqrt(n) == (int)Math.Sqrt(n))
                Console.WriteLine("So {0} la so chinh phuong", n);
            else
                Console.WriteLine("So {0} khong la so chinh phuong", n);
            Console.ReadKey();
        }
    }
}
