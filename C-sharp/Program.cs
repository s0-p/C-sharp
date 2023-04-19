using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{   
    class Program
    {
        static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            string name = "박소영";
            int age = 24;
            float heignt = 180;
            double weight = 70.5;
            Print(name);
            Print(age);
            Print(heignt);
            Print(weight);
        }
    }
}
