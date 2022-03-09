using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    internal class Multiplication : MathOperation
    {
        public Multiplication()
        {

        }

        public override decimal Execute(decimal first, decimal second)
        {
            return first * second;
        }
    }
}
