using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5
{
    class Program
    {
        public static string ChuyenChu(string s)
        {
            char[] chars = s.ToCharArray();
            string kq = "";
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 'A' && chars[i] <= 'Z')
                {
                    chars[i] = (char)((int)chars[i] + 32);
                }
                kq += chars[i];
            }
            return kq;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 chuoi ky tu: ");
            string s = Console.ReadLine();
            ChuyenChu(s);
            Console.WriteLine("Chuoi sau khi xu ly: " + ChuyenChu(s));
            Console.ReadKey();
        }
    }
}
