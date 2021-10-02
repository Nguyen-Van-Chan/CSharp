using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 chuoi ky tu: ");
            string s = Console.ReadLine();
            for(int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            Console.ReadKey();
        }
    }
}
