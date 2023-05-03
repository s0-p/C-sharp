using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    static void Main()
    {
        Func<string> Print = () => "안녕하세요. SBS 게임 아카데미입니다.";
        Func<int, int, int> Add = (a, b) => a + b;
        Func<int, int, int> Mul = (a, b) => a * b;
        Func<double, double> FtoC = (F) => (F - 32) * 5 / 9;
        Func<double, double> CtoF = (C) => C * 9 / 5 + 32;

        Console.WriteLine("Func Print 값 : {0}", Print());
        Console.WriteLine("Func Add 값 : {0}", Add(10, 20));
        Console.WriteLine("Func FtoC 값 : {0}", FtoC(132.2d));
        Console.WriteLine("Func CtoF 값 : {0}", CtoF(36.5d));
    }
    
}
