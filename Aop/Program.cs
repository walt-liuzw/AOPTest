using Aop.demo1;
using Aop.RealProxys;
using Castle.DynamicProxy;
using Microsoft.Practices.EnterpriseLibrary.PolicyInjection;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity.InterceptionExtension;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;

namespace Aop
{
    class Program
    {
        static void Main(string[] args)
        {
            IDemo demo = null;

            //demo = new Demo();
            //demo.Working();


            //demo = new DemoA();
            //demo.Working();

            //demo = new DemoB();
            //demo.Working();

            //demo = new DemoC();
            //demo.Working();


            //Remoting demoC
            //LogProxy proxy = new LogProxy(new AddCalculator(), typeof(Calculator));
            //Calculator tp = (Calculator)proxy.GetTransparentProxy();
            //int sum = tp.Perform(1, 2);
            //System.Console.WriteLine(sum);

            //Unity 继承 接口
            //AOP.UnityProxys.Calculator unity = PolicyInjection.Wrap<AOP.UnityProxys.Calculator>(new AOP.UnityProxys.AddCalculator());
            //unity.Perform(8, 8);

            //Unity 继承 MarshalByRefObject
            UnityConfigurationSection unitySection = (UnityConfigurationSection)ConfigurationManager.GetSection("unityInterception");
            IUnityContainer container = new UnityContainer();
            unitySection.Configure(container, "MyInterception");
            var obj = container.Resolve<Aop.UnityMarshalByRefObject.Calculator>();
            obj.Perform(1, 4);


            //Castle.DynamicProxy demoB
            //CastleDynProxy2.dll
            //Castle.DynamicProxy.IInterceptor handler2 = new AOP.CastleProxys.LogProxy2();
            //ProxyGenerator proxyGenerator = new ProxyGenerator(new PersistentProxyBuilder());
            //Castle.DynamicProxy.IInterceptor handler = new AOP.CastleProxys.LogProxy();
            //AOP.CastleProxys.Calculator castle = (AOP.CastleProxys.Calculator)proxyGenerator.CreateClassProxy(typeof(AOP.CastleProxys.AddCalculator), new Type[] { typeof(AOP.CastleProxys.Calculator) }, handler);
            //((Castle.DynamicProxy.PersistentProxyBuilder)(proxyGenerator.ProxyBuilder)).SaveAssembly();  //保存生成代码到DLL
            //castle.Perform(1, 2);


            //PostSharp  demoA
            //AOP.PostSharpProxys.Calculator c5 = new AOP.PostSharpProxys.AddCalculator();
            //c5.Perform(6, 6);

          
            

            System.Console.ReadKey();
        }
    }
}
