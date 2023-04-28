using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
interface Polygon
{
    int area(int a);

    int perimeter(int a);
}
class Squre : Polygon
{
    public int area(int a)
    {
        return a * a;
    }
    public int perimeter(int a)
    {
        return 4 * a;
    }
}
class Triangle : Polygon
{
    public int area(int a)
    {
        return a * a / 2;
    }
    public int perimeter(int a)
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
