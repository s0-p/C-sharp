using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Point
{
    private int x;
    private int y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public void Print()
    {
        System.Console.WriteLine("({0}, {1})", x, y);
    }
}
namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] arr = new Point[] { new Point(1, 1), new Point(2, 2), new Point(3, 3) };

            foreach (Point pt in arr)
            {
                pt.Print();
            }
        }
    }
}
