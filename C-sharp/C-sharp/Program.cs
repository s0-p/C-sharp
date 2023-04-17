using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hero
{
    private const int MAX_HP = 500;
    private int hp = 0;
    //property
    public int HP { get { return hp; } }
    public Hero()
    {
        hp = MAX_HP;
    }
    public void LevelUp()
    {
        hp = MAX_HP;
    }
    public void Damage(int dmg)
    {
        if (hp - dmg > 0)
        {
            hp -= dmg;
        }
        else
        {
            hp = 0;
        }
    }
}

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myhero = new Hero();
            if (myhero.HP - 300 > 0)
            {
                myhero.Damage(300);
            }
            Console.WriteLine("현재 HP: " + myhero.HP);
        }
    }
}
