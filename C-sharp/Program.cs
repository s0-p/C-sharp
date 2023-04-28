using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BaseC
{
    public virtual void PrintMethod()
    {
        Console.WriteLine("부모 클래스 Method");
    }
}
class DrivedC : BaseC
{
    public override void PrintMethod()
    {
        Console.WriteLine("부모 Method 재정의");
    }
    public void PrintMethod2()
    {
        Console.WriteLine("자식 클래스 Method");
    }
}

class Program
{
    void CastingTest(object obj)
    {
        BaseC baseC;
        bool already = obj is BaseC;
        if (already)
        {
            baseC = obj as BaseC;
            if (baseC != null)
            {
                baseC.PrintMethod();
            }
        }
        BaseC baseC2 = (BaseC)obj;
        baseC2.PrintMethod();
    }
    static void Main()
    {
        DrivedC drivedC = new DrivedC();
        new Program().CastingTest(drivedC);
        drivedC.PrintMethod();
        drivedC.PrintMethod2();
    }
}
