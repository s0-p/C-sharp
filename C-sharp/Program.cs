using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace C_sharp
{   
    class Program
    {
        delegate int TestDelegate(int a, int b);
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            TestDelegate calculate = new TestDelegate(Plus);
            int result = calculate(20, 30);
            Console.WriteLine("20 + 30 = " + result);
            calculate = new TestDelegate(Minus);
            result = calculate(30, 20);
            Console.WriteLine("30 - 20 = " + result);
        }
    }
}
