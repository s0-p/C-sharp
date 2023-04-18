using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TempConverter
{
    public static float CtoF(string tempC)
    {
        return float.Parse(tempC) * 9 / 5 + 32;
    }
    public static float FtoC(string tempF)
    {
        return (float.Parse(tempF) - 32) * 5 / 9;
    }
}

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("온도를 어떻게 바꿀지 선택하십시오.");
            Console.WriteLine("1. 섭씨 -> 화씨");
            Console.WriteLine("2. 화씨 -> 섭씨");
            string select = Console.ReadLine();
            string temp;

            switch (select)
            {
                case "1":
                    Console.Write("섭씨온도를 입력해주세요 : ");
                    temp = Console.ReadLine();
                    Console.WriteLine("{0}℃ -> {1}℉", temp, TempConverter.CtoF(temp));
                    break;
                case "2":
                    Console.Write("화씨온도를 입력해주세요 : ");
                    temp = Console.ReadLine();
                    Console.WriteLine("{0}℉ -> {1}℃", temp, TempConverter.CtoF(temp));
                    break;
                default:
                    break;
            }

        }
    }
}
