using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B15
{
    class Program
    {
        public static string MangSo(string s)
        {
            string kq = "";
            for (int i = 0; i < s.Length; i++)
                if (s[i] >= '0' && s[i]<='9')
                    kq += s[i];
            return kq;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 chuoi ky tu: ");
            string s = Console.ReadLine();
            Console.WriteLine("Mang so sau khi tach: ");
            char[] kq = MangSo(s).ToCharArray();
            for (int i = 0; i < kq.Length; i++)
                Console.Write(kq[i] + "\t");
            Console.ReadKey();
        }
    }
}
