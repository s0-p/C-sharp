using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "    world";
            string str2 = "HELLO";
            Console.WriteLine(str.Insert(1, "HELLO"));
            Console.WriteLine(str.PadLeft(10));
            Console.WriteLine(str.PadLeft(10, '*'));
            Console.WriteLine(str.PadRight(10));
            Console.WriteLine(str.PadRight(10, '*'));
            Console.WriteLine(str.Remove(4));
            Console.WriteLine(str.Remove(4, 2));
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str2.ToLower());
            Console.WriteLine(str.Trim());
            // str을 변경하는 것이 아닌 새로운 문자열을 만들어 출력
        }
    }
}
