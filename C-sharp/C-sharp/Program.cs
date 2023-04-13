using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Monster
{
    public int hp;
    public int mp;
}
class Hero
{
    public int hp;
    public int mp;
}
namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster monster;    //value type
            monster.hp = 100;
            monster.mp = 200;

            Hero hero = new Hero(); // 생성자로 Hero 크기만큼 heap 메모리 할당 -> reference type
            // hero <- 객체, instance화하다(instansiate)
            hero.hp = 400;
            hero.mp = 100;
        }
    }
}
