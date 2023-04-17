using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string m_name;
    public static string m_schoolName;
    public string NAME { get { return m_name; } set { m_name = value; } }
    public void Intro()
    {
        Console.WriteLine("{0}에 다니는 {1}입니다.", m_schoolName, m_name);
    }
    public static void IntroMyUniv()
    {
        Console.WriteLine("우리학교는 {0}입니다.", m_schoolName);
    }
}
namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student.m_schoolName = "서울대학교";
            Student std1 = new Student();
            Student std2 = new Student();
            std1.m_name = "홍길동";
            std2.m_name = "아무개";
            std1.Intro();
            std2.Intro();
            Student.IntroMyUniv();
        }
    }
}
