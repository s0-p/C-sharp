using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DayCollection
{
    #region Constants and Fields
    private string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
    #endregion
    #region Public Properties
    private int GetDay(string testDay)
    {
        for (int i = 0; i < days.Length; i++)
        {
            if (days[i] == testDay)
            {
                return i;
            }
        }
        throw new ArgumentOutOfRangeException(testDay, "testDay must be in the form \"Sun\", \"Mon\", etc");
    }
    public int this[string day]     //indexor
    {
        get
        {
            return GetDay(day);
        }
    }
    #endregion
}
namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DayCollection week = new DayCollection();
            Console.WriteLine(week["Fri"]);

            //ArgumentOutOfRangeException
            Console.WriteLine(week["Made-up Day"]);
        }
    }
}
