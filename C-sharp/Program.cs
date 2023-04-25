using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class Program
    {
        class BaseClass
        {
            public virtual void Method1()   //가상 함수
            {
                Console.WriteLine("부모클래스 - Method1");
            }
            public void Method2()
            {
                Console.WriteLine("부모클래스 - Method2");
            }
        }
        class DreivedClass : BaseClass
        {
            public override void Method1()   //덮어쓰기
            {
                Console.WriteLine("자식클래스 - Method1");
            }
            public new void Method2()   //한정자 ->  자식클래스 한정으로 새로 정의
            {
                Console.WriteLine("자식클래스 - Method2");
            }

            static void Main(string[] args)
            {
                BaseClass bc = new BaseClass();
                DreivedClass dc = new DreivedClass();
                BaseClass bcdc = new DreivedClass();
                bc.Method1();
                dc.Method1();
                dc.Method2();
                bcdc.Method1();
                bcdc.Method2();
            }
        }
    }
}
