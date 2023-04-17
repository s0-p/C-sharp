using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hero
{
    private const int MAX_HP = 500;
    private int hp = 0;
    public int GetHP()
    {
        return hp;
    }
    public void SetHP(int hp)
    {
        this.hp = hp;
    }
    public Hero()
    {
        hp = MAX_HP;
    }
    public void LevelUp()
    {
        hp = MAX_HP;
    }
}

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myhero = new Hero();
            if (myhero.GetHP() - 300 > 0)
            {
                myhero.SetHP(myhero.GetHP() - 300);
            }
            Console.WriteLine("현재 HP: " + myhero.GetHP());
        }
    }
}
