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
                    return new Calculations.Multiplication().Execute(entries[0], entries[1]);
                case '/':
                    return new Calculations.Division().Execute(entries[0], entries[1]);
                case '+':
                    return new Calculations.Addition().Execute(entries[0], entries[1]);
                case '-':
                    return new Calculations.Substraction().Execute(entries[0], entries[1]);
                case '^':
                    return new Calculations.ToPower().Execute(entries[0], entries[1]);
                case '@':
                    return new Calculations.Sqrt().Execute(entries[0]);
                default:
                    return entries[0];
            }





        }
    }
}
