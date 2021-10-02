using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 chuoi ky tu: ");
            string s = Console.ReadLine();
            char[] mang = s.ToCharArray();
            for(int i = 0; i < mang.Length; i++)
            {
                if (i % 2 == 0)
                    Console.Write(Char.ToUpper(mang[i]));
                else
                    Console.Write(Char.ToLower(mang[i]));
            }
            Console.ReadKey();
        }
    }
}
