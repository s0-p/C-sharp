using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
abstract class Abstract
{
    protected int x = 10;
    public abstract int X { get; set; }
    public virtual void Func()
    {
        Console.WriteLine("가상 클래스 선언");
    }
    public void Func2()
    {
        Console.WriteLine("일반 메소드 호출");
    }
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
        base.Func();
        Console.WriteLine("가상 클래스 구현");
    }
}

class Program
{
    static void Main()
    {
        General gn = new General();
        Console.WriteLine("프로퍼티 X의 값 : " + gn.X);
        gn.Func();
        gn.Func2();
    }
}
