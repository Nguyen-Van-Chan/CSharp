using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sohoanthien
{
    class Program
    {
        static void Main(string[] args)
        {            
            for (int j = 0; j < 100000; j++)
            {
                if(kiemtrasohoanthien(j) == 1)
                {
                    Console.Write(j+"\t");
                }
            }      
            Console.ReadKey();
        }
        public static int kiemtrasohoanthien(int so)
        {
           
            int s = 0;
            for (int i =1; i < so; i++)
            {
                if (so % i == 0)
                {
                    s += i; 
                }
            }
            if (s == so)
            {
                return 1;
            }
            else return 0;
        }

        
    }
}
