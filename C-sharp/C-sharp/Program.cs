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
            Console.WriteLine("int형의 크기: " + sizeof(int) + "최소 값: " + int.MinValue + "최대 값: " + int.MaxValue);
            Console.WriteLine("long형의 크기: " + sizeof(long) + "최소 값: " + long.MinValue + "최대 값: " + long.MaxValue);
            Console.WriteLine("char형의 크기: " + sizeof(char) + "최소 값: " + char.MinValue + "최대 값: " + char.MaxValue);
            Console.WriteLine("float형의 크기: " + sizeof(float) + "최소 값: " + float.MinValue + "최대 값: " + float.MaxValue);
            Console.WriteLine("double형의 크기: " + sizeof(double) + "최소 값: " + double.MinValue + "최대 값: " + double.MaxValue);
            Console.WriteLine("decimal형의 크기: " + sizeof(decimal) + "최소 값: " + decimal.MinValue + "최대 값: " + decimal.MaxValue);
        }
    }
}
