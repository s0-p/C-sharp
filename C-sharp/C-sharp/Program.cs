using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] arr = new int[5] { 10, 20, 30, 40, 50 };

            foreach (int n in arr)
            {
                Console.WriteLine("arr[{0}] : {1}", i, n);
                i++;
            }
            Console.WriteLine();
            for (int n = 0; n < arr.Length; n++)
            {
                Console.WriteLine("arr[{0}] : {1}", n, arr[n]);
            }
        }
    }
}
