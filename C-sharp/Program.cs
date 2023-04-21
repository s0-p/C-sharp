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
            Queue que = new Queue();
            que.Enqueue(10);
            que.Enqueue(20);
            que.Enqueue(30);
            que.Dequeue();
            que.Enqueue(4.4);
            que.Dequeue();
            que.Enqueue("ABC");
            while (que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }
        }
    }
}
