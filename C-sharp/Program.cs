using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    static bool checkFiles(string s)
    {
        string[] exts = new[] { ".bmp", ".txt", ".gif" };
        return exts.Contains(Path.GetExtension(s), StringComparer.OrdinalIgnoreCase);   // 확장자, 대소문자 구분x
    }
    static void GetFiles()
    {
        string path = @"D:\test\TestDirectory";
        try
        {
            DirectoryInfo dinfo = new DirectoryInfo(path);
            if (dinfo.Exists)
            {
                FileInfo[] files = dinfo.GetFiles("*.*", SearchOption.TopDirectoryOnly);
                string[] fileStr = new string[files.Length];
                for (int i = 0; i < files.Length; i++)
                {
                    fileStr[i] = files[i].ToString();
                }
                string[] result = fileStr.Where(checkFiles).ToArray();
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine(result[i]);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    static void Main()
    {
        GetFiles();
    }
    
}
