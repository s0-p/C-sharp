using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate T TestDelegate<T>(T a, T b);
class Calculator
{
    public int Plus(int a, int b)
    {
        return a + b;
    }
    public float Plus(float a, float b)
    {
        return a + b;
    }
    public int Minus(int a, int b)
    {
        return a - b;
    }
    public float Minus(float a, float b)
    {
        return a - b;
    }
    public int Multiply(int a, int b)
    {
        return a * b;
    }
    public float Multiply(float a, float b)
    {
        return a * b;
    }
}

namespace C_sharp
{   
    class Program
    {
        public static void PrintCal<T>(T a, T b, TestDelegate<T> callback)
        {
            Console.WriteLine(callback(a, b));
        }
       
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            PrintCal<int>(10, 20, cal.Plus);
            PrintCal<float>(54.6f, 96.32f, cal.Plus);
            PrintCal<float>(200.5f, 120.10f, cal.Multiply);
            PrintCal<float>(36.5f, 42.3f, cal.Multiply);
        }
    }
}
