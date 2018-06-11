using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;

namespace AOP.CastleProxys
{
    public class ProxyFactory
    {
        public static T ProxyBuilder<T>()
        {
            ProxyGenerator proxyGenerator = new ProxyGenerator(new PersistentProxyBuilder());
            IInterceptor handler = new AOP.CastleProxys.LogProxy();
            IInterceptor handler2 = new AOP.CastleProxys.LogProxy2();
            T obj = (T)proxyGenerator.CreateClassProxy(typeof(T), handler, handler2);
            ((Castle.DynamicProxy.PersistentProxyBuilder)(proxyGenerator.ProxyBuilder)).SaveAssembly();
            return obj;
        }


    }
}
