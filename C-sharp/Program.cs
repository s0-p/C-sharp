using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class Program
{
    static void Main()
    {
        Action<string> Print = (str) => Console.WriteLine(str);
        Action<int, int> Add = (a, b) => Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        Action<int, int> Mul = (a, b) => Console.WriteLine("{0} + {1} = {2}", a, b, a * b);
        Action<double> FtoC = (F) => Console.WriteLine("화씨 {0} -> 섭씨 {1}", F, (F - 32) * 5 / 9);
        Action<double> CtoF = (C) => Console.WriteLine("섭씨 {0} -> 화씨 {1}", C, C * 9 / 5 + 32);

        Print("안녕하세요. SBS 게임 아카데미입니다.");
        Add(10, 20);
        FtoC(132.2d);
        CtoF(36.5d);
    }

}
