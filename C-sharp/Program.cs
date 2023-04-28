using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{   
    public static byte[] WriteStringBytes(string str, FileStream fs)
    {
        byte[] byteStr = new UTF8Encoding(true).GetBytes(str);
        fs.Write(byteStr, 0, byteStr.Length);
        return byteStr;
    }
    private static void FileRead(string fileName)
    {
        string path = @"D:\test\" + fileName;
        string outStr = "안녕하세요. 박소영입니다.";
        byte[] readByte = new byte[1024];
        FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        WriteStringBytes(outStr, file);
        file.Seek(0, SeekOrigin.Begin);
        UTF8Encoding utf8 = new UTF8Encoding(true);
        file.Read(readByte, 0, readByte.Length);
        Console.WriteLine(utf8.GetString(readByte));
        file.Close();
    }
    static void Main()
    {
        Console.Write("파일 이름을 입력해주세요 : ");
        string fileName = Console.ReadLine();
        FileRead(fileName);
    }
}
