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
            int[] orgArr = new int[] { -1, -3, -5, -7, -9 };
            int[] copyArr = { 2, 4, 6, 8, 10 };
            
            //orgArr의 0부터 copyArr의 2부터에 3개 복사
            Array.Copy(orgArr, 0, copyArr, 2, 3);
            for (int i = 0; i < copyArr.Length; i++)
            {
                Console.WriteLine("copyArr[{0}] = {1}", i, copyArr[i]);
            }
        }
    }
}
