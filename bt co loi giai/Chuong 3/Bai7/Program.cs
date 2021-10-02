using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        public static void DocSo(int n)
        {
            int tram = n / 100;
            int chuc = n / 10 % 10;
            int dv = n % 10;
            switch (tram)
            {
                case 1: Console.Write("Mot Tram "); break;
                case 2: Console.Write("Hai Tram "); break;
                case 3: Console.Write("Ba Tram "); break;
                case 4: Console.Write("Bon Tram "); break;
                case 5: Console.Write("Nam Tram "); break;
                case 6: Console.Write("Sau Tram "); break;
                case 7: Console.Write("Bay Tram "); break;
                case 8: Console.Write("Tam Tram "); break;
                case 9: Console.Write("Chin Tram "); break;
            }
            switch (chuc)
            {
                case 0:
                    if (dv == 0)
                    {
                        Console.Write(" ");
                        break;
                    }
                    else
                    {
                        Console.Write("Le ");
                        break;
                    }
                case 1: Console.Write("Muoi "); break;
                case 2: Console.Write("Hai Muoi "); break;
                case 3: Console.Write("Ba Muoi "); break;
                case 4: Console.Write("Bon Muoi "); break;
                case 5: Console.Write("Nam Muoi "); break;
                case 6: Console.Write("Sau Muoi "); break;
                case 7: Console.Write("Bay Muoi "); break;
                case 8: Console.Write("Tam Muoi "); break;
                case 9: Console.Write("Chin Muoi "); break;
            }
            switch (dv)
            {
                case 5:
                    if (chuc == 0)
                    { Console.Write("Nam "); break; }
                    else
                    { Console.Write("Lam "); break; }
                case 1: Console.Write("Mot"); break;
                case 2: Console.Write("Hai"); break;
                case 3: Console.Write("Ba"); break;
                case 4: Console.Write("Bon"); break;
                case 6: Console.Write("Sau"); break;
                case 7: Console.Write("Bay"); break;
                case 8: Console.Write("Tam"); break;
                case 9: Console.Write("Chin"); break;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so n: ");
            int n = int.Parse(Console.ReadLine());
            DocSo(n);
            Console.ReadKey();
        }
    }
}
