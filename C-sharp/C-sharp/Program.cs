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
            char[] chArr = new char[] { 'h', 'e', 'l', 'l', 'o' };
            string str1 = new string(chArr);
            string str2 = "hello";
            string str3 = "world";
            Console.WriteLine(str1 == str2);    //True <- 주소를 갖고있지만 값 비교로 간주
            Console.WriteLine(string.ReferenceEquals(str1, str2));  //False
            Console.WriteLine(str1.CompareTo(str3));    //-1 <- str1 > str3
        }
    }
}
