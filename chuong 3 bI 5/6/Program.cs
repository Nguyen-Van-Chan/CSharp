using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        public static bool check(int n)
        {
            int sum = 0;//khai bao biem sum
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            if (sum == n)
            return true; // tra ve true
            return false;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (check(n))
                Console.Write("{0} la so hoan hao.", n);
            else
                Console.Write("{0} khong phai la so hoan hao.", n);
            Console.ReadKey();
        }
    }
}
