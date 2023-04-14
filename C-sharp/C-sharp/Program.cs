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
            int num;
            string strnum = "456";
            num = int.Parse(strnum);
            Console.WriteLine("변환한 숫자: {0}", num);
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("입력한 숫자: {0}", num);
        }
    }
}
