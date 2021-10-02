using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4
{
    class Program
    {
        public static string NoiChuoi(string s1,string s2)
        {
            return s1 + s2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 chuoi ky tu: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Nhap vao 1 chuoi ky tu: ");
            string s2 = Console.ReadLine();
            Console.WriteLine("Chuoi sau khi noi: "+NoiChuoi(s1,s2));
            Console.ReadKey();
        }
    }
}
