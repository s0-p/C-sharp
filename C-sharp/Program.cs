using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    private static void FileRename ()
    {
        FileInfo file = new FileInfo(@"D:\test\test.txt");

        if (file.Exists)
        {
            file.MoveTo(@"D:\test\temp.txt");
        }
        
    }
    
    static void Main()
    {
        FileRename();
    }
    
}
