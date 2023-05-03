using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Singleton
{
    #region Constants and Fields
    private static Singleton _instance = null;
    #endregion
    
    #region Public Properties
    private Singleton() { }
    public static Singleton Instance
    {
        get {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
    #endregion

    #region Public Methods and Operators
    public void DrawMessage()
    {
        Console.WriteLine("안녕하세요. SBS 게임 아카데미 입니다.");
    }
    #endregion
}

class Program
{

    static void Main()
    {
        Singleton.Instance.DrawMessage();
    }

}

//#region Constants and Fields
//#endregion
//#region Public Properties
//#endregion
//#region Public Methods and Operators
//#endregion
