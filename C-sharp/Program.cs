using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Animal
{
    public Animal()
    {
        Console.WriteLine("나는 동물입니다.");
    }
    public virtual void Bark()
    {
        Console.WriteLine("울음소리를 냅니다.");
    }
    public virtual void Attack()
    {
        Console.WriteLine("공격을 시작합니다.");
    }
}
class Cat : Animal
{
    public Cat()
    {
        Console.WriteLine("나는 고양이입니다.");
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

class Program
{
    static void Main()
    {
        Animal ani = new Animal();
        Cat cat = new Cat();    //Cat을 instanciate 하기 전에 Animal을 instanciate
        Dog dog = new Dog();
        ani.Bark();
        cat.Bark();
        dog.Bark();
        List<Animal> listAni = new List<Animal>() { new Animal(), new Cat(), new Dog() };
        for (int i = 0; i < listAni.Count; i++)
        {
            listAni[i].Attack();
        }
    }
}

//결과
//나는 동물입니다.
//나는 동물입니다.
//나는 고양이입니다.
//나는 동물입니다.
//나는 개입니다.
//울음소리를 냅니다.
//냐옹
//멍멍
//나는 동물입니다.
//나는 동물입니다.
//나는 고양이입니다.
//나는 동물입니다.
//나는 개입니다.
//공격을 시작합니다.
//핡퀴기 공격
//물기 공격

