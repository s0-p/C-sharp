using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    static void GetFiles()
    {
        string path = @"D:\test\TestDirectory";
        try
        {
            DirectoryInfo dinfo = new DirectoryInfo(path);
            if (dinfo.Exists)
            {
                FileInfo[] files = dinfo.GetFiles("*.txt", SearchOption.TopDirectoryOnly);
                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine(files[i].ToString());
                }
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    static void Main()
    {
        GetFiles();
    }
    
}
