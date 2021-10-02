using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    arr[i] = rand.Next(1, 10);

                else
                    arr[i] = (rand.Next(1, 10)) * -1;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
