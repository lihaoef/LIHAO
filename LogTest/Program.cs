using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net;
using LogTestDLL;
using PostSharp.Aspects;
using PostSharp.Extensibility;
using LogTestB;
using System.IO;

namespace LogTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //log4net.Config.XmlConfigurator.Configure();
            //LogManager.GetLogger(typeof())
            //ILog logger = LogManager.GetLogger(typeof(TraceMethodAttribute));

            System.Text.UTF8Encoding utf8 = new System.Text.UTF8Encoding(false);
            File.WriteAllText("e:\\hao2.txt", "我是李浩", UTF8Encoding.UTF8);

            DT dT = new DT();
            dT.Test();
            dT.Test2();


            LT test = new LT();
            test.OutputLog();
            LogTestDLL.Class1 class1 = new LogTestDLL.Class1();
            class1.Test();
            //Console.WriteLine("(\\S+)[ \\t]+(\\S+)(?:(?:[ \\t]+(?!RETURN|TIMEOUT|WAIT)((?:\"[^\"]+\")|[^\"\\s]+))+)(?:[ \\t]+RETURN(?:[ \\t]+(?!TIMEOUT|WAIT)(\\S+))+)?(?:[ \\t]+TIMEOUT(?:[ \\t]+(\\S+)))?([ \\t]+WAIT)?)");
            Console.Read();
            log4net.Appender.FileAppender fileAppender = new log4net.Appender.FileAppender();
            
            log4net.Appender.RollingFileAppender rollingFileAppender = new log4net.Appender.RollingFileAppender();
            
        }
    }

    public class LT
    {
        //[Aspect]
        //[Aspect1]
        //[Aspect2]
        //[Aspect3]
        //[Aspect4]
        //[Aspect5]
        //[Aspect6]
        //[Aspect7]
        //[Aspect8]
        //[Aspect9]
        //[Aspect10]
        public void OutputLog()
        {
             ILog logger = LogManager.GetLogger(typeof(LT));
            logger.Info("this is the helloworld.");
            logger.Error("test", new Exception("\this is a exception"));
            logger.Debug("this is debug");
        }
    }

    
}
