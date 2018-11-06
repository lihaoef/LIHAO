using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObj
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class DataObj : MarshalByRefObject
    {
        public static Dictionary<string, int> salary;
        public static string company;
        public static int counter;

        public static int constructerCnt = 0;

        public static void LoadData()
        {
            company = "Microsoft";
            salary = new Dictionary<string, int>();
            salary.Add("lianjx", 3);
            salary.Add("uncle", 5);
            counter = 0;
        }

        public Dictionary<string, int> GetSalary()
        {
            return DataObj.salary;
        }

        public DataObj()
        {
            DataObj.constructerCnt++;
            Console.WriteLine("Constructer...{0}", DataObj.constructerCnt);
        }

        public DateTime GetTime()
        {
            return DateTime.Now;
        }

        public byte[] TransportByte()
        {
            byte[] bs = new byte[1024 * 1024 * 8];
            byte[] b2 = BitConverter.GetBytes(DateTime.Now.Ticks);
            for (int j = 0; j < b2.Length; j++)
            {
                bs[j] = b2[j];
            }
            return bs;
        }

    }
}
