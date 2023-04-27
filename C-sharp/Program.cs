using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface interA
{
    void a();
}
interface interB
{
    void b();
}
interface interC : interA
{
    void c();
}
class MultiInheritance : interB, interC
{
    public void a() //interC가 interA를 상속받았으므로 구현 필요
    {
        Console.WriteLine("a메소드 호출");
    }
    public void b()
    {
        Console.WriteLine("b메소드 호출");
    }
    public void c()
    {
        Console.WriteLine("c메소드 호출");
    }
}
class Program
{
    static void Main()
    {
        MultiInheritance mi = new MultiInheritance();
        interA interface1 = mi;
        interB interface2 = mi;
        interC interface3 = mi;
        interface1.a();
        interface2.b();
        interface3.c();
        mi.a();
        mi.b();
        mi.c();
    }
}
