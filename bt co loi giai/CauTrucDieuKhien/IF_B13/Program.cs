using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_B13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            Console.WriteLine("Nhap vao canh thu nhat: ");
            int c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao canh thu hai: ");
            int c2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao canh thu ba: ");
            int c3 = int.Parse(Console.ReadLine());
            if (c1 + c2 > c3 && c1 + c3 > c2 && c2 + c3 > c1)
            {
                if (c1 == c2 && c2 == c3)
                    Console.WriteLine("Day la tam giac deu");
                else if (c1 == c2 || c1 == c3 || c2 == c3)
                    Console.WriteLine("Day la tam giac can");
                else if (c1 * c1 == c2 * c2 + c3 * c3 || c2 * c2 == c1 * c1 + c3 * c3 || c3 * c3 == c1 * c1 + c2 * c2)
                    Console.WriteLine("Day la tam giac vuong");
                else if(c1 * c1 > c2 * c2 + c3 * c3 || c2 * c2 > c1 * c1 + c3 * c3 || c3 * c3 > c1 * c1 + c2 * c2)
                    Console.WriteLine("Day la tam giac tu");
                else
                    Console.WriteLine("Day la tam giac nhon");
            }
            else
                Console.WriteLine("Day khong phai la 3 canh cua tam giac");
            Console.ReadKey();
        }
    }
}
