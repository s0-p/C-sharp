using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace C_sharp
{
    class Program
    {
        static void Main()
        {
            Stack<int> genStack = new Stack<int>();
            genStack.Push(1);
            genStack.Push(2);
            genStack.Push(3);
            Console.WriteLine("[Stack]");
            while(genStack.Count > 0)
            {
                Console.WriteLine("Value = {0}", genStack.Pop());
            }
            Console.WriteLine();
        }
    }
}
