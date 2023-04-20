using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace C_sharp
{   
    class Program
    {
        static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }
        static void CopyArray<T>(T[] src, T[] dest)
        {
            src.CopyTo(dest, 0);    //index 0부터 복사
        }
        static void Main(string[] args)
        {
            int[] srcInt = new int[] { 1, 2, 3, 4, 5 };
            int[] tagInt = new int[srcInt.Length];
            string[] srcStr = new string[] { "hello", "sbs", "game", "academy" };
            string[] tagStr = new string[srcStr.Length];
            CopyArray<int>(srcInt, tagInt);
            CopyArray<string>(srcStr, tagStr);
            for (int i = 0; i < srcInt.Length; i++)
            {
                Print<int>(tagInt[i]);
            }
            for (int i = 0; i < srcStr.Length; i++)
            {
                Print<string>(tagStr[i]);
            }
        }
    }
}
