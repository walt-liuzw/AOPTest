using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity.InterceptionExtension;
using Microsoft.Practices.Unity;

namespace AOP.UnityProxys
{
    public class LogAttribute : HandlerAttribute
    {
        public LogAttribute()
        {

        }

        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            return new LogCallHandler();
        }

    }
}
