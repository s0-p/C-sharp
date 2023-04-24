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
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(1);
            LinkedListNode<int> firstNode = linkedList.First;
            LinkedListNode<int> currentNode = linkedList.AddAfter(firstNode, 3);
            currentNode = linkedList.AddBefore(currentNode, 2);
            Console.WriteLine("첫번째 노드의 값: {0}", currentNode.Previous.Value);
            Console.WriteLine("두번째 노드의 값: {0}", currentNode.Value);
            Console.WriteLine("세번째 노드의 값: {0}", currentNode.Next.Value);

        }
    }
}
