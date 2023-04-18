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
            Console.WriteLine("어느 것으로 바꾸시겠습니까?");
            Console.WriteLine("1.℃ -> ℉");
            Console.WriteLine("2.℉ -> ℃");
            string select = Console.ReadLine();
            int C, F;
            switch (select)
            {
                case "1":
                    Console.Write("℃를 입력해주세요: ");
                    C = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} ℃ -> {1} ℉", C, C * 9 / 5 + 32);
                    break;
                case "2":
                    Console.Write("℉를 입력해주세요: ");
                    F = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} ℉ -> {1} ℃", F, (F - 32) * 5 / 9);
                    break;
                default:
                    break;
            }
        }
    }
}
