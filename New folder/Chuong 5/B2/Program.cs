﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Program
    {
        public static int SoKhoangTrang(string s)
        {
            int dem = 0;
            for (int i = 0; i < s.Length; i++)
                if (s[i] == ' ')
                    dem++;
            return dem;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 chuoi ky tu: ");
            string s = Console.ReadLine();
            Console.WriteLine("So khoang trang trong chuoi s la: " + SoKhoangTrang(s));
            Console.ReadKey();
        }
    }
}
