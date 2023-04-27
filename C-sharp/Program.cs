using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Animal
{
    public abstract void Bark();
    public abstract void Attack();
}
class Cat : Animal
{
    public Cat()
    {
        Console.WriteLine("나는 고양이 입니다.");
    }
    public override void Bark()
    {
        Console.WriteLine("냐옹");
    }
    public override void Attack()
    {
        Console.WriteLine("핡퀴기 공격");
    }
}
class Dog : Animal
{
    public Dog()
    {
        Console.WriteLine("나는 개입니다.");
    }
    public override void Bark()
    {
        Console.WriteLine("멍멍");
    }
    public override void Attack()
    {
        Console.WriteLine("물기 공격");
    }
}
class Bird : Animal
{
    public Bird()
    {
        Console.WriteLine("나는 새입니다.");
    }
    public override void Bark()
    {
        Console.WriteLine("짹짹");
    }
    public override void Attack()
    {
        Console.WriteLine("쪼기 공격");
    }
}
class Program
{
    static void Main()
    {
        Cat cat = new Cat();
        Dog dog = new Dog();
        Bird bird = new Bird();
        cat.Bark();
        dog.Bark();
        bird.Bark();

        List<Animal> listAni = new List<Animal>() { new Cat(), new Dog(), new Bird() };
        for (int i = 0; i < listAni.Count; i++)
        {
            listAni[i].Attack();
        }
    }
}
