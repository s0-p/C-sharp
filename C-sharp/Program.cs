using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{   
    private static void FileCreate(string fileName)
    {
        string path = @"D:\test\" + fileName;
        FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
        BinaryWriter bw = new BinaryWriter(fs);
        bw.Write(int.MaxValue);
        bw.Write(double.MaxValue);
        bw.Write("안녕하세요. 박소영입니다.");
        fs.Close();

        fs = new FileStream(path, FileMode.Open, FileAccess.Read);
        BinaryReader br = new BinaryReader(fs);
        Console.WriteLine("File size : {0} bytes", br.BaseStream.Length);
        Console.WriteLine(br.ReadInt32());
        Console.WriteLine(br.ReadDouble());
        Console.WriteLine(br.ReadString());
        fs.Close();

    }
    static void Main()
    {
        Console.Write("생성할 파일 이름을 입력해주세요 : ");
        string fileName = Console.ReadLine();
        FileCreate(fileName);
    }
    
}
