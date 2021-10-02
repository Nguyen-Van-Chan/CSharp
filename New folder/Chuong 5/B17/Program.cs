using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B17
{
    class Program
    {
        public static int SIZE = 256;
        static char KTXuatHienNhieuNhat(string str)
        {
            int[] count = new int[SIZE];
            for (int i = 0; i < str.Length; i++)
                count[str[i]]++;
            int max = -1; 
            char result = ' '; 
            for (int i = 0; i < str.Length; i++)
            {
                if (max < count[str[i]])
                {
                    max = count[str[i]];
                    result = str[i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 chuoi ky tu: ");
            string s = Console.ReadLine();
            Console.WriteLine("Ky tu {0} xuat hien nhieu lan nhat.", KTXuatHienNhieuNhat(s));        
            Console.ReadKey();
        }
    }
}
