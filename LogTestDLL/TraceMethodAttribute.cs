using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp;
using PostSharp.Aspects;
using PostSharp.Aspects.Configuration;
using PostSharp.Extensibility;
using log4net;
using System.Reflection;

namespace LogTestDLL
{
    [Serializable]
    public class TraceMethodAttribute : OnMethodBoundaryAspect
    {
        // Create a logger for use in this class, called only once
        private static readonly log4net.ILog _logger;

        private string _methodName;

        //// These fields are initialized at runtime. They do not need to be serialized.
        //[NonSerialized]
        //private int _hashCode;

        static TraceMethodAttribute()
        {
            if (!PostSharpEnvironment.IsPostSharpRunning)
            {
                _logger = LogManager.GetLogger(typeof(TraceMethodAttribute));
            }
        }


        // Default constructor, invoked at build time.
        public TraceMethodAttribute()
        {
            // Do nothing
        }

        // Invoked only once at runtime from the static constructor of type declaring the target method.
        public override void CompileTimeInitialize(MethodBase method, AspectInfo aspectInfo)
        {
            _methodName = method.DeclaringType.Name + "." + method.Name;
        }


        // Invoked only once at runtime from the static constructor of type declaring the target method.
        public override void RuntimeInitialize(MethodBase method)
        {
            //_hashCode = this.GetHashCode();
        }

        // Invoked at runtime before that target method is invoked.
        public override void OnEntry(MethodExecutionArgs args)
        {
            _logger.DebugFormat(">>> Entry \t{0}", _methodName);
        }

        // Invoked at runtime after the target method is invoked (in a finally block).
        public override void OnExit(MethodExecutionArgs args)
        {
            _logger.DebugFormat("<<< Exit \t{0}", _methodName);
        }

        // Invoked at runtime when there is unhandled exception from the target method
        public override void OnException(MethodExecutionArgs args)
        {
            string expMsg = string.Format("!!! Exception {0} {1}", _methodName, args.Exception.Message);
            _logger.ErrorFormat(expMsg, args.Exception);
        }

        // Invoked at runtime when await starts in the target method
        public override void OnYield(MethodExecutionArgs args)
        {
            _logger.DebugFormat("--- OnYield {0}", _methodName);
        }

        // Invoked at runtime when await resumed in the target method
        public override void OnResume(MethodExecutionArgs args)
        {
            _logger.DebugFormat("--- OnResume {0}", _methodName);
        }
    }
}
