using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace AOP.UnityProxys
{
    public abstract class BaseCallHandler : ICallHandler
    {
        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            OnEntry(input);
            var result = getNext()(input, getNext);
            if (result.Exception != null)
            {
                OnException(result);
            }
            else
            {
                OnSuccess(result);
            }
            OnExit(result);    
            return result;
        }

        public int Order
        {
            get;
            set;
        }

        public virtual void OnEntry(IMethodInvocation input)
        {

        }

        public virtual void OnException(IMethodReturn methodReturn)
        {

        }

        public virtual void OnSuccess(IMethodReturn methodReturn)
        {

        }

        public virtual void OnExit(IMethodReturn methodReturn)
        {

        }
    }
}
