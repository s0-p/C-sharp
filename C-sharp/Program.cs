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
            int[,] array = new int[2, 3]
            {
                {1, 2, 3},
                {4, 5, 6}
            };
            foreach(int num in array)
            {
                Console.WriteLine(num + " ");
                i++;
                if (i % array.GetLength(1) == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
