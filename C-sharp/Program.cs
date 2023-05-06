using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

class Program
{

    static void Main()
    {
        StringBuilder sb = new StringBuilder("안녕하세요!");
        Console.WriteLine(sb);
        sb.Append(" SBS 게임 아카데미입니다.");
        Console.WriteLine("Append() : {0}", sb);
        sb.AppendFormat(" 제 이름은 {0}이고 나이는 {1}살입니다.", "박소영", 24);
        Console.WriteLine("AppendFormat() : {0}", sb);
        sb.Remove(0, 6);
        Console.WriteLine("Remove() : {0}", sb);
        sb.Insert(12, "강남지점");
        Console.WriteLine("Insert() : {0}", sb);
        sb.Replace("강남지점", "신촌지점");
        Console.WriteLine("Replace() : {0}", sb);
        sb.Clear();
        Console.WriteLine("Clear() : {0}", sb);
    }

}
