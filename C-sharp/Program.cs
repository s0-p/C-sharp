using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Car
{
    public virtual void DescribeCar()
    {
        Console.WriteLine("4개의 휠이 달린 바퀴와 엔진이 있습니다.");
        ShowDetails();
    }
    public virtual void ShowDetails()
    {
        Console.WriteLine("4명의 사람을 태울 수 있습니다.");
    }
}
class ConvertibleCar : Car
{
    //DescribeCar()는 부모클래스로 접근하므로 TestCars1에서 적용 X
    public new void ShowDetails()
    {
        Console.WriteLine("지붕이 열립니다.");
    }
}
class Minivan : Car
{
    public override void ShowDetails()
    {
        Console.WriteLine("7명을 태울 수 있습니다.");
    }
}

class Program
{
    public static void TestCars1()
    {
        Console.WriteLine("\nTestCars1");
        Console.WriteLine("-----------");

        Car car1 = new Car();
        car1.DescribeCar();
        Console.WriteLine("-----------");

        ConvertibleCar car2 = new ConvertibleCar();
        car2.DescribeCar();
        Console.WriteLine("-----------");

        Minivan car3 = new Minivan();
        car3.DescribeCar();
        Console.WriteLine("-----------");
    }
    public static void TestCars2()
    {
        Console.WriteLine("\nTestCars2");
        Console.WriteLine("-----------");
                                               //Car의 파생클래스이므로 가능
        var cars = new List<Car> { new Car(), new ConvertibleCar(), new Minivan() };
        foreach (var car in cars)
        {
            car.DescribeCar();
            Console.WriteLine("-----------");
        }
    }
    public static void TestCars3()
    {
        Console.WriteLine("\nTestCar3");
        Console.WriteLine("-----------");
        ConvertibleCar car2 = new ConvertibleCar();
        Minivan car3 = new Minivan();
        car2.ShowDetails();
        car3.ShowDetails();
    }
    
    static void Main()
    {
        TestCars1();
        TestCars2();
        TestCars3();
    }
}

