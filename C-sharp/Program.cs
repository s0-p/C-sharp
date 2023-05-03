using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class Monster
{
    #region Constants and Fields
    public int _hp { get; set; }
    public int _def { get; set; }
    public int _atk { get; set; }
    public bool _isAlive { get; set; }
    #endregion
    #region Public Properties
    public void InitMonster()
    {
        _hp = 100;
        _def = 20;
        _atk = 150;
        _isAlive = true;
    }
    #endregion
    #region Public Methods and Operators
    public void MonsterInfo()
    {
        Console.WriteLine("HP : {0}", _hp);
        Console.WriteLine("DEF : {0}", _def);
        Console.WriteLine("ATK : {0}", _atk);
        Console.WriteLine();
    }
    #endregion
}
public class Singleton<T> where T : class, new()
{   
    static Singleton()
    {
        if (Singleton<T>.Instance == null)
        {
            Singleton<T>.Instance = new T();
        }
    }
    public static T Instance { get; private set; }

    
}

public class MonsterManager : Singleton<MonsterManager>
{
    #region Constants and Fields
    List<Monster> _monList = new List<Monster>();
    #endregion
    #region Public Properties
    public int Count {  get { return _monList.Count; } }
    public Monster GetMonster(int idx)
    {
        return _monList[idx];
    }
    public void InitMonsters()
    {
        for (int i = 0; i < _monList.Count; i++)
        {
            _monList[i].InitMonster();
        }
    }
    #endregion
    #region Public Methods and Operators
    public void Add(Monster mon)
    {
        _monList.Add(mon);
    }
    public bool Remove(Monster mon)
    {
        return _monList.Remove(mon);
    }
    public void RemoveAll()
    {
        _monList.RemoveAll(element => element._isAlive == true);
    }
    public void Clear()
    {
        _monList.Clear();
    }
    
    public void DrawonstersInfo()
    {
        for (int i = 0; i < _monList.Count; i++)
        {
            _monList[i].MonsterInfo();

        }
    }
    #endregion
}
public class Stage
{
    #region Constants and Fields
    const int MONSTER_MAX = 10;
    #endregion
    #region Public Properties

    #endregion
    #region Public Methods and Operators
    public void CreateMonsters()
    {
        for (int i = 0; i < MONSTER_MAX; i++)
        {
            MonsterManager.Instance.Add(new Monster());
        }
        MonsterManager.Instance.InitMonsters();
    }
    public bool IsClear()
    {
        for (int i = 0; i < MonsterManager.Instance.Count; i++)
        {
            Monster mon = null;
            if ((mon = MonsterManager.Instance.GetMonster(i)) != null)
            {
                if (mon._isAlive)
                {
                    return false;
                }
            }
        }
        return true;
    }
    #endregion
}

class Program
{

    static void Main()
    {
        Stage stage = new Stage();
        stage.CreateMonsters();
        MonsterManager.Instance.DrawonstersInfo();
        Console.WriteLine("Stage Clear : {0}", stage.IsClear());
    }

}
