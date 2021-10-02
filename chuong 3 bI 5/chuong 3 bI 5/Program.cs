using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong_3_bI_5
{
    class Program
    {
        public static void ChinhPhuong(int n)
        {
            int i = 1, j, dem = 0;
            int chinhphuong = 0;
            while (dem < n)
            {
                chinhphuong = 0;
                for (j = 1; j <= i; j++)
                {
                    if (j * j == i)
                    {
                        chinhphuong = 1;
                    }
                }
                    if (chinhphuong == 1)
                    {
                        Console.Write("\t {0}", i);
                        dem++;
                    }
                    i++;
                }
            }    
        static void Main(string[] args)
        {
        int n;
         do
         {
           Console.Write("Nhap n: ");
           n = Convert.ToInt32(Console.ReadLine());
         }
         while(n<=0);
         Console.Write("Cac so chinh phuong la: ");
         ChinhPhuong(n);
         Console.ReadKey();
     
        }
    }
}
