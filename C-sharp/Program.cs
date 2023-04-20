using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int TestDelegate(int a, int b);
class Calculator
{
    public int Plus(int a, int b)
    {
        return a + b;
    }
    public int Minus(int a, int b)
    {
        return a - b;
    }
    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

namespace C_sharp
{   
    class Program
    {
        public static void PrintCal(int a, int b, TestDelegate callback)
        {
            Console.WriteLine(callback(a, b));
        }
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            PrintCal(10, 20, cal.Plus);
            PrintCal(10, 20, cal.Minus);
            PrintCal(10, 20, cal.Multiply);

        }
    }
}
