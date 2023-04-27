using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface CarControl
{
    void Gear(int value);
    void Off();
}
interface AudioControl
{
    void Volum(int value);
    void Off();
}
public class Car : CarControl, AudioControl
{
    public void Gear(int value)
    {
        Console.WriteLine("현재 기어는 {0}입니다.", value);
    }
    public void Volum(int value)
    {
        Console.WriteLine("현재 볼륨은 {0}입니다.", value);
    }
    public void Off()   //??
    {
        Console.WriteLine("시동을 껐습니다.");
    }
}

class Program
{
    static void Main()
    {
        Car mycar = new Car();
        mycar.Gear(3);
        mycar.Volum(5);
        mycar.Off();
    }
}
