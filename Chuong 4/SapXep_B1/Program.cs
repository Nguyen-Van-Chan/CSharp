using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapXep_B1
{
    class Program
    {
        public static void SXGiamDan(int[] a,int n)
        {
            int temp;
            for(int i=0;i<n;i++)
                for(int j=i+1;j<n;j++)
                    if(a[i]<a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;   
                    }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu cua mang: ");
            int pt = int.Parse(Console.ReadLine());
            int[] mang = new int[pt];
            for (int i = 0; i < pt; i++)
            {
                Console.WriteLine("Phan tu thu {0}: ", i + 1);
                mang[i] = int.Parse(Console.ReadLine());
            }
            SXGiamDan(mang, pt);
            for (int i = 0; i < pt; i++)
            {
                Console.Write(mang[i]+"\t");                
            }
            Console.ReadKey();
        }
    }
}
