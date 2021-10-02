using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Program
    {
        public static void XoaKhoangTrang(ref string s)
        {
            s = s.Trim();
            while (s.IndexOf("  ") != -1)
                s = s.Replace("  ", " ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 chuoi ky tu: ");
            string s = Console.ReadLine();
            XoaKhoangTrang( ref s);
            Console.WriteLine("Chuoi sau khi chuan hoa la: "+s);
            Console.ReadKey();
        }
    }
}
