using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sx1
{
    class Program
    {
        public static void nhapmang(int[,] a, int dong,int cot)
        {
            for (int i = 0; i < dong; i++)
                for (int j = 0; j < cot; j++)
                {
                    Console.Write("nhapmang a[{0},{1}]: ",i+1,j+1);
                    a[i, j] = int.Parse(Console.ReadLine());
                }			
        }
        public static void xuatmang(int [,]a,int dong,int cot)
    {
        for (int i = 0; i < dong; i++)
        { 
            for (int j = 0; j < cot; j++)
            {
                Console.Write(a[i, j] + "\t");
            }
                Console.WriteLine();
            }
    }
        static void Main(string[] args)
        {
            int d, c;
            Console.Write("nhap so dong: ");
            d = int.Parse(Console.ReadLine());
            Console.Write("nhap so cot: ");
            c = int.Parse(Console.ReadLine());
            int[,] matran = new int[d, c];
            nhapmang(matran, d, c);
            xuatmang(matran,d,c);
            Console.ReadKey();

        }
    }
}
