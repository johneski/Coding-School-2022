using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    internal class ToPower : MathOperation
    {
        public ToPower()
        {

        }

        public override decimal Execute(decimal first, decimal second)
        {
            return (decimal) Math.Pow(Convert.ToDouble(first), Convert.ToDouble(second));
        }
    }
}
