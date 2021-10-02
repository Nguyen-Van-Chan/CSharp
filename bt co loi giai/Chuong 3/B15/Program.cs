using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B15
{
    class Program
    {
        public static int Chan(int x)
        {
            if (x % 2 == 0)
                return 1;
            else return 0;
        }
        public static int Le(int x)
        {
            if (x % 2 != 0)
                return 1;
            else return 0;
        }
        public static void DemChanLe(int n)
        {
            int bandau = n;
            int s;
            int schan = 0, sle = 0;
            while (n > 0)
            {
                s = n % 10;
                schan = schan + Chan(s);
                sle = sle + Le(s);
                n = n / 10;
            }
            Console.WriteLine("So {0} co: {1} so chan, {2} so le.", bandau, schan, sle);
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
            DemChanLe(n);
            Console.ReadKey();
        }
    }
}
