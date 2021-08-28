using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
   public class CalculateClient
    {
        private ICalculate calculateInterface;
        public CalculateClient(ICalculate calculateInterface)
        {
            this.calculateInterface = calculateInterface;
        }

        public int calculate(int value1,int value2)
        {
            return calculateInterface.Calculate(value1, value2);
        }
    }
}
