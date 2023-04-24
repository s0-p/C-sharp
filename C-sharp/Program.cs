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
            LinkedList<string> genLL = new LinkedList<string>();
            genLL.AddLast("4등");
            genLL.AddFirst("1등");
            genLL.AddAfter(genLL.Find("1등"), "2등");
            genLL.AddBefore(genLL.Find("4등"), "3등");
            Console.WriteLine("[LinkedList]");
            genLL.Remove("1등");
            foreach (string str in genLL)
            {
                Console.WriteLine("Value = {0}", str);
            }
        }
    }
}
