using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Character
{
    public virtual void ReadyToBattle()
    {
        Console.WriteLine("전투 태세를 취합니다.");
    }
}
public class Knight : Character
{
    public override void ReadyToBattle()
    {
        Console.WriteLine("기사 : 칼을 뽑아 전투 태세를 취합니다.");
    }
    public override string ToString()
    {
        return "기사 클래스";
    }
}
public class Acher : Character
{
    public override void ReadyToBattle()
    {
        Console.WriteLine("궁수 : 활을 뽑아 전투 태세를 취합니다.");
    }
    public override string ToString()
    {
        return "궁수 클래스";
    }
}

class Program
{
    static void Main()
    {
        Character[] characters = new Character[2];

        characters[0] = new Knight();
        characters[1] = new Acher();

        for (int i = 0; i < characters.Length; i++)
        {
            Console.WriteLine(characters[i].ToString());
            characters[i].ReadyToBattle();
        }
    }
}

