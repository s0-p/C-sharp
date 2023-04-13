using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";
            char[] chArr = new char[] { 'w', 'o', 'r', 'l', 'd' };
            string str2 = new string(chArr);
            string str3 = new string(chArr, 2, 3);  // "rld"
            string str4 = new string('w', 4);   //"wwww"
            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str + str2);

        }
    }
}
