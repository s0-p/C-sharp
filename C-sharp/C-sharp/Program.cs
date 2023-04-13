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
            int num = 10;
            Object o = num; //boxing
            o = 1234;   //garbage collector 발생 -> 일정량 쌓이면 자동 정리
            num = (int)o; //unboxing, casting 필수
            Console.WriteLine("Object o의 값: {0} int a의 값: {1}", o, num);
            
            //Object형을 사용하지 않는것이 바람직,,
        }
    }
}
