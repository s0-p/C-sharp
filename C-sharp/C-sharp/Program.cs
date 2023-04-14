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
            int num = 0;
            bool isTry = false;
            do
            {
                isTry = false;
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    isTry = true;
                }
            } while (isTry);

            
            Console.WriteLine(num);
        }
    }
}
