using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TempRecord
{
    private float[] temps = new float[10] {56.1F, 56.2F, 56.3F, 56.4F, 56.5F,
                                    56.6F, 56.7F, 56.8F, 56.9F, 57F};
    public int Length { get { return temps.Length; } }
    public float this[int index]
    {
        get 
        {
            return temps[index];
        }

        set 
        {
            temps[index] = value;
        }
    }


}

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TempRecord tempRecord = new TempRecord();
            tempRecord[3] = 58.3F;
            tempRecord[5] = 60.1F;
            for (int i = 0; i < tempRecord.Length; i++)
            {
                Console.WriteLine("tempRecord[{0}] = {1}", i, tempRecord[i]);
            }
        }
    }
}
