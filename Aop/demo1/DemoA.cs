using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aop.demo1
{
    public class DemoA : IDemo
    {
        public void Working()
        {
            System.Console.WriteLine("工作开始");

            System.Console.WriteLine("工作中");

            System.Console.WriteLine("工作完成");


        }
    }
}
