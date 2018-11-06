using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace LogTest
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            //LogManager.GetLogger(typeof())
            LT test = new LT();
            test.OutputLog();
            LogTestDLL.Class1 class1 = new LogTestDLL.Class1();
            class1.Test();
            //Console.WriteLine("(\\S+)[ \\t]+(\\S+)(?:(?:[ \\t]+(?!RETURN|TIMEOUT|WAIT)((?:\"[^\"]+\")|[^\"\\s]+))+)(?:[ \\t]+RETURN(?:[ \\t]+(?!TIMEOUT|WAIT)(\\S+))+)?(?:[ \\t]+TIMEOUT(?:[ \\t]+(\\S+)))?([ \\t]+WAIT)?)");
            Console.Read();
            log4net.Appender.FileAppender fileAppender = new log4net.Appender.FileAppender();
            
        }
    }

    public class LT
    {
        public void OutputLog()
        {
             ILog logger = LogManager.GetLogger(typeof(LT));
            logger.Info("this is the helloworld.");
        }
    }
}
