using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    internal class Calculator
    {
        public Calculator()
        {

        }

        public decimal Execute(decimal[] entries,char oper )
        {
            switch (oper)
            {
                case '*':
                    return entries[0] * entries[1];
                case '/':
                    return entries[0] / entries[1];
                case '+':
                    return entries[0] + entries[1];
                case '-':
                    return entries[0] - entries[1];
                case '^':
                    return (decimal) Math.Pow(Convert.ToDouble(entries[0]),Convert.ToDouble(entries[1]));
                default:
                    throw new NotImplementedException("The operator is not supported.");
            }





        }
    }
}
