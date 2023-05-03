using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    public static string UpperCaseString(string inputString)
    {
        return inputString.ToUpper();
    }
    public static string DrawMessage()
    {
        return "안녕하세요. SBS 게임 아카데미 입니다.";
    }
    static void Main()
    {
        Func<string, string> func1 = UpperCaseString;
        Func<string> func2 = DrawMessage;
        string name = "Park So Yeong";
        Console.WriteLine(func1(name));
        Console.WriteLine(func2());
    }
    
}
