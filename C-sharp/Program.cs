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
    void CarControl.Off()
    {
        Console.WriteLine("자동차 시동을 끕니다.");
    }
    void AudioControl.Off()
    {
        Console.WriteLine("오디오 전원을 끕니다.");
    }
}

class Program
{
    static void Main()
    {
        Car mycar = new Car();
        mycar.Gear(3);
        mycar.Volum(5);

        CarControl carCon = mycar;
        AudioControl audioCon = mycar;
        carCon.Off();
        audioCon.Off();
    }
}
