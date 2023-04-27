using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IPoint
{
    int X { get; set; }
    int Y { get; set; }
}
class Point : IPoint
{
    int x;
    int y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public int X { get { return x; } set { x = value; } }
    public int Y { get { return y; } set { y = value; } }
    
}
class Program
{
    static void PrintPoint(IPoint p)
    {
        Console.WriteLine("x={0}, y={1}", p.X, p.Y);
    }
    static void Main()
    {
        Point p = new Point(2, 3);
        Console.Write("현재 촤표는 : ");
        PrintPoint(p);
    }
}
