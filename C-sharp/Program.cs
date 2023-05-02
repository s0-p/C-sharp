using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    static void CreateDirectory()
    {
        string path = @"D:\test\TestDirectory";
        try
        {
            DirectoryInfo dinfo = new DirectoryInfo(path);
            dinfo.Create();
            Console.WriteLine("폴더 생성 완료");
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    static void Main()
    {
        CreateDirectory();
    }
    
}
