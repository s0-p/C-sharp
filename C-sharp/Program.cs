using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class BaseClass
    {
        public static int x = 55;
        public static int y = 22;
    }
    class DreivedClass : BaseClass
    {
        new public static int x = 100;

        static void Main(string[] args)
        {
            Console.WriteLine(x);   //100
            Console.WriteLine(BaseClass.x); //55
            Console.WriteLine(y);   //22
        }
    }
}
