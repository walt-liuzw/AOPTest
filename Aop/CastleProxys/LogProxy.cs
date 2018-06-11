using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;

namespace AOP.CastleProxys
{
    public class LogProxy : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            OnEntry(invocation);
            invocation.Proceed();
            OnSuccess(invocation);
        }

        public void OnEntry(IInvocation invocation)
        {
            System.Console.WriteLine("工作开始");
            //Console.WriteLine("LogProxy: OnEntry");
            //Console.WriteLine("Start....");
            //Console.WriteLine("TypeName:{0}", invocation.TargetType.FullName);
            //Console.WriteLine("Method:" + invocation.Method.Name.ToString());
            //Console.Write("\t");
            //for (int i = 0; i < invocation.Arguments.Length; i++)
            //    Console.Write("The Args Is:{0},", invocation.Arguments[i]);
            //Console.WriteLine("");
        }

        public void OnSuccess(IInvocation invocation)
        {
            System.Console.WriteLine("工作完成");
            //Console.WriteLine("LogProxy: OnSuccess");
            //Console.WriteLine("\tThe Result is:{0}", invocation.ReturnValue);
        }




    }
}
