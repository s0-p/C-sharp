using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBase
{
    public class Monster
    {
        public int HP { get; set; }
        public int Atk { get; set; }
        public Monster() { Start(); }
        protected virtual void Start()
        {
            InitStat();
        }
        public virtual void InitStat()
        {
            HP = 10;
            Atk = 20;
        }
        public bool IsLive()
        {
            return HP > 0;
        }
        public void Info()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("HP : " + HP);
            Console.WriteLine("ATK : " + Atk);
            Console.WriteLine("----------------------");
        }
    }
}
