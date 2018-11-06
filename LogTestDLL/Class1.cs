using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace LogTestDLL
{
    public class Class1
    {
        public void Test()
        {
            LogManager.GetLogger(typeof(Class1)).Info("this is the logtestDLL");
        }
    }
}
