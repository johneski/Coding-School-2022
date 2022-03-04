using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Validation
    {
        public Validation()
        {

        }

        public int Validate()
        {
            int number = 0;

            while (true)
            {
                try
                {
                    Console.Write("Enter a positive integer: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number >= 0) break;
                    else Console.WriteLine("Number cannot be negative!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong input...");
                }
            }
            return number;
        }
    }
}
