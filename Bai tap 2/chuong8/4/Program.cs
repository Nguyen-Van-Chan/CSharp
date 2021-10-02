using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4
{
    class Program
    {

        static void Main(string[] args)
        {
            string ten = @"D:\Bai tap 2";
            Console.WriteLine("Nhap ten tap tin: ");
            string name = Console.ReadLine();
            string duongdan =  Path.Combine(ten,name);
            StreamWriter fl = File.CreateText(duongdan);
            int[] a = new int[100];
            Random rnd = new Random();
            int rn = rnd.Next(-40, 40);
            a[0] = rn;
            for (int i = 1; i < 100; i++)
            {
                do
                {
                    rn = rnd.Next(-40, 40);
                    if (rn >= a[i - 1])
                        a[i] = rn;
                }
                while (rn < a[i - 1]);

            }
            for (int j = 0; j < 100; j++)
                Console.Write(a[j] + "\t");
            fl.Close();
            Console.WriteLine("Ghi thanh cong");
            Console.ReadKey();
        
        }
    }
}
