using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao ho va ten: ");
            string s = Console.ReadLine();
            Console.WriteLine("Nhap vao tu: ");
            string t = Console.ReadLine();
            int vt = s.IndexOf(t);
            string snew = s.Substring(vt);
            Console.Write(Char.ToUpper(snew[0])+snew.Substring(1));
            Console.ReadKey();
        }
    }
}
