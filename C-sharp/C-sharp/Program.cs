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
            string str = "Hello World";
            foreach (char c in str)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
