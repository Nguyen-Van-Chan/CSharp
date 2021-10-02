using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace doc_nhi_phan
{
    class Program
    {
        static void Main(string[] args)
        {
            string ten = @"D:\Bai tap 2";
            Console.WriteLine("nhap ten tap tin: ");
            string name = Console.ReadLine();
            string sour = Path.Combine(ten, name);
            FileStream fs = new FileStream(sour, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            Console.WriteLine("dang doc tap tin..");
            while (br.PeekChar() != -1)
                Console.Write("<{0}> ", br.ReadInt32());
            Console.WriteLine();
            Console.WriteLine("...Doc xong");
            br.Close();
            Console.ReadKey();
        }
    }
}
