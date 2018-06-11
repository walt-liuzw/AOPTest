using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostSharp.Aspects;

namespace AOP.PostSharpProxys
{
    [Serializable]
    public class LogAttribute : OnMethodBoundaryAspect
    {
        public LogAttribute()
        {

        }

        /// <summary>
        /// 拦截方法入口
        /// </summary>
        /// <param name="args"></param>
        public override void OnEntry(MethodExecutionArgs args)
        {
            System.Console.WriteLine("工作开始");
            base.OnEntry(args);

            //Console.WriteLine("Start....");
            //Console.WriteLine("TypeName:{0}", args.Instance.GetType().FullName);
            //Console.WriteLine("Method:" + args.Method.Name.ToString());
            //Console.Write("\t");
            //for (int i = 0; i < args.Arguments.Count; i++)
            //    Console.Write("The Args Is:{0},", args.Arguments[i]);
            //Console.WriteLine("");

        }

        /// <summary>
        /// 拦截异常
        /// </summary>
        /// <param name="args"></param>
        public override void OnException(MethodExecutionArgs args)
        {
            base.OnException(args);
            Console.WriteLine("\tThe Exception Message is:{0}", args.Exception.Message);

        }

        /// <summary>
        /// 拦截成功
        /// </summary>
        /// <param name="args"></param>
        public override void OnSuccess(MethodExecutionArgs args)
        {
            base.OnSuccess(args);

            //Console.WriteLine("\tThe Result is:{0}", args.ReturnValue);


        }

        /// <summary>
        /// 拦截退出
        /// </summary>
        /// <param name="args"></param>
        public override void OnExit(MethodExecutionArgs args)
        {
            System.Console.WriteLine("工作完成");
            base.OnExit(args);
        }
    }
}
