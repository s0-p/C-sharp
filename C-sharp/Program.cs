using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace C_sharp
{
    class Program
    {
        static void Main()
        {
            SortedList<int, string> colorSort = new SortedList<int, string>();
            colorSort.Add(1, "Red");
            colorSort.Add(3, "Green");
            colorSort.Add(2, "Blue");
            foreach (KeyValuePair<int, string> color in colorSort)
            {
                Console.WriteLine("Key {0} Color {1}", color.Key, color.Value);
            }
            Console.WriteLine("현재 리스트 크기: {0}", colorSort.Capacity);
            colorSort.TrimExcess();
            Console.WriteLine("현재 리스트 크기: {0}, 요소의 개수: {1}", colorSort.Capacity, colorSort.Count);
            colorSort.Remove(2);
            colorSort.TrimExcess();
            Console.WriteLine("현재 리스트 크기: {0}, 요소의 개수: {1}", colorSort.Capacity, colorSort.Count);
        }
    }
}
