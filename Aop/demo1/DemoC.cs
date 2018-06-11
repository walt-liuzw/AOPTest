using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aop.demo1
{
    public class DemoC : IDemo
    {
        IDemo demo = new Demo();

        public void Working()
        {
            System.Console.WriteLine("工作开始");
            demo.Working();
            System.Console.WriteLine("工作完成");
        }
    }
}
