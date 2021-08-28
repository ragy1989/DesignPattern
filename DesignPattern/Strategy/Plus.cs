using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class Plus : ICalculate
    {
        public int Calculate(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
