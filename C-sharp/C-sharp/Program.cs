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
            string[] arr = new string[] { "hello", "sbs", "game", "academy" };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }

        }
    }
}
