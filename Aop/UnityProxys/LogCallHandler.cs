using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace AOP.UnityProxys
{
    public class LogCallHandler : BaseCallHandler
    {
        public override void OnEntry(IMethodInvocation invocation)
        {
            System.Console.WriteLine("工作开始");
            base.OnEntry(invocation);
            //Console.WriteLine("Start....");
            //Console.WriteLine("TypeName:{0}", invocation.Target.GetType().FullName);
            //Console.WriteLine("Method:" + invocation.MethodBase.Name.ToString());
            //Console.Write("\t");
            //for (int i = 0; i < invocation.Arguments.Count; i++)
            //    Console.Write("The Args Is:{0},", invocation.Arguments[i]);
            //Console.WriteLine("");

        }

        public override void OnException(IMethodReturn methodReturn)
        {
            base.OnException(methodReturn);
            Console.WriteLine("\tThe Exception Message is:{0}", methodReturn.Exception.Message);
        }

        public override void OnSuccess(IMethodReturn methodReturn)
        {
            System.Console.WriteLine("工作完成");
            base.OnSuccess(methodReturn);
            //Console.WriteLine("\tThe Result is:{0}", methodReturn.ReturnValue);
        }
    }
}
