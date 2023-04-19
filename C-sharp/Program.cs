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
            int[] orgArr = new int[] { 10, 20, 30, 40 };
            int[] copyArr = (int[])orgArr.Clone();
            
            for (int i = 0; i < copyArr.Length; i++)
            {
                Console.WriteLine("copyArr[{0}] = {1}", i, copyArr[i]);
            }
        }
    }
}
