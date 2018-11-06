using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Dynamic;
using System.Threading;

namespace JsonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            //string json = javaScriptSerializer.Serialize(new Test { Age = 2, Name = "lihao" });
            //dynamic d = javaScriptSerializer.Deserialize<dynamic>(json);
            //dynamic d2 = new ExpandoObject();
            //d2.Name = "abc";
            //d2.Age = 3;
            //d2.Persions = new List<Test>();
            //int m = d2.Age;
            //d2 = 3;
            //dynamic d3 = new Test { Age = 1, Name = "liaho" };
            //Console.WriteLine(d3.GetName());
            //Console.Read();
            //var n = 3 + d2;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            
            try
            {
                //Thread t = new Thread((ThreadStart)delegate
                //{
                //    throw new Exception("多线程异常");
                //});
                //t.IsBackground = true;
                //t.Start();

                

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message + Environment.NewLine + error.StackTrace);
            }
            Console.WriteLine("complete");
            Console.Read();

        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {

            Console.WriteLine("Unhandled exception happened.");
        }
    }

    [DataContract]
    public class Test
    {
        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public string Name { get; set; }

        public  string GetName()
        {
            return Name;
        }

    }
}
