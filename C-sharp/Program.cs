using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BaseC
{
    public class NestedC
    {
        public int x = 200;
        public int y;
    }
}

public class DrivedC : BaseC
{
    new public class NestedC
    {
        public int x = 100;
        public int y;
        public int z;
    }

    static void Main(string[] args)
    {
        NestedC c1 = new NestedC();
        BaseC.NestedC c2 = new BaseC.NestedC();
        Console.WriteLine(c1.x);    //100
        Console.WriteLine(c2.x);    //200
    }
}