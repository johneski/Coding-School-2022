using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercise5
    {
        public Exercise5()
        {

        }

        public int[] BubbleSort(int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i -1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            return array;
        }

        public int[] SelectionSort(int[] array)
        {
            int min;
            int temp;
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                min = array[i];

                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        index = j;
                    }
                }

                temp = array[i];
                array[i] = min;
                array[index] = temp;
                index = i;
            }

            return array;
        }


        public void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
