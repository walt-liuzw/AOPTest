using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aop.demo1
{
    public class DemoB : Demo, IDemo
    {
        public void Working()
        {
            System.Console.WriteLine("工作开始");
            base.Working();
            System.Console.WriteLine("工作完成");
        }
    }
}
