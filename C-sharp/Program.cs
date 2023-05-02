using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    private static void FileSave(string fileName, string text)
    {
        string path = string.Format(@"D:\test\{0}", fileName);
        FileInfo file = new FileInfo(path);
        if (file.Exists)
        {
            Console.WriteLine("같은 파일이 존재합니다. 덮어 씌우시겠습까? (yes, no) ");
            string result = Console.ReadLine();
            if (result == "yes")
            {
                StreamWriter writer = file.CreateText();
                writer.WriteLine(text);
                writer.Close();
            }
            else
            {
                int count = 0;
                FileInfo tmpFile = null;
                do
                {
                    path = string.Format(@"D:\test\사본{0}_{1}", count, fileName);
                    tmpFile = new FileInfo(path);
                    count++;
                } while (tmpFile.Exists);
                StreamWriter writer = tmpFile.CreateText();
                writer.WriteLine(text);
                writer.Close();
            }
        }
        else
        {
            StreamWriter writer = file.CreateText();
            writer.WriteLine(text);
            writer.Close();
        }
    }
    
    static void Main()
    {
        Console.Write("파일 이름을 입력해주세요: ");
        string path = Console.ReadLine();
        FileSave(path, "hello world");
    }
    
}
