using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
class TestSingleton : Singleton<TestSingleton>
{
    public void DrawMessage()
    {
        Console.WriteLine("안녕하세요. SBS 게임 아카데미 입니다.");
    }
}

class Program
{

    static void Main()
    {
        TestSingleton.Instance.DrawMessage();
    }

}

//#region Constants and Fields
//#endregion
//#region Public Properties
//#endregion
//#region Public Methods and Operators
//#endregion
