using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
   public static class Strategy
    {
        public static void execute()
        {
            CalculateClient calculateClient = new CalculateClient(new Minus());

            Console.WriteLine(calculateClient.calculate(2, 1));
            Console.Read();

        }
    }
}
