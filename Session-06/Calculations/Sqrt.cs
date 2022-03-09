using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    internal class Sqrt
    {
        public Sqrt()
        {

        }

        public decimal Execute(decimal value)
        {
            return (decimal) Math.Sqrt(Convert.ToDouble(value));
        }
    }
}
