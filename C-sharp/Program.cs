using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{   private static void FileRead(string filename)
    {
        string path = @"D:\test\" + filename;
        FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
        StreamReader sr = new StreamReader(file);
        string readText = sr.ReadToEnd();
        sr.Close();
        file.Close();
        Console.WriteLine(readText);
    }
    static void Main()
    {
        Console.WriteLine("읽어올 파일 이름을 입력해 주세요.");
        string filename = Console.ReadLine();
        FileRead(filename);
    }
}
