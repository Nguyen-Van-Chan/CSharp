using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 chuoi ky tu: ");
            string s = Console.ReadLine();
            Console.WriteLine("Nhap vao ky tu can kiem tra: ");
            char kt = char.Parse(Console.ReadLine());
            Console.Write("Cac vi tri cua ky tu {0} trong chuoi: ",kt);
            for (int i = 0; i < s.Length; i++)
                if (s[i] == kt)
                    Console.Write(i + " ");
            Console.ReadKey();

        }
    }
}
