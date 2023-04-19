using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{   
    class Program
    {
        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("arr[{0}, {1}] = {2}", i, j, arr[i, j]);
                }
            }
        }

        static void Main(string[] args)
        {
            PrintArray(new int [,] { { 1, 2 }, { 3, 4 }, { 5,6 }, { 7, 8 } });
        }
    }
}
