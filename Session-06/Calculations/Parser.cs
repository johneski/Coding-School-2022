using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Parser
    {
        public Parser()
        {

        }

        public decimal[] ParseDecimals(string input)
        {
            string[] values = SeparateValues(input);
            decimal[] decimals = new decimal[values.Length];
            int index = 0;

            foreach(string value in values)
            {
                decimals[index] = Convert.ToDecimal(value);
                index++;
            }

            return decimals;
        }



        public string[] SeparateValues(string input)
        {
            Validator validator = new Validator();
            char[] symbols = validator.FindSymbols(input);
            int numOfSymbols = symbols.Count(s => s != '\0');

            if ( numOfSymbols == 0) return new string[] {input};

            string[]? result = new string[numOfSymbols+1];
            string[] splittedValues;

            int index = 0;

            for(int i=0;i<numOfSymbols;i++)
            {
                char c = symbols[i];

                splittedValues = input.Split(c);
                for(int j=0;j<splittedValues.Length;j++)
                {
                    result[index] = splittedValues[j];
                    index++;
                }
                input = splittedValues[splittedValues.Length-1];
            }

            return result;
        }
    }
}
