using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aop.demo1
{
    public class Demo : IDemo
    {
        public void Working()
        {
            System.Console.WriteLine("工作中");
        }
    }
}
