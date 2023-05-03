using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    delegate void MyDelegate(int a, int b);
    static void Main()
    {
        MyDelegate Compare = (a, b) =>
        {
            if (a > b)
            {
                Console.WriteLine("{0} > {1}", a, b);
            }
            else if (a < b)
            {
                Console.WriteLine("{0} < {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} == {1}", a, b);
            }
        };
        Compare(30, 60);
        Compare(60, 30);
        Compare(100, 100);
    }
    
}
