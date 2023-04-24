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
            List<string> list = new List<string>();
            list.Add("트럼프");
            list.Add("오바마");
            list.Add("힐러리");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("{0}. {1}대통령", i, list[i]);
            }
            Console.WriteLine("컬렉션의 현재 배열 크기 {0}", list.Capacity);
            Console.WriteLine("컬렉션에 저장된 요소 개수 {0}", list.Count);
            list.Insert(1, "부시");
            Console.WriteLine("리스트 1번째 대통령 {0}", list[1]);
            list.RemoveAt(1);
            Console.WriteLine("리스트 1번째 대통령 {0}", list[1]);
        }
    }
}
