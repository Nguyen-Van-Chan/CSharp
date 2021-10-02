using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dem = 0;
            Console.WriteLine("Nhap vao 1 chuoi ky tu: ");
            string s = Console.ReadLine();
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                    dem++;
            }
            Console.WriteLine("So ky tu co trong chuoi: " +dem);
            Console.ReadKey();
        }
    }
}
