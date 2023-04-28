using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Polygon
{
    public virtual int area(int a)
    {
        return 0;
    }
    public virtual int perimeter(int a)
    {
        return 0;
    }
}
class Squre : Polygon
{
    public override int area(int a)
    {
        return a * a;
    }
    public override int perimeter(int a)
    {
        return 4 * a;
    }
}
class Triangle : Polygon
{
    public override int area(int a)
    {
        return a * a / 2;
    }
    public override int perimeter(int a)
    {
        return 3 * a;
    }
}

class Program
{
    static void Main()
    {
        Polygon sq = new Squre();
        Polygon tri = new Triangle();
        Console.WriteLine("area: {0}, perimeter: {1}", sq.area(2), sq.perimeter(4));
        Console.WriteLine("area: {0}, perimeter: {1}", tri.area(3), tri.perimeter(5));
    }
}
