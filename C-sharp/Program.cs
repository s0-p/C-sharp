using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
abstract class Abstract
{
    protected int x = 10;
    public abstract int X { get; set; }
    public abstract void Func();
}
class General : Abstract
{
    public override int X
    {
        get { return x + 20; }
        set { x = value; }
    }
    public override void Func()
    {
        Console.WriteLine("추상화 클래스 구현");
    }
}

class Program
{
    static void Main()
    {
        General gn = new General();
        Console.WriteLine("프로퍼티 X의 값 : " + gn.X);
        gn.Func();
    }
}
