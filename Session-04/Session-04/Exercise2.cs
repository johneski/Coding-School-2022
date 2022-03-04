using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercise2
    {
        public Exercise2()
        {

        }

        public int Sum(int number)
        {
            int sum = 0;

            for(int i = 0; i <= number; i++)
            {
                sum += i;
            }

            return sum;
        }

        public int Product(int number)
        {
            if (number == 0) return 0;

            int product = 1;

            for (int i = 1; i <= number; i++)
            {
                product *= i;
            }

            return product;
        }
    }
}
