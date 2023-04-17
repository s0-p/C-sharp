using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class Program
    {
        static void Swap(ref int num1, ref int num2)
        {
            int tmp = num1;
            num1 = num2;
            num2 = tmp;
        }
        static void Increment(ref int num)
        {
            num++;
        }
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("현재 값 : {0}", num1);
            Increment(ref num1);
            Console.WriteLine("증가 후 값 : {0}", num1);

            Console.WriteLine("현재 num1 값: {0} num2 값: {1}", num1, num2);
            Swap(ref num1, ref num2);
            Console.WriteLine("swap 후 num1 값: {0} num2 값: {1}", num1, num2);
        }
    }
}
