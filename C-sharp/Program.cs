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
            public void Method1()
            {
                Console.WriteLine("부모클래스 - Method1");
            }
        }
        class DreivedClass : BaseClass
        {
            public void Method2()
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
            }
        }
    }
}
