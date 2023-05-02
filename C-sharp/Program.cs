using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{   
    private static void FileCreate(string fileName)
    {
        string path = @"D:\test\" + fileName;
        FileInfo fileInfo = new FileInfo(path);

        if (!fileInfo.Exists)
        {
            var file = fileInfo.Open(FileMode.Create, FileAccess.ReadWrite);
            file.Close();
        }
        else
        {
            Console.WriteLine("파일이 이미 있습니다.");
        }
    }
    
    static void Main()
    {
        Console.Write("생성할 파일 이름을 입력해주세요: ");
        string fileName = Console.ReadLine();
        FileCreate(fileName);
    }
    
}
