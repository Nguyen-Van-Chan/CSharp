using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 chuoi ky tu: ");
            string s = Console.ReadLine();
            string[] mang = s.Split(' ');
            string temp = "";
            temp = mang[0];
            mang[0] = mang[mang.Length - 1];
            mang[mang.Length - 1] = temp;
            Console.WriteLine("Mang sau khi dao: ");
            for (int i = 0; i < mang.Length; i++)
                Console.Write(mang[i] + " ");
            Console.ReadKey();
        }
    }
}
