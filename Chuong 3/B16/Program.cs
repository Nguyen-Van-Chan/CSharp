using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B16
{
    class Program
    {
        public static bool KTSNT(int n)
        {
            if (n == 0)
                return false;
            if (n == 1)
                return true;
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static void DemSoNguyenTo(int n)
        {
            int bandau = n;
            int s;
            int snt =0; 
            while (n > 0)
            {
                s = n % 10;
                if (KTSNT(s))
                    snt = snt + 1;
                n = n / 10;
            }
            Console.WriteLine("So {0} co: {1} so nguyen to.", bandau, snt);
        }
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("Nhap n co 5 chu so: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1 || n > 99999);
            DemSoNguyenTo(n);
            Console.ReadKey();
        }
    }
}
