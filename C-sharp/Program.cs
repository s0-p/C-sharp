using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{ 
    static void Main()
    {
        var temp = new { age = 11, name = "민수" };
        Console.WriteLine("이름 : {0}, 나이 : {1}", temp.name, temp.age);
        var tempArray = new
        {
            Int = new int[] { 100, 200, 300, 400 },
            Float = new float[] { 0.5f, 1.5f, 2.5f }
        };
        for (int i = 0; i < tempArray.Int.Length; i++)
        {
            Console.WriteLine("tempArray.Int[{0}] : {1}", i, tempArray.Int[i]);
        }
        for (int i = 0; i < tempArray.Float.Length; i++)
        {
            Console.WriteLine("tempArray.Float[{0}] : {1}", i, tempArray.Float[i]);
        }
    }
    
}
