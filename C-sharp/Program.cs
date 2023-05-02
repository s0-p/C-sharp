using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    delegate int MyDelegate(int a, int b);
    static void Main()
    {
        MyDelegate Add = delegate (int a, int b)
        {
            return a + b;
        };
        MyDelegate Multi = delegate (int a, int b)
        {
            return a * b;
        };
        Console.WriteLine(Add(100, 200));
        Console.WriteLine(Multi(20, 50));
    }
    
}
