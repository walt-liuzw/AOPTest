using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aop.UnityMarshalByRefObject
{
    public class Calculator : MarshalByRefObject
    {  
        public int Perform(int a, int b)
        {
            System.Console.WriteLine("工作中 MarshalByRefObject");
            return a + b;
        }

    }
}
