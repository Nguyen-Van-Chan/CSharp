using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace luu_so_nhi_phan
{
    class Program
    {
        static void Main(string[] args)
        {
            string ten = @"D:\Bai tap 2";
            Console.WriteLine("Nhap ten tap tin: ");
            string name = Console.ReadLine();
            string sour = Path.Combine(ten, name);
            FileStream fs = new FileStream(sour, FileMode.CreateNew);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i <=100; i++)
            {
                bw.Write(i);
            }
            bw.Close();
            fs.Close();
            Console.WriteLine("Ghi thanh cong");
            Console.ReadKey();
        }
    }
}
