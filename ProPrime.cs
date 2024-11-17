using Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Operation;

 class ProPrime:Calculator
{
      public override bool IsTrue(uint  number)
      {
         Console.WriteLine("pro prime");
          bool Check = true;
          for (int i = 2; i < Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                Check = false;
            }
        }return Check;
      }
}
