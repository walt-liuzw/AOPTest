using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOP.CastleProxys
{
    public interface Calculator
    {
        int Perform(int a, int b);
        //public virtual int Perform(int a, int b)
        //{
        //    Console.WriteLine("Perform!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        //    return -1;
        //}
    }

    public class AddCalculator : Calculator
    {
        public int Perform(int a, int b)
        {
            System.Console.WriteLine("工作中 CastleProxys");
            return a + b;

        }

    }
    public class SubCalculator : Calculator
    {
        public int Perform(int a, int b)
        {
            System.Console.WriteLine("工作中 CastleProxys");
            return a - b;
        }

    }
}
