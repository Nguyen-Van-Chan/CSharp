using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao ho va ten: ");
            string s = Console.ReadLine();
            string ho = "";
            string ten = "";
            string[] mang = s.Split(' ');
            for (int i = 0; i < mang.Length - 1; i++)
                ho += mang[i]+" ";
            ten = mang[mang.Length - 1];
            Console.WriteLine("Ho: "+ ho);
            Console.WriteLine("Ten: "+ ten);
            Console.ReadKey();
        }
    }
}
