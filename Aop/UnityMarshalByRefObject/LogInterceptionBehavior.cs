using Microsoft.Practices.Unity.InterceptionExtension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Aop.UnityMarshalByRefObject
{
    public class LogInterceptionBehavior : IInterceptionBehavior
    {
        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return new[] { typeof(INotifyPropertyChanged) };
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            Console.WriteLine("工作开始");
            IMethodReturn ret = getNext()(input, getNext);
            Console.WriteLine("工作完成");
            return ret;
        }

        public bool WillExecute
        {
            get { return true; }
        }
    }
}
