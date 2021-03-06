using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Validator
    {
        public Validator()
        {

        }

        public string Validate(string expression, char c)
        {
            if (!(char.IsDigit(c)) && string.IsNullOrEmpty(expression))
                return "";
            
            if (c == ',')
            {
                string[] values = new Calculations.Parser().SeparateValues(expression);
                if (values[values.Length - 1].Contains(c)) return expression;
                else return ValidateEntry(expression, c);
            }


            if(c == '@')
            {
                decimal[] entries = new Parser().ParseDecimals(expression);
                decimal result = new Calculator().Execute(entries, '@');
                return result.ToString();
            }

            if (c == '=')
            {
                string result = Validate(expression, FindSymbols(expression)[0]);
                return result.Substring(0, result.Length-1);
            }
                


            if (char.IsDigit(c) || !(NumberOfSymbols(expression) > 0))
                return expression + c;

            if(!(LastIsSymbol(expression)))
            {
                decimal[] entries = new Parser().ParseDecimals(expression);
                decimal result = new Calculator().Execute(entries, FindSymbols(expression)[0]);
                return result.ToString() + c;
            }

            return ValidateEntry(expression, c);
                
                        

        }

        public string ValidateEntry(string expression, char entry)
        {
            if (LastIsSymbol(expression))
            {
                return expression.Replace(expression[expression.Length - 1], entry);
            }

            return expression + entry;
        }

        public int NumberOfSymbols(string expression)
        {
            int numOfSymbols = 0;

            foreach (char c in expression)
            {
                if (!(char.IsDigit(c)))
                    numOfSymbols++;
            }

            return numOfSymbols;
        }

        public bool LastIsSymbol(string expression)
        {
            if(string.IsNullOrEmpty(expression)) 
                return false;

            if (!(char.IsDigit(expression[expression.Length - 1])))
                return true;

            return false;
        }

        public char[] FindSymbols(string expression)
        {
            char[] array = new char[expression.Length];
            int index = 0;

            foreach(char c in expression)
            {
                if (!(char.IsDigit(c)) && c != ',')
                {
                    array[index] = c;
                    index++;
                } 
                    
            }
            if (array.Count(c => c != '\0') == 0)
                return new char[] { '\0' };

            return array;
        }
    }
}
