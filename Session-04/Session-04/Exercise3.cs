using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercise3
    {
        public Exercise3()
        {
            
        }

        public int[] FindPrimeNumbers(int number)
        {
            if (number == 0 || number == 1) return new int[0];

            int index = 0;
            int[] primeNumbers = new int[number/2 + 1];
            for (int i = 2; i <= number; i++)
            {
                if (isPrime(i)) 
                { 
                    primeNumbers[index] = i;
                    index++;
                }
            }
            return  primeNumbers;
        }


        public void printArray(int[] primeNumbers)
        {
            if (primeNumbers.Length == 0)
            {
                Console.WriteLine("There are no prime numbers.");
                return;
            }

            for (int i = 0; i < primeNumbers.Count(n => n != 0); i++)
            {
                Console.Write(primeNumbers[i] + ", ");
            }
            Console.WriteLine();
        }


        private static bool isPrime(int number)
        {
            int factors = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) factors++;
                if (factors > 2) return false;
            }

            return true;
        }
    }
}
