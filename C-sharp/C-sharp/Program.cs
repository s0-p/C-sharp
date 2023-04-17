using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class Program
    {
        static void Add(int c, int d, out int sum)
        {
            sum = c + d;
        }
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 20;
            int sum;
            Add(num1, num2, out sum);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
        }
    }
}
