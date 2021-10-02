using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chuong8
{
    class Program
    {
        static void Main(string[] args)
        {
            string ten = @"D:\Bai tap 2";
            Console.WriteLine("nhap ten tap tin: ");
            string name = Console.ReadLine();
            string sour = Path.Combine(ten, name);
            StreamWriter fl = File.CreateText(sour);
            fl.WriteLine("****************");
            for (int i = 0; i < 10; i++)
            {
                fl.Write(i + "\t");
            }
            fl.Close();
            Console.WriteLine("Ghi thanh cong");
            Console.ReadKey();
        }
    }
}
