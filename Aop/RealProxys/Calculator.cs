using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aop.RealProxys
{
    public interface Calculator
    {
        int Perform(int a, int b);
    }

    public class AddCalculator : Calculator
    {
        public int Perform(int a, int b)
        {
            System.Console.WriteLine("工作中 RealProxys");
            return a + b;
        }
    }



}
