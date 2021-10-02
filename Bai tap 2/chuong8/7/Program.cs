using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            string duonngdan = @"D:\Bai tap 2";
            string ten = "input.txt";
            string input = Path.Combine(duonngdan, ten);
            string buffer;
            StreamReader sr = File.OpenText(input);
            while ((buffer = sr.ReadLine()) != null)
            {
                //("=" + (1 + 2)) + ("=" + (18 - 7)) + "=" + (5 * 12) + "=" + (89 / 29)
                Console.WriteLine(buffer);
            }
            Console.WriteLine();
            Console.WriteLine("1+2=" + (1 + 2));
            Console.WriteLine("18-7=" + (18 - 7));
            Console.WriteLine("5*12=" + (5 * 12));
            Console.WriteLine("89/29=" + (89 / 29));
            sr.Close();
            Console.WriteLine();
            string duonngdan2 = @"D:\bài tập";
            string output = "output.txt";
            string coppy = Path.Combine(duonngdan2, output);
            File.Copy(input, coppy);
            Console.WriteLine("da tao fie moi");
            Console.ReadKey();

        }
    }
}
