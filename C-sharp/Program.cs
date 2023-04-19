using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{   
    class PocketMon
    {
        private string kind;
        private string name;
        public PocketMon(string kind, string name)
        {
            this.kind = kind;
            this.name = name;
        }
        public void PrintPocketMon()
        {
            Console.WriteLine("종류 : {0} / 이름 : {1}", kind, name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PocketMon[] pocketMons = new PocketMon[4]; // 배열 생성
            
            //각각의 객체 생성 필요
            pocketMons[0] = new PocketMon("노말", "잠만보");
            pocketMons[1] = new PocketMon("불꽃", "파이리");
            pocketMons[2] = new PocketMon("전기", "피카츄");
            pocketMons[3] = new PocketMon("물", "꼬부기");

            foreach (PocketMon po in pocketMons)
            {
                po.PrintPocketMon();
            }
        }
    }
}
