using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B16
{
    class Program
    {
        public static void Xoa(ref string s,char x)
        {
           // int vt = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == x)
                    s = s.Remove(i, 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 chuoi ky tu: ");
            string s = Console.ReadLine();
            Console.WriteLine("Nhap vao ky tu muon xoa: ");
            char kt =char.Parse( Console.ReadLine());
            Xoa(ref s, kt);
            Console.WriteLine("chuoi sau khi xoa ky tu {0} la: {1}", kt, s);
            Console.ReadKey();
        }
    }
}
