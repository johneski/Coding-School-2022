using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercise4
    {
        public Exercise4()
        {

        }

        public int[] multiply(int[] array1, int[] array2)
        {
            int[] mulArray = new int[16];
            
            int index = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mulArray[index] = array1[i] * array2[j];
                    index++;
                }
                
            }
            return mulArray;
        }
    }
}
