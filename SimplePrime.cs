using System;

namespace Operation
{
    public class SimplePrime : Calculator
    {
        public override bool IsTrue(uint number)
        {
            Console.WriteLine("Simple Prime");
            bool Check = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Check = false;
                }
            }
            return Check;
        }
    }
}
