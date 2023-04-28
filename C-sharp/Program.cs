using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{   private static void FileWrite(string fileName, string text)
    {
        string path = @"D:\test\" + fileName;
        FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine(text);
        //sw.Flush();
        sw.Close();
        Console.WriteLine("저장 완료");
    }
    static void Main()
    {
        Console.WriteLine("읽어올 파일 이름을 입력해 주세요.");
        string fileName = Console.ReadLine();
        FileWrite(fileName, "안녕하세요 SBS 게임 아카데미 입니다.");
    }
}
