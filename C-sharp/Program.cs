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
            string[][] jagged_str = new string[3][]
            {
                new string[3] { "SBS", "Game", "Academy"},
                new string[2] { "강남역", "12번출구로" },
                new string[] { "나오시면", "금방", "찾을실", "수", "있습니다.", "!!" }
            };
            for (int i = 0; i < jagged_str.Length; i++)
            {
                for (int j = 0; j < jagged_str[i].Length; j++)
                {
                    Console.Write(jagged_str[i][j] + " ");
                }
                Console.WriteLine();
            }
            //foreach (string[] jagged in jagged_str)
            //{
            //    foreach (string str_element in jagged)
            //    {
            //        Console.Write(str_element + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
