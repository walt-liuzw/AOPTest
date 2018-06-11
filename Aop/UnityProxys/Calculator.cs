using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOP.UnityProxys
{
    
    public interface Calculator 
    {
        int Perform(int a, int b);
    }


    //给出2个实现，加法和减法计算
    
    public class AddCalculator :  Calculator
    {
        [Log]
        public int Perform(int a, int b)
        {
            System.Console.WriteLine("工作中 Unity");
            return a + b;
        }

    }
    public class SubCalculator : Calculator
    {
        [Log]
        public int Perform(int a, int b)
        {
            System.Console.WriteLine("工作中 Unity");
            return a - b;
        }

    }
}
