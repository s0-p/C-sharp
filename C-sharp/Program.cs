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
            Queue<int> genQueue = new Queue<int>();
            genQueue.Enqueue(1);
            genQueue.Enqueue(2);
            genQueue.Enqueue(3);
            Console.WriteLine("[Queue]");
            while(genQueue.Count > 0)
            {
                Console.WriteLine("Value = {0}", genQueue.Dequeue());
            }
            Console.WriteLine();
        }
    }
}
