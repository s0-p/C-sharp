using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterBase;
using MonsterBoss;

class Stage
{
    protected List<Monster> MobList = new List<Monster>();
    public void Start()
    {
        MobList.Add(new Monster());
        MobList.Add(new Monster());
        MobList.Add(new MonsterBoss.MonsterBoss());
    }
    public void DrawMonster()
    {
        for (int i = 0; i < MobList.Count; i++)
        {
            Monster tmp = (Monster)MobList[i];
            tmp.Info();
        }
    }
    public bool CheckClear()
    {
        for (int i = 0; i < MobList.Count; i++)
        {
            Monster tmp = (Monster)MobList[i];
            if (tmp.IsLive())
            {
                return false;
            }
        }
        return true;
    }
}