using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;   //object형

namespace C_sharp
{
    class Program
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            if (!ht.ContainsKey("오렌지"))
            {
                ht.Add("오렌지", "Orange");
            }
            if (!ht.ContainsKey("바나나"))
            {
                ht.Add("바나나", "Banana");
            }
            if (!ht.ContainsKey("사과"))
            {
                ht.Add("사과", "Apple");
            }
            foreach (string s in ht.Keys)
            {
                Console.WriteLine(s);
                Console.WriteLine(ht[s]);
            }
            Console.WriteLine(ht["오렌지"]);
            Console.WriteLine(ht["바나나"]);
            Console.WriteLine(ht["사과"]);
        }
    }
}
