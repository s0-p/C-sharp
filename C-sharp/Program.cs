using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
class Program
{
    const string TableName = "클래스";
    static DataSet CreateDataSet()
    {
        DataSet ds = new DataSet();
        ds.Tables.Add(TableName);
        ds.Tables[TableName].Columns.Add("이름");
        ds.Tables[TableName].Columns.Add("속성");
        ds.Tables[TableName].Columns.Add("공격력");
        string[] str = new string[3];
        str[0] = "나이트";
        str[1] = "근거리";
        str[2] = "150";
        ds.Tables[TableName].Rows.Add(str);
        str[0] = "레인저";
        str[1] = "원거리";
        str[2] = "200";
        ds.Tables[TableName].Rows.Add(str);
        str[0] = "소서러";
        str[1] = "원거리";
        str[2] = "300";
        ds.Tables[TableName].Rows.Add(str);
        return ds;
    }

    static void Main()
    {
        DataSet ds = CreateDataSet();
        DataTable dt = ds.Tables[TableName];
        DataRow[] dr = dt.Select();
        for (int i = 0; i < dt.Columns.Count; i++)
        {
            Console.Write(dt.Columns[i].ToString() + "\t");
        }
        Console.WriteLine();
        for (int i = 0; i < dr.Length; i++)
        {
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                Console.Write(dr[i][j] + "\t");
            }
            Console.WriteLine();
        }
    }

}
