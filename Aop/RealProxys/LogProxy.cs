using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Security.Permissions;
using System.Text;

namespace Aop.RealProxys
{
    public class LogProxy : RealProxy
    {
        Object _obj;
        [PermissionSet(SecurityAction.LinkDemand)]
        public LogProxy(Object obj, Type classToProxy) : base(classToProxy)
        {
            _obj = obj;
        }

        public override IMessage Invoke(IMessage msg)
        {
            IMethodCallMessage call = (IMethodCallMessage)msg;
            //方法开始

            IMethodReturnMessage back = null;
            OnEntry(call);
            try
            {
                object returnValue = call.MethodBase.Invoke(_obj, call.Args);
                back = new ReturnMessage(returnValue, call.Args, call.ArgCount, call.LogicalCallContext, call);
                OnSuccess(back);
            }
            catch (Exception ex)
            {
                back = new ReturnMessage(ex, call);
                OnException(back);
            }
            finally
            {
                OnExit(back);
            }
            return back;
        }


        public void OnEntry(IMethodCallMessage call)
        {
            Console.WriteLine("工作开始");
            //Console.WriteLine("Start....");
            //Console.WriteLine("TypeName:{0}", call.TypeName);
            //Console.WriteLine("Method:" + call.MethodName.ToString());
            //Console.Write("\t");
            //for (int i = 0; i < call.Args.Length; i++)
            //    Console.Write("The Args Is:{0},", call.Args[i]);
            //Console.Write("\r\n");
            //Console.WriteLine("===========================================================");
        }

        public void OnException(IMethodReturnMessage methodReturn)
        {
            Console.WriteLine("OnException ==== The Exception Message is:{0}", methodReturn.Exception.Message);
            Console.WriteLine("===========================================================");
        }

        public void OnSuccess(IMethodReturnMessage methodReturn)
        {
            Console.WriteLine("工作完成");
            //Console.WriteLine("OnSuccess ==== The Result is:{0}", methodReturn.ReturnValue);
            //Console.WriteLine("===========================================================");
        }

        public void OnExit(IMethodReturnMessage methodReturn)
        {
            //Console.WriteLine("工作后");
            //Console.WriteLine("OnExit ==== The Result is:{0}", methodReturn.ReturnValue);
            //Console.WriteLine("===========================================================");
        }
    }
}
