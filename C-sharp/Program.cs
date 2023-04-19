using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class List<T>
{
    private T[] arr;
    public List()
    {
        arr = new T[2];
    }
    public int Length { get { return arr.Length; } }
    public void InitArray(int index, T value)
    {
        arr[index] = value;
    }
    public T GetValue(int index)
    {
        return arr[index];
    }
}    

namespace C_sharp
{   
    class Program
    {
        static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            List<float> list2 = new List<float>();
            List<string> list3 = new List<string>();
            list1.InitArray(0, 58);
            list1.InitArray(1, 30);
            list2.InitArray(0, 75.2f);
            list2.InitArray(1, 65.5f);
            list3.InitArray(0, "아무개");
            list3.InitArray(1, "홍길동");
            for (int i = 0; i < list1.Length; i++)
            {
                Print("이름: " + list3.GetValue(i));
                Print("나이: " + list1.GetValue(i));
                Print("몸무게: " + list2.GetValue(i));
                Print(" ");
            }

        }
    }
}
