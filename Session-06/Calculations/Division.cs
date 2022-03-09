using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    internal class Division : MathOperation
    {
        public Division()
        {

        }

        public override decimal Execute(decimal first, decimal second)
        {
            return first / second;
        }
    }
}
