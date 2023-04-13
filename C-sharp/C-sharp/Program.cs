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
            object obj1 = 20;   //reference type이므로
            object obj2 = 20;   //주소를 참조하고 있어 다름
            int num1 = 10;
            int num2 = 10;

            if (obj1 == obj2)
            {
                Console.WriteLine("object obj1과 obj2는 같습니다.");
            }
            else
            {
                Console.WriteLine("object obj1과 obj2는 같지 않습니다.");
            }

            if (num1 == num2)
            {
                Console.WriteLine("object num1과 num2는 같습니다.");
            }
            else
            {
                Console.WriteLine("object num1과 num2는 같지 않습니다.");
            }
        }
    }
}
