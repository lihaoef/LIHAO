using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PostSharp;
using PostSharp.Aspects;
using PostSharp.Aspects.Configuration;
using PostSharp.Extensibility;
using log4net;

namespace LogTest
{
    //public class MA : MethodInterceptionAspect
    //{
    //    override  
    //}

    [Serializable]
    public class Aspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            base.OnEntry(args);
            Console.WriteLine("Aspect Entry :" + args.Method.Name);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            base.OnExit(args);
            Console.WriteLine("Aspect Exit :" + args.Method.Name);
        }
    }

    //[Serializable]
    //public class Aspect1 : OnMethodBoundaryAspect
    //{
    //    public override void OnEntry(MethodExecutionArgs args)
    //    {
    //        base.OnEntry(args);
    //        Console.WriteLine("Aspect Entry :" + args.Method.Name);
    //    }

    //    public override void OnExit(MethodExecutionArgs args)
    //    {
    //        base.OnExit(args);
    //        Console.WriteLine("Aspect Exit :" + args.Method.Name);
    //    }
    //}
    //[Serializable]
    //public class Aspect2 : OnMethodBoundaryAspect
    //{
    //    public override void OnEntry(MethodExecutionArgs args)
    //    {
    //        base.OnEntry(args);
    //        Console.WriteLine("Aspect Entry :" + args.Method.Name);
    //    }

    //    public override void OnExit(MethodExecutionArgs args)
    //    {
    //        base.OnExit(args);
    //        Console.WriteLine("Aspect Exit :" + args.Method.Name);
    //    }
    //}
    //[Serializable]
    //public class Aspect3 : OnMethodBoundaryAspect
    //{
    //    public override void OnEntry(MethodExecutionArgs args)
    //    {
    //        base.OnEntry(args);
    //        Console.WriteLine("Aspect Entry :" + args.Method.Name);
    //    }

    //    public override void OnExit(MethodExecutionArgs args)
    //    {
    //        base.OnExit(args);
    //        Console.WriteLine("Aspect Exit :" + args.Method.Name);
    //    }
    //}
    //[Serializable]
    //public class Aspect4 : OnMethodBoundaryAspect
    //{
    //    public override void OnEntry(MethodExecutionArgs args)
    //    {
    //        base.OnEntry(args);
    //        Console.WriteLine("Aspect Entry :" + args.Method.Name);
    //    }

    //    public override void OnExit(MethodExecutionArgs args)
    //    {
    //        base.OnExit(args);
    //        Console.WriteLine("Aspect Exit :" + args.Method.Name);
    //    }
    //}
    //[Serializable]
    //public class Aspect5 : OnMethodBoundaryAspect
    //{
    //    public override void OnEntry(MethodExecutionArgs args)
    //    {
    //        base.OnEntry(args);
    //        Console.WriteLine("Aspect Entry :" + args.Method.Name);
    //    }

    //    public override void OnExit(MethodExecutionArgs args)
    //    {
    //        base.OnExit(args);
    //        Console.WriteLine("Aspect Exit :" + args.Method.Name);
    //    }
    //}
    //[Serializable]
    //public class Aspect6 : OnMethodBoundaryAspect
    //{
    //    public override void OnEntry(MethodExecutionArgs args)
    //    {
    //        base.OnEntry(args);
    //        Console.WriteLine("Aspect Entry :" + args.Method.Name);
    //    }

    //    public override void OnExit(MethodExecutionArgs args)
    //    {
    //        base.OnExit(args);
    //        Console.WriteLine("Aspect Exit :" + args.Method.Name);
    //    }
    //}
    //[Serializable]
    //public class Aspect7 : OnMethodBoundaryAspect
    //{
    //    public override void OnEntry(MethodExecutionArgs args)
    //    {
    //        base.OnEntry(args);
    //        Console.WriteLine("Aspect Entry :" + args.Method.Name);
    //    }

    //    public override void OnExit(MethodExecutionArgs args)
    //    {
    //        base.OnExit(args);
    //        Console.WriteLine("Aspect Exit :" + args.Method.Name);
    //    }
    //}
    //[Serializable]
    //public class Aspect8 : OnMethodBoundaryAspect
    //{
    //    public override void OnEntry(MethodExecutionArgs args)
    //    {
    //        base.OnEntry(args);
    //        Console.WriteLine("Aspect Entry :" + args.Method.Name);
    //    }

    //    public override void OnExit(MethodExecutionArgs args)
    //    {
    //        base.OnExit(args);
    //        Console.WriteLine("Aspect Exit :" + args.Method.Name);
    //    }
    //}
    //[Serializable]
    //public class Aspect9 : OnMethodBoundaryAspect
    //{
    //    public override void OnEntry(MethodExecutionArgs args)
    //    {
    //        base.OnEntry(args);
    //        Console.WriteLine("Aspect Entry :" + args.Method.Name);
    //    }

    //    public override void OnExit(MethodExecutionArgs args)
    //    {
    //        base.OnExit(args);
    //        Console.WriteLine("Aspect Exit :" + args.Method.Name);
    //    }
    //}
    //[Serializable]
    //public class Aspect10 : OnMethodBoundaryAspect
    //{
    //    public override void OnEntry(MethodExecutionArgs args)
    //    {
    //        base.OnEntry(args);
    //        Console.WriteLine("Aspect Entry :" + args.Method.Name);
    //    }

    //    public override void OnExit(MethodExecutionArgs args)
    //    {
    //        base.OnExit(args);
    //        Console.WriteLine("Aspect Exit :" + args.Method.Name);
    //    }
    //}


}
