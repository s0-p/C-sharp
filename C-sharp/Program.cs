using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace C_sharp
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> genDic = new Dictionary<string, string>();
            genDic.Add("txt", "notepad.exe");
            genDic.Add("bmp", "paint.exe");
            genDic.Add("mp3", "wmplayer.exe");
            Console.WriteLine("[Dictionary]");
            foreach (KeyValuePair<string, string> kvp in genDic)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
