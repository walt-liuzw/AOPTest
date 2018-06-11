using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOP.PostSharpProxys
{
    public interface Calculator
    {
        int Perform(int a, int b);
    }

    
    public class AddCalculator : Calculator
    {
        [Log]
        public int Perform(int a, int b)
        {
            System.Console.WriteLine("工作中 PostSharpProxys");
            return a + b;
        }

    }

    
    public class SubCalculator : Calculator
    {
        [Log]
        public int Perform(int a, int b)
        {
            System.Console.WriteLine("工作中 PostSharpProxys");
            return a - b;
        }

    }
}
