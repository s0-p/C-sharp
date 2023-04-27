using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public int num { get; set; }
    public string name { get; set; }
}
public class StudentList
{
    public List<Student> list = new List<Student>();
    public int Count { get { return list.Count; } }
    public void Add(Student std)
    {
        list.Add(std);
    }
    public void Clear()
    {
        list.Clear();
    }
    Ascending sortAscending = new Ascending();
    Descending sortDescending = new Descending();
    public void SorAscending()
    {
        list.Sort(sortAscending);
    }
    public void SortDescending()
    {
        list.Sort(sortDescending);
    }
    class Ascending : IComparer<Student>
    {
        public int Compare(Student a, Student b)
        {
            return a.num.CompareTo(b.num);
        }
    }
    class Descending : IComparer<Student>
    {
        public int Compare(Student a, Student b)
        {
            return b.num.CompareTo(a.num);
        }
    }
}


class Program
{
    static void Main()
    {
        List<Student> tmplist = new List<Student>() { new Student() { num=1, name="소영"},
                                                      new Student() { num=2, name="수지"},
                                                      new Student() { num=3, name="설현"},
        };
        StudentList stdList = new StudentList();
        for (int i = 0; i < tmplist.Count; i++)
        {
            stdList.Add(tmplist[i]);
        }
        stdList.SortDescending();
        for (int i = 0; i < stdList.Count; i++)
        {
            Console.WriteLine("번호 : {0}, 이름 : {1}", stdList.list[i].num, stdList.list[i].name);
        }
        stdList.SorAscending();
        for (int i = 0; i < stdList.Count; i++)
        {
            Console.WriteLine("번호 : {0}, 이름 : {1}", stdList.list[i].num, stdList.list[i].name);
        }
    }
}
