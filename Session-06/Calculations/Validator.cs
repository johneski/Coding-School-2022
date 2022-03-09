﻿using System;
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

            if (char.IsDigit(c) || !(NumberOfSymbols(expression) > 0))
                return expression + c;

            if(!(LastIsSymbol(expression)))
            {
                decimal[] entries = new Parser().ParseDecimals(expression);
                decimal result = new Calculator().Execute(entries, c);
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
            char[]? array = new char[expression.Length];
            int index = 0;

            foreach(char c in expression)
            {
                if (!(char.IsDigit(c)))
                {
                    array[index] = c;
                    index++;
                } 
                    
            }

            return array;
        }
    }
}
