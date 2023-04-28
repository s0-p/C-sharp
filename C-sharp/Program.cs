using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Student
{
    public int num { get; set; }
    public string name { get; set; }
}

class Program
{   
    private static void FileCreate(string fileName)
    {
        string path = @"D:\test\" + fileName;
        Student me = new Student() { num = 1, name = "소영" };
        FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(fs, me);   //직렬화
        fs.Close();
        fs = new FileStream(path, FileMode.Open, FileAccess.Read);
        var result = (Student)bf.Deserialize(fs);  //역직렬화
        fs.Close();
        Console.WriteLine("번호 = {0}, 이름 = {1}", result.num, result.name);
    }
    static void Main()
    {
        Console.Write("생성할 파일 이름을 입력해주세요 : ");
        string fileName = Console.ReadLine();
        FileCreate(fileName);
    }
    
}
