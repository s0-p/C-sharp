using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace C_sharp
{
    class Program
    {
        static void Main()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Pop();    //  30
            stack.Push(4.4);
            stack.Pop();    // 4.4
            stack.Push("ABC");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());     //LIFO
            }
        }
    }
}
