using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 chuoi ky tu: ");
            string s = Console.ReadLine();
            int temp;
            char c;
            for (c = (char)65; c <= 90; c++)
            {
                temp = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (c == s[i] || (c + 32) == s[i])
                        temp++;
                }

                if (temp > 0)
                {
                    Console.WriteLine("Ky tu {0} xuat hien: {1} lan", c, temp);
                }
            }
            Console.ReadKey();
        }
    }
}
