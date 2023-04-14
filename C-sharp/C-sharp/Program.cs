using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Point
    {
        private int x, y;
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
}
namespace B
{
    class Point
    {
        private int x, y;
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
}

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            A.Point point1 = new A.Point(2, 3);
            B.Point point2 = new B.Point(4, 5);
        }
    }
}
